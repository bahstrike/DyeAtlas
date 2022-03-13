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
            Palette.HueImportance = (double)hueTrack.Value / (double)(hueTrack.Maximum - hueTrack.Minimum);
            Palette.SaturationImportance = (double)satTrack.Value / (double)(satTrack.Maximum - satTrack.Minimum);
            Palette.ValueImportance = (double)valTrack.Value / (double)(valTrack.Maximum - valTrack.Minimum);



            // update UI
            hueLabel.Text = $"Hue Importance: {Palette.HueImportance.ToString("0.0")}";
            satLabel.Text = $"Saturation Importance: {Palette.SaturationImportance.ToString("0.0")}";
            valLabel.Text = $"Brightness Importance: {Palette.ValueImportance.ToString("0.0")}";


            // maybe reprocess
            if (reprocess)
            {
                Update();// flush before slow

                dyeAtlas.Reprocess();
            }
        }

        public bool updating = false;

        private void HSVSlidersPopup_Load(object sender, EventArgs e)
        {
            updating = true;
            hueTrack.Value = (int)Math.Round((Palette.HueImportance) * (double)(hueTrack.Maximum - hueTrack.Minimum));
            satTrack.Value = (int)Math.Round((Palette.SaturationImportance) * (double)(satTrack.Maximum - satTrack.Minimum));
            valTrack.Value = (int)Math.Round((Palette.ValueImportance) * (double)(valTrack.Maximum - valTrack.Minimum));
            updating = false;


            // just update labels
            UpdateValues(false);
        }

        private void HSVSlidersPopup_FormClosing(object sender, FormClosingEventArgs e)
        {
            dyeAtlas.hsvcompare.Checked = false;// we dont wanna use HSV anymore
        }

        private void Track_Scroll(object sender, EventArgs e)
        {
            UpdateValues(false);
        }

        private void Track_ValueChanged(object sender, EventArgs e)
        {
            if (updating)
                return;

            UpdateValues();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            updating = true;
            hueTrack.Value = 0;
            satTrack.Value = 0;
            valTrack.Value = 0;
            updating = false;

            UpdateValues();
        }
    }
}
