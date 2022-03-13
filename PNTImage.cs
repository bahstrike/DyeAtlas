using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace DyeAtlas
{
    public class PNTImage
    {
        public readonly Palette palette;

        public uint version;
        public int width;
        public int height;
        public uint revision;
        public int size;

        public byte[] bits;

        public PNTImage(Palette _palette)
        {
            palette = _palette;
        }

        public static PNTImage GenerateFromBitmap(Palette pal, Bitmap bmp, bool dither, bool hsvCompare)
        {
            PNTImage pnt = new PNTImage(pal);
            pnt.version = 1;
            pnt.width = bmp.Width;
            pnt.height = bmp.Height;
            pnt.revision = 1;
            pnt.size = pnt.width * pnt.height;
            pnt.bits = new byte[pnt.width * pnt.height];


            Bitmap scratch = (Bitmap)bmp.Clone();

            for (int y = 0; y < pnt.height; y++)
                for (int x = 0; x < pnt.width; x++)
                {
                    WorkColor clr = scratch.GetPixel(x, y);
                    pnt.SetPixel(x, y, clr, hsvCompare);

                    // if transparent, then no further processing
                    if (clr.Transparent)
                        continue;

                    // dithering
                    if (dither)
                    {
                        // Floyd–Steinberg
                        WorkColor newClr = pnt.GetPixel(x, y).Value;
                        WorkColor error = clr - newClr;

                        DitherHelper(scratch, x + 1, y, error * 7.0 / 16.0);
                        DitherHelper(scratch, x - 1, y + 1, error * 3.0 / 16.0);
                        DitherHelper(scratch, x, y + 1, error * 5.0 / 16.0);
                        DitherHelper(scratch, x + 1, y + 1, error * 1.0 / 16.0);
                    }
                }

            return pnt;
        }

        private static void DitherHelper(Bitmap bmp, int x, int y, WorkColor error)
        {
            // slow; should be precached
            int w = bmp.Width;
            int h = bmp.Height;

            if (x < 0 || x >= w || y < 0 || y >= h)
                return;

            WorkColor clr = bmp.GetPixel(x, y);

            // dont affect if transparent
            if (clr.Transparent)
                return;

            bmp.SetPixel(x, y, clr + error);
        }

        public static PNTImage LoadPNT(Palette pal, string file)
        {
            using (Stream fs = File.OpenRead(file))
            using (BinaryReader br = new BinaryReader(fs))
            {
                PNTImage pnt = new PNTImage(pal);
                pnt.version = br.ReadUInt32();
                pnt.width = br.ReadInt32();
                pnt.height = br.ReadInt32();
                pnt.revision = br.ReadUInt32();
                pnt.size = br.ReadInt32();

                pnt.bits = br.ReadBytes(pnt.size);

                return pnt;
            }
        }

        public void Save(string file)
        {
            using(Stream fs = File.Create(file))
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                bw.Write(version);
                bw.Write(width);
                bw.Write(height);
                bw.Write(revision);
                bw.Write(size);

                bw.Write(bits);
            }
        }

        public Color? GetPixel(int x, int y)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
                return null;

            return palette.Get(bits[x + y * width]);
        }

        public void SetPixel(int x, int y, Color clr, bool hsvCompare)
        {
            if (x < 0 || x >= width || y < 0 || y >= height)
                return;

            bits[x + y * width] = (byte)palette.FindClosestIndex(clr, hsvCompare);
        }

        public Bitmap GenerateBitmap()
        {
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format32bppArgb);

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                {
                    bmp.SetPixel(x, y, palette.Get(bits[x + y * width]) ?? Color.FromArgb(0, 0, 0, 0));
                }

            return bmp;
        }
    }
}
