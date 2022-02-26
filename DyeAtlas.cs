using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace DyeAtlas
{
    public partial class DyeAtlas : Form
    {
        public DyeAtlas()
        {
            InitializeComponent();
        }

        public enum GameType
        {
            Ark,
            Atlas
        }

        public Palette LoadPalette(GameType gt)
        {
            Stream s = Assembly.GetExecutingAssembly().GetManifestResourceStream($"DyeAtlas.palette_{gt.ToString().ToLowerInvariant()}.csv");

            Palette pal = Palette.LoadFromCSV(s);

            s.Dispose();

            return pal;
        }

        public static Palette palette;// defer loading until form load..  make sure config files are nice

        private void DyeAtlas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("need a dropdown for gametype");
            palette = LoadPalette(GameType.Ark);

            Bitmap bk = new Bitmap(preview.Width, preview.Height);
            using (Graphics gfx = Graphics.FromImage(bk))
            {
                gfx.FillRectangle(new HatchBrush(HatchStyle.DarkDownwardDiagonal, Color.FromArgb(20, 20, 20), Color.FromArgb(128, 40, 128)), new Rectangle(0, 0, preview.Width, preview.Height));
            }
            preview.BackgroundImage = bk;

            resolution.SelectedIndex = 1;// 256x256

            // nothing is loaded yet, so nothing can be saved
            savePNGButton.Enabled = false;
            savePNTButton.Enabled = false;

            // load settings
            mypaintings.Text = Properties.Settings.Default.MyPaintings;
        }

        private void DyeAtlas_FormClosed(object sender, FormClosedEventArgs e)
        {
            // save settings
            Properties.Settings.Default.MyPaintings = mypaintings.Text;
        }

        // convenience
        public string MyPaintingsPath
        {
            get
            {
                return mypaintings.Text;
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            e.Effect = DragDropEffects.Link;
        }

        public void SaveFile(string file)
        {
            try
            {
                Bitmap bmp = preview.Image as Bitmap;
                if (bmp == null)
                    return;

                if(Path.GetExtension(file).Equals(".pnt", StringComparison.InvariantCultureIgnoreCase))//IsFilePNT(file))
                {
                    PNTImage pnt = PNTImage.GenerateFromBitmap(bmp, dithering.Checked);

                    pnt.Save(file);
                }else
                {
                    bmp.Save(file);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Size ExportDimensions
        {
            get
            {
                Size sz = new Size(256, 256);//default

                string[] parts = resolution.Text.Split(new char[] { 'x', 'X', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(parts.Length>=2)
                {
                    sz.Width = int.Parse(parts[0]);
                    sz.Height = int.Parse(parts[1]);
                }

                return sz;
            }
        }

        public void OpenFile(string file)
        {
            if (string.IsNullOrEmpty(file) || !File.Exists(file))
                return;

            try
            {

                PNTImage pnt = null;

                switch (Path.GetExtension(file).ToLowerInvariant())
                {
                    case ".pnt":
                        pnt = PNTImage.LoadPNT(file);

                        // autoselect resolution
                        if (pnt.width >= 256)
                            resolution.SelectedIndex = 1;//256x256
                        else
                            resolution.SelectedIndex = 0;//128x128   (shrug)
                        break;

                    case ".bmp":
                    case ".png":
                    case ".jpg":
                    case ".jpeg":
                    case ".gif":
                    case ".tga":
                    case ".tiff":
                        {
                            Bitmap bmp = (Bitmap)Bitmap.FromFile(file);

                            // powers-of-2 automatic rescale
                            int newWidth = (int)Math.Pow(2.0, Math.Ceiling(Math.Log((double)bmp.Width) / Math.Log(2.0)));
                            int newHeight = (int)Math.Pow(2.0, Math.Ceiling(Math.Log((double)bmp.Height) / Math.Log(2.0)));

                            // clamp to allowable export dimensions (assumed power-of-2)
                            newWidth = Math.Min(ExportDimensions.Width, newWidth);
                            newHeight = Math.Min(ExportDimensions.Height, newHeight);

                            // hold onto yerr hats, its time to rescale!
                            if (newWidth != bmp.Width || newHeight != bmp.Height)
                            {
                                Bitmap newBmp = new Bitmap(newWidth, newHeight, PixelFormat.Format32bppArgb);
                                newBmp.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

                                using (Graphics gfx = Graphics.FromImage(newBmp))
                                {
                                    gfx.CompositingMode = CompositingMode.SourceCopy;
                                    gfx.InterpolationMode = InterpolationMode.NearestNeighbor;
                                    gfx.PixelOffsetMode = PixelOffsetMode.HighQuality;

                                    using (ImageAttributes wrapMode = new ImageAttributes())
                                    {
                                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                                        gfx.DrawImage(bmp, new Rectangle(0, 0, newWidth, newHeight), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, wrapMode);
                                    }
                                }

                                bmp.Dispose();
                                bmp = newBmp;
                            }

                            pnt = PNTImage.GenerateFromBitmap(bmp, dithering.Checked);
                        }
                        break;
                }

                if(pnt == null)
                {
                    // should we scold idiots? for dragging bad files
                    //Messagebo
                    return;
                }

                currentfile.Text = file;
                resolution.Text = $"{pnt.width}x{pnt.height}";

                preview.Image = pnt.GenerateBitmap();


                // we got stuff, we could save
                savePNTButton.Enabled = true;
                savePNGButton.Enabled = true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            string[] files = e.Data.GetData(DataFormats.FileDrop) as string[];

            OpenFile(files[0]);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (Directory.Exists(MyPaintingsPath))
                ofd.InitialDirectory = MyPaintingsPath;

            ofd.Filter = "Compatible Files (*.pnt;*.png;*.bmp;*.jpg)|*.pnt;*.png;*.bmp;*.jpg|Paint Files (*.pnt)|*.pnt|Image Files (*.png;*.bmp;*.jpg)|*.png;*.bmp;*.jpg|All Files (*.*)|*.*";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            OpenFile(ofd.FileName);
        }

        private void dithering_CheckedChanged(object sender, EventArgs e)
        {
            OpenFile(currentfile.Text);
        }

        private void savePNTButton_Click(object sender, EventArgs e)
        {
            // dont do popup if image is blank; prolly button should be disabled
            if (preview.Image == null)
                return;

            SaveFileDialog sfd = new SaveFileDialog();

            if (Directory.Exists(MyPaintingsPath))
                sfd.InitialDirectory = MyPaintingsPath;

            sfd.Filter = "Paint File (*.pnt)|*.pnt|All Files (*.*)|*.*";


            // default some save filename
            sfd.FileName = Path.GetFileNameWithoutExtension(currentfile.Text) + ".pnt";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            SaveFile(sfd.FileName);
        }

        private void savePNGButton_Click(object sender, EventArgs e)
        {
            // dont do popup if image is blank; prolly button should be disabled
            if (preview.Image == null)
                return;

            SaveFileDialog sfd = new SaveFileDialog();

            if (Directory.Exists(MyPaintingsPath))
                sfd.InitialDirectory = MyPaintingsPath;

            sfd.RestoreDirectory = true;// if we are exporting image to desktop or whatever then we should not mess with open file
            sfd.Filter = "PNG File (*.png)|*.png|Image Files (*.png;*.bmp;*.jpg)|*.png;*.bmp;*.jpg|All Files (*.*)|*.*";

            // default some save filename
            sfd.FileName = Path.GetFileNameWithoutExtension(currentfile.Text) + ".png";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            SaveFile(sfd.FileName);
        }

        private void resolution_TextChanged(object sender, EventArgs e)
        {
            OpenFile(currentfile.Text);
        }

        private void mypaintingsbrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fld = new FolderBrowserDialog();

            fld.SelectedPath = mypaintings.Text;
            fld.Description = @"This is usually like:   [ATLAS install]\ShooterGame\Saved\MyPaintings";

            if (fld.ShowDialog() != DialogResult.OK)
                return;

            mypaintings.Text = fld.SelectedPath;
        }

        private void openfolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", mypaintings.Text);
        }
    }
}
