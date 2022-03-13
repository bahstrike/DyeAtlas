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
            this.satLabel = new System.Windows.Forms.Label();
            this.satTrack = new System.Windows.Forms.TrackBar();
            this.valLabel = new System.Windows.Forms.Label();
            this.valTrack = new System.Windows.Forms.TrackBar();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hueTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // hueTrack
            // 
            this.hueTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hueTrack.LargeChange = 10;
            this.hueTrack.Location = new System.Drawing.Point(12, 35);
            this.hueTrack.Maximum = 100;
            this.hueTrack.Minimum = -100;
            this.hueTrack.Name = "hueTrack";
            this.hueTrack.Size = new System.Drawing.Size(523, 45);
            this.hueTrack.SmallChange = 5;
            this.hueTrack.TabIndex = 0;
            this.hueTrack.TickFrequency = 5;
            this.hueTrack.Scroll += new System.EventHandler(this.Track_Scroll);
            this.hueTrack.ValueChanged += new System.EventHandler(this.Track_ValueChanged);
            // 
            // hueLabel
            // 
            this.hueLabel.AutoSize = true;
            this.hueLabel.Location = new System.Drawing.Point(12, 19);
            this.hueLabel.Name = "hueLabel";
            this.hueLabel.Size = new System.Drawing.Size(35, 13);
            this.hueLabel.TabIndex = 1;
            this.hueLabel.Text = "label1";
            // 
            // satLabel
            // 
            this.satLabel.AutoSize = true;
            this.satLabel.Location = new System.Drawing.Point(12, 80);
            this.satLabel.Name = "satLabel";
            this.satLabel.Size = new System.Drawing.Size(35, 13);
            this.satLabel.TabIndex = 3;
            this.satLabel.Text = "label1";
            // 
            // satTrack
            // 
            this.satTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.satTrack.LargeChange = 10;
            this.satTrack.Location = new System.Drawing.Point(12, 96);
            this.satTrack.Maximum = 100;
            this.satTrack.Minimum = -100;
            this.satTrack.Name = "satTrack";
            this.satTrack.Size = new System.Drawing.Size(523, 45);
            this.satTrack.SmallChange = 5;
            this.satTrack.TabIndex = 2;
            this.satTrack.TickFrequency = 5;
            this.satTrack.Scroll += new System.EventHandler(this.Track_Scroll);
            this.satTrack.ValueChanged += new System.EventHandler(this.Track_ValueChanged);
            // 
            // valLabel
            // 
            this.valLabel.AutoSize = true;
            this.valLabel.Location = new System.Drawing.Point(12, 141);
            this.valLabel.Name = "valLabel";
            this.valLabel.Size = new System.Drawing.Size(35, 13);
            this.valLabel.TabIndex = 5;
            this.valLabel.Text = "label1";
            // 
            // valTrack
            // 
            this.valTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valTrack.LargeChange = 10;
            this.valTrack.Location = new System.Drawing.Point(12, 157);
            this.valTrack.Maximum = 100;
            this.valTrack.Minimum = -100;
            this.valTrack.Name = "valTrack";
            this.valTrack.Size = new System.Drawing.Size(523, 45);
            this.valTrack.SmallChange = 5;
            this.valTrack.TabIndex = 4;
            this.valTrack.TickFrequency = 5;
            this.valTrack.Scroll += new System.EventHandler(this.Track_Scroll);
            this.valTrack.ValueChanged += new System.EventHandler(this.Track_ValueChanged);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(460, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // HSVSlidersPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 203);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.valLabel);
            this.Controls.Add(this.valTrack);
            this.Controls.Add(this.satLabel);
            this.Controls.Add(this.satTrack);
            this.Controls.Add(this.hueLabel);
            this.Controls.Add(this.hueTrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HSVSlidersPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Tune Colors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HSVSlidersPopup_FormClosing);
            this.Load += new System.EventHandler(this.HSVSlidersPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hueTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar hueTrack;
        private System.Windows.Forms.Label hueLabel;
        private System.Windows.Forms.Label satLabel;
        private System.Windows.Forms.TrackBar satTrack;
        private System.Windows.Forms.Label valLabel;
        private System.Windows.Forms.TrackBar valTrack;
        private System.Windows.Forms.Button resetButton;
    }
}