namespace CVIS
{
    partial class Patient_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Main));
            banner = new Panel();
            logo = new PictureBox();
            profile = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            SuspendLayout();
            // 
            // banner
            // 
            banner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            banner.AutoSize = true;
            banner.BackColor = Color.FromArgb(0, 151, 136);
            banner.Controls.Add(logo);
            banner.Controls.Add(profile);
            banner.Location = new Point(0, 0);
            banner.Name = "banner";
            banner.Size = new Size(764, 80);
            banner.TabIndex = 5;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(12, 10);
            logo.Name = "logo";
            logo.Size = new Size(150, 60);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // profile
            // 
            profile.Image = (Image)resources.GetObject("profile.Image");
            profile.Location = new Point(660, 10);
            profile.Name = "profile";
            profile.Size = new Size(83, 60);
            profile.SizeMode = PictureBoxSizeMode.Zoom;
            profile.TabIndex = 1;
            profile.TabStop = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(13, 261);
            panel2.Name = "panel2";
            panel2.Size = new Size(730, 198);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.Location = new Point(442, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(301, 169);
            panel3.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 169);
            panel1.TabIndex = 6;
            // 
            // Patient_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(754, 471);
            Controls.Add(banner);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Patient_Main";
            Text = "Patient_Main";
            banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel banner;
        private PictureBox logo;
        private PictureBox profile;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
    }
}