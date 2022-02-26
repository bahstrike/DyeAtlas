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
            ((System.ComponentModel.ISupportInitialize)(this.preview)).BeginInit();
            this.SuspendLayout();
            // 
            // preview
            // 
            this.preview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.preview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.preview.Location = new System.Drawing.Point(12, 68);
            this.preview.Name = "preview";
            this.preview.Size = new System.Drawing.Size(415, 360);
            this.preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.preview.TabIndex = 0;
            this.preview.TabStop = false;
            // 
            // dithering
            // 
            this.dithering.AutoSize = true;
            this.dithering.Checked = true;
            this.dithering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dithering.Location = new System.Drawing.Point(333, 45);
            this.dithering.Name = "dithering";
            this.dithering.Size = new System.Drawing.Size(66, 17);
            this.dithering.TabIndex = 2;
            this.dithering.Text = "dithering";
            this.dithering.UseVisualStyleBackColor = true;
            this.dithering.CheckedChanged += new System.EventHandler(this.dithering_CheckedChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(12, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 50);
            this.openButton.TabIndex = 3;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // savePNTButton
            // 
            this.savePNTButton.Location = new System.Drawing.Point(118, 12);
            this.savePNTButton.Name = "savePNTButton";
            this.savePNTButton.Size = new System.Drawing.Size(100, 50);
            this.savePNTButton.TabIndex = 4;
            this.savePNTButton.Text = "Save .PNT";
            this.savePNTButton.UseVisualStyleBackColor = true;
            this.savePNTButton.Click += new System.EventHandler(this.savePNTButton_Click);
            // 
            // savePNGButton
            // 
            this.savePNGButton.Location = new System.Drawing.Point(224, 12);
            this.savePNGButton.Name = "savePNGButton";
            this.savePNGButton.Size = new System.Drawing.Size(100, 50);
            this.savePNGButton.TabIndex = 5;
            this.savePNGButton.Text = "Save .PNG";
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
            this.resolution.Location = new System.Drawing.Point(330, 12);
            this.resolution.Name = "resolution";
            this.resolution.Size = new System.Drawing.Size(97, 21);
            this.resolution.TabIndex = 6;
            this.resolution.TextChanged += new System.EventHandler(this.resolution_TextChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 440);
            this.Controls.Add(this.resolution);
            this.Controls.Add(this.savePNGButton);
            this.Controls.Add(this.savePNTButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dithering);
            this.Controls.Add(this.preview);
            this.Name = "Form1";
            this.Text = "DyeAtlas - BAH 2022";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

