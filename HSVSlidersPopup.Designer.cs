namespace DyeAtlas
{
    partial class HSVSlidersPopup
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
            this.hueTrack = new System.Windows.Forms.TrackBar();
            this.hueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // hueTrack
            // 
            this.hueTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hueTrack.LargeChange = 10;
            this.hueTrack.Location = new System.Drawing.Point(12, 25);
            this.hueTrack.Maximum = 100;
            this.hueTrack.Minimum = -100;
            this.hueTrack.Name = "hueTrack";
            this.hueTrack.Size = new System.Drawing.Size(523, 45);
            this.hueTrack.SmallChange = 5;
            this.hueTrack.TabIndex = 0;
            this.hueTrack.TickFrequency = 5;
            this.hueTrack.Scroll += new System.EventHandler(this.hueTrack_Scroll);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(12, 9);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(35, 13);
            this.hueLabel.TabIndex = 1;
            this.hueLabel.Text = "label1";
            // 
            // HSVSlidersPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 221);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.hueTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HSVSlidersPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HSV Sliders";
            this.Load += new System.EventHandler(this.HSVSlidersPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hueTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar hueTrack;
        private System.Windows.Forms.Label hueLabel;
    }
}