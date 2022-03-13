namespace DyeAtlas
{
    partial class DyeAtlas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.preview = new System.Windows.Forms.PictureBox();
            this.dithering = new System.Windows.Forms.CheckBox();
            this.openButton = new System.Windows.Forms.Button();
            this.savePNTButton = new System.Windows.Forms.Button();
            this.savePNGButton = new System.Windows.Forms.Button();
            this.resolution = new System.Windows.Forms.ComboBox();
            this.mypaintings = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mypaintingsbrowse = new System.Windows.Forms.Button();
            this.currentfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.openfolder = new System.Windows.Forms.Button();
            this.gamechoice = new System.Windows.Forms.ComboBox();
            this.hsvcompare = new System.Windows.Forms.CheckBox();
            this.hsvcompareButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview.Location = new System.Drawing.Point(12, 168);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(450, 381);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // dithering
            // 
            this.dithering.AutoSize = true;
            this.dithering.Checked = true;
            this.dithering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dithering.Location = new System.Drawing.Point(333, 97);
            this.dithering.Name = "dithering";
            this.dithering.Size = new System.Drawing.Size(66, 17);
            this.dithering.TabIndex = 2;
            this.dithering.Text = "dithering";
            this.dithering.UseVisualStyleBackColor = true;
            this.dithering.CheckedChanged += new System.EventHandler(this.dithering_CheckedChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 64);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 50);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // savePNTButton
            // 
            this.savePNTButton.Location = new System.Drawing.Point(118, 64);
            this.savePNTButton.Name = "savePNTButton";
            this.savePNTButton.Size = new System.Drawing.Size(100, 50);
            this.savePNTButton.TabIndex = 4;
            this.savePNTButton.Text = "Save .PNT\r\n(game)";
            this.savePNTButton.UseVisualStyleBackColor = true;
            this.savePNTButton.Click += new System.EventHandler(this.savePNTButton_Click);
            // 
            // savePNGButton
            // 
            this.savePNGButton.Location = new System.Drawing.Point(224, 64);
            this.savePNGButton.Name = "savePNGButton";
            this.savePNGButton.Size = new System.Drawing.Size(100, 50);
            this.savePNGButton.TabIndex = 5;
            this.savePNGButton.Text = "Save .PNG\r\n(pc)";
            this.savePNGButton.UseVisualStyleBackColor = true;
            this.savePNGButton.Click += new System.EventHandler(this.savePNGButton_Click);
            // 
            // resolution
            // 
            this.resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resolution.FormattingEnabled = true;
            this.resolution.Items.AddRange(new object[] {
            "128x128",
            "256x256"});
            this.resolution.Location = new System.Drawing.Point(330, 64);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(80, 21);
            this.resolution.TabIndex = 6;
            this.resolution.TextChanged += new System.EventHandler(this.resolution_TextChanged);
            // 
            // mypaintings
            // 
            this.mypaintings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mypaintings.Location = new System.Drawing.Point(12, 38);
            this.mypaintings.Name = "mypaintings";
            this.mypaintings.Size = new System.Drawing.Size(412, 20);
            this.mypaintings.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "MyPaintings Path:";
            // 
            // mypaintingsbrowse
            // 
            this.mypaintingsbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mypaintingsbrowse.Location = new System.Drawing.Point(430, 38);
            this.mypaintingsbrowse.Name = "mypaintingsbrowse";
            this.mypaintingsbrowse.Size = new System.Drawing.Size(29, 20);
            this.mypaintingsbrowse.TabIndex = 9;
            this.mypaintingsbrowse.Text = "...";
            this.mypaintingsbrowse.UseVisualStyleBackColor = true;
            this.mypaintingsbrowse.Click += new System.EventHandler(this.mypaintingsbrowse_Click);
            // 
            // currentfile
            // 
            this.currentfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentfile.Location = new System.Drawing.Point(12, 142);
            this.currentfile.Name = "currentfile";
            this.currentfile.ReadOnly = true;
            this.currentfile.Size = new System.Drawing.Size(450, 20);
            this.currentfile.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current File:";
            // 
            // openfolder
            // 
            this.openfolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openfolder.Location = new System.Drawing.Point(413, 65);
            this.openfolder.Name = "openfolder";
            this.openfolder.Size = new System.Drawing.Size(46, 20);
            this.openfolder.TabIndex = 12;
            this.openfolder.Text = "folder";
            this.openfolder.UseVisualStyleBackColor = true;
            this.openfolder.Click += new System.EventHandler(this.openfolder_Click);
            // 
            // gamechoice
            // 
            this.gamechoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamechoice.FormattingEnabled = true;
            this.gamechoice.Items.AddRange(new object[] {
            "Ark",
            "Atlas"});
            this.gamechoice.Location = new System.Drawing.Point(12, 12);
            this.gamechoice.Name = "gamechoice";
            this.gamechoice.Size = new System.Drawing.Size(52, 21);
            this.gamechoice.TabIndex = 13;
            this.gamechoice.SelectedIndexChanged += new System.EventHandler(this.gamechoice_SelectedIndexChanged);
            // 
            // hsvcompare
            // 
            this.hsvcompare.AutoSize = true;
            this.hsvcompare.Checked = true;
            this.hsvcompare.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hsvcompare.Location = new System.Drawing.Point(333, 119);
            this.hsvcompare.Name = "hsvcompare";
            this.hsvcompare.Size = new System.Drawing.Size(92, 17);
            this.hsvcompare.TabIndex = 14;
            this.hsvcompare.Text = "HSV compare";
            this.hsvcompare.UseVisualStyleBackColor = true;
            this.hsvcompare.CheckedChanged += new System.EventHandler(this.hsvcompare_CheckedChanged);
            // 
            // hsvcompareButton
            // 
            this.hsvcompareButton.Location = new System.Drawing.Point(432, 115);
            this.hsvcompareButton.Name = "hsvcompareButton";
            this.hsvcompareButton.Size = new System.Drawing.Size(30, 23);
            this.hsvcompareButton.TabIndex = 15;
            this.hsvcompareButton.Text = "...";
            this.hsvcompareButton.UseVisualStyleBackColor = true;
            this.hsvcompareButton.Click += new System.EventHandler(this.hsvcompareButton_Click);
            // 
            // DyeAtlas
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 561);
            this.Controls.Add(this.hsvcompareButton);
            this.Controls.Add(this.hsvcompare);
            this.Controls.Add(this.gamechoice);
            this.Controls.Add(this.openfolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentfile);
            this.Controls.Add(this.mypaintingsbrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mypaintings);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.savePNGButton);
            this.Controls.Add(this.savePNTButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dithering);
            this.Controls.Add(this.preview);
            this.Name = "DyeAtlas";
            this.Text = "DyeAtlas - BAH 2022";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DyeAtlas_FormClosed);
            this.Load += new System.EventHandler(this.DyeAtlas_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.preview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox preview;
        private System.Windows.Forms.CheckBox dithering;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button savePNTButton;
        private System.Windows.Forms.Button savePNGButton;
        private System.Windows.Forms.ComboBox resolution;
        private System.Windows.Forms.TextBox mypaintings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mypaintingsbrowse;
        private System.Windows.Forms.TextBox currentfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openfolder;
        private System.Windows.Forms.ComboBox gamechoice;
        private System.Windows.Forms.CheckBox hsvcompare;
        public System.Windows.Forms.Button hsvcompareButton;
    }
}

