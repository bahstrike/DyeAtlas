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
            Palette.SaturationImportance = /*baseline*/1.0 + (double)satTrack.Value / (double)(satTrack.Maximum - satTrack.Minimum);
            Palette.ValueImportance = /*baseline*/1.0 + (double)valTrack.Value / (double)(valTrack.Maximum - valTrack.Minimum);



            // update UI
            hueLabel.Text = $"Hue: {(Palette.HueImportance * 100.0).ToString("0.0")}";
            satLabel.Text = $"Saturation: {(Palette.SaturationImportance * 100.0).ToString("0.0")}";
            valLabel.Text = $"Value: {(Palette.ValueImportance * 100.0).ToString("0.0")}";



            // maybe reprocess
            if (reprocess)
                dyeAtlas.Reprocess();
        }

        private void HSVSlidersPopup_Load(object sender, EventArgs e)
        {
            hueTrack.Value = (int)Math.Round((Palette.HueImportance - 1.0) * (double)(hueTrack.Maximum - hueTrack.Minimum));
            satTrack.Value = (int)Math.Round((Palette.SaturationImportance - 1.0) * (double)(satTrack.Maximum - satTrack.Minimum));
            valTrack.Value = (int)Math.Round((Palette.ValueImportance - 1.0) * (double)(valTrack.Maximum - valTrack.Minimum));


            // just update labels
            UpdateValues(false);
        }

        private void HSVSlidersPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            dyeAtlas.hsvcompare.Checked = false;// we dont wanna use HSV anymore
        }

        private void Track_Scroll(object sender, EventArgs e)
        {
            UpdateValues();
        }
    }
}
