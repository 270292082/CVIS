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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Profile));
            this.profile = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.Panel();
            this.logo_button = new System.Windows.Forms.PictureBox();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.vac_stat_text = new System.Windows.Forms.Label();
            this.qrcode_text = new System.Windows.Forms.Label();
            this.patient_ID_text = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Panel();
            this.relevantdoc_text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emergency_edit_button = new System.Windows.Forms.Button();
            this.emergency_contact_text = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_status = new System.Windows.Forms.Panel();
            this.info_text = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.content.SuspendLayout();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.user_status.SuspendLayout();
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
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.AutoSize = true;
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.banner.Controls.Add(this.logo_button);
            this.banner.Controls.Add(this.profile);
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(654, 60);
            this.banner.TabIndex = 6;
            // 
            // logo_button
            // 
            this.logo_button.Image = global::CVIS.Properties.Resources.logo_white;
            this.logo_button.Location = new System.Drawing.Point(12, 8);
            this.logo_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_button.Name = "logo_button";
            this.logo_button.Size = new System.Drawing.Size(131, 45);
            this.logo_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_button.TabIndex = 0;
            this.logo_button.TabStop = false;
            this.logo_button.Click += new System.EventHandler(this.logo_button_Click);
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
            this.content.Controls.Add(this.vac_stat_text);
            this.content.Controls.Add(this.qrcode_text);
            this.content.Controls.Add(this.patient_ID_text);
            this.content.Controls.Add(this.info);
            this.content.Controls.Add(this.user_status);
            this.content.Controls.Add(this.profile_picture);
            this.content.Location = new System.Drawing.Point(12, 65);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(630, 284);
            this.content.TabIndex = 7;
            // 
            // vac_stat_text
            // 
            this.vac_stat_text.AutoSize = true;
            this.vac_stat_text.Location = new System.Drawing.Point(104, 48);
            this.vac_stat_text.Name = "vac_stat_text";
            this.vac_stat_text.Size = new System.Drawing.Size(112, 15);
            this.vac_stat_text.TabIndex = 8;
            this.vac_stat_text.Text = "Vaccination Status : ";
            // 
            // qrcode_text
            // 
            this.qrcode_text.BackColor = System.Drawing.Color.LightCyan;
            this.qrcode_text.Font = new System.Drawing.Font("Consolas", 2.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qrcode_text.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.qrcode_text.Location = new System.Drawing.Point(540, 0);
            this.qrcode_text.Name = "qrcode_text";
            this.qrcode_text.Size = new System.Drawing.Size(84, 84);
            this.qrcode_text.TabIndex = 7;
            this.qrcode_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // patient_ID_text
            // 
            this.patient_ID_text.AutoSize = true;
            this.patient_ID_text.Location = new System.Drawing.Point(104, 27);
            this.patient_ID_text.Name = "patient_ID_text";
            this.patient_ID_text.Size = new System.Drawing.Size(50, 15);
            this.patient_ID_text.TabIndex = 6;
            this.patient_ID_text.Text = "User ID :";
            // 
            // info
            // 
            this.info.Controls.Add(this.relevantdoc_text);
            this.info.Controls.Add(this.label2);
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.emergency_edit_button);
            this.info.Controls.Add(this.emergency_contact_text);
            this.info.Controls.Add(this.pictureBox2);
            this.info.Controls.Add(this.pictureBox1);
            this.info.Location = new System.Drawing.Point(372, 87);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(255, 194);
            this.info.TabIndex = 4;
            // 
            // relevantdoc_text
            // 
            this.relevantdoc_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.relevantdoc_text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.relevantdoc_text.Location = new System.Drawing.Point(10, 147);
            this.relevantdoc_text.Name = "relevantdoc_text";
            this.relevantdoc_text.Size = new System.Drawing.Size(235, 42);
            this.relevantdoc_text.TabIndex = 6;
            this.relevantdoc_text.Text = "None";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Relevant Documents";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Emergency Contact";
            // 
            // emergency_edit_button
            // 
            this.emergency_edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emergency_edit_button.BackgroundImage")));
            this.emergency_edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emergency_edit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.FlatAppearance.BorderSize = 0;
            this.emergency_edit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergency_edit_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emergency_edit_button.Location = new System.Drawing.Point(10, 78);
            this.emergency_edit_button.Name = "emergency_edit_button";
            this.emergency_edit_button.Size = new System.Drawing.Size(235, 29);
            this.emergency_edit_button.TabIndex = 3;
            this.emergency_edit_button.Text = "Edit Emergency Contact";
            this.emergency_edit_button.UseVisualStyleBackColor = false;
            // 
            // emergency_contact_text
            // 
            this.emergency_contact_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_contact_text.Location = new System.Drawing.Point(10, 29);
            this.emergency_contact_text.Name = "emergency_contact_text";
            this.emergency_contact_text.Size = new System.Drawing.Size(235, 46);
            this.emergency_contact_text.TabIndex = 2;
            this.emergency_contact_text.Text = "[Info]";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(249, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // user_status
            // 
            this.user_status.Controls.Add(this.info_text);
            this.user_status.Location = new System.Drawing.Point(3, 87);
            this.user_status.Name = "user_status";
            this.user_status.Size = new System.Drawing.Size(363, 194);
            this.user_status.TabIndex = 3;
            // 
            // info_text
            // 
            this.info_text.Location = new System.Drawing.Point(10, 9);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(348, 176);
            this.info_text.TabIndex = 7;
            this.info_text.Text = "[Info]";
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
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.user_status.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox profile;
        private Panel banner;
        private PictureBox logo_button;
        private PictureBox profile_picture;
        private Panel content;
        private Panel info;
        private Panel user_status;
        private Label info_text;
        private Label patient_ID_text;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label emergency_contact_text;
        private Button emergency_edit_button;
        private Label label1;
        private Label relevantdoc_text;
        private Label label2;
        private Label qrcode_text;
        private Label vac_stat_text;
    }
}