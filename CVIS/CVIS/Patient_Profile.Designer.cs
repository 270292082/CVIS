namespace CVIS
{
    partial class Patient_Profile
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
            this.profile = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.position = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.Label();
            this.patient_ID_text = new System.Windows.Forms.Label();
            this.settings = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.Panel();
            this.user_status = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.content.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).BeginInit();
            this.SuspendLayout();
            // 
            // profile
            // 
            this.profile.Image = global::CVIS.Properties.Resources.profile_placeholder;
            this.profile.Location = new System.Drawing.Point(570, 9);
            this.profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(72, 42);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 1;
            this.profile.TabStop = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.AutoSize = true;
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.banner.Controls.Add(this.logo);
            this.banner.Controls.Add(this.profile);
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(654, 60);
            this.banner.TabIndex = 6;
            // 
            // logo
            // 
            this.logo.Image = global::CVIS.Properties.Resources.logo_white;
            this.logo.Location = new System.Drawing.Point(12, 8);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(131, 45);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // profile_picture
            // 
            this.profile_picture.Image = global::CVIS.Properties.Resources.profile_placeholder;
            this.profile_picture.Location = new System.Drawing.Point(13, 12);
            this.profile_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(70, 70);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_picture.TabIndex = 2;
            this.profile_picture.TabStop = false;
            // 
            // content
            // 
            this.content.Controls.Add(this.position);
            this.content.Controls.Add(this.name_text);
            this.content.Controls.Add(this.patient_ID_text);
            this.content.Controls.Add(this.settings);
            this.content.Controls.Add(this.info);
            this.content.Controls.Add(this.user_status);
            this.content.Controls.Add(this.profile_picture);
            this.content.Location = new System.Drawing.Point(12, 65);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(630, 284);
            this.content.TabIndex = 7;
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(104, 57);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(44, 15);
            this.position.TabIndex = 8;
            this.position.Text = "Patient";
            // 
            // name_text
            // 
            this.name_text.AutoSize = true;
            this.name_text.Location = new System.Drawing.Point(104, 42);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(47, 15);
            this.name_text.TabIndex = 7;
            this.name_text.Text = "[Name]";
            // 
            // patient_ID_text
            // 
            this.patient_ID_text.AutoSize = true;
            this.patient_ID_text.Location = new System.Drawing.Point(104, 27);
            this.patient_ID_text.Name = "patient_ID_text";
            this.patient_ID_text.Size = new System.Drawing.Size(26, 15);
            this.patient_ID_text.TabIndex = 6;
            this.patient_ID_text.Text = "[ID]";
            // 
            // settings
            // 
            this.settings.Image = global::CVIS.Properties.Resources.settings;
            this.settings.Location = new System.Drawing.Point(578, 12);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(30, 30);
            this.settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settings.TabIndex = 5;
            this.settings.TabStop = false;
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(372, 87);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(255, 194);
            this.info.TabIndex = 4;
            // 
            // user_status
            // 
            this.user_status.Location = new System.Drawing.Point(3, 87);
            this.user_status.Name = "user_status";
            this.user_status.Size = new System.Drawing.Size(363, 194);
            this.user_status.TabIndex = 3;
            // 
            // Patient_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.content);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Profile";
            this.Text = "Patient_Profile";
            this.Load += new System.EventHandler(this.Patient_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox profile;
        private Panel banner;
        private PictureBox logo;
        private PictureBox profile_picture;
        private Panel content;
        private Panel info;
        private Panel user_status;
        private PictureBox settings;
        private Label position;
        private Label name_text;
        private Label patient_ID_text;
    }
}