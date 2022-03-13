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

        private void HSVSlidersPopup_FormClosed(object sender, FormClosedEventArgs e)
        {
            // re-enable popup button again
            dyeAtlas.hsvcompareButton.Enabled = true;
        }
    }
}
