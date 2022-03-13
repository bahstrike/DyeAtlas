using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DyeAtlas
{
    public partial class HSVSlidersPopup : Form
    {
        public readonly DyeAtlas dyeAtlas;

        public HSVSlidersPopup(DyeAtlas _dyeAtlas)
        {
            dyeAtlas = _dyeAtlas;

            InitializeComponent();
        }

        void UpdateValues(bool reprocess=true)
        {
            // cheating with static values lol
            Palette.HueImportance = /*baseline*/1.0 + (double)hueTrack.Value / (double)(hueTrack.Maximum - hueTrack.Minimum);



            // update UI
            hueLabel.Text = $"Hue: {(Palette.HueImportance * 100.0).ToString("0.0")}";



            // maybe reprocess
            if(reprocess)
                dyeAtlas.Reprocess();
        }

        private void HSVSlidersPopup_Load(object sender, EventArgs e)
        {
            hueTrack.Value = (int)Math.Round((Palette.HueImportance - 1.0) * (double)(hueTrack.Maximum - hueTrack.Minimum));


            // just update labels
            UpdateValues(false);
        }

        private void hueTrack_Scroll(object sender, EventArgs e)
        {
            UpdateValues();
        }
    }
}
