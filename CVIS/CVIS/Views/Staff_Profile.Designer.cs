namespace CVIS
{
    partial class Staff_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Profile));
            this.Banner = new System.Windows.Forms.Panel();
            this.profile = new System.Windows.Forms.PictureBox();
            this.logo_button = new System.Windows.Forms.PictureBox();
            this.menu_button = new System.Windows.Forms.PictureBox();
            this.content = new System.Windows.Forms.Panel();
            this.hosdept_text = new System.Windows.Forms.Label();
            this.position_text = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.Label();
            this.admin_ID_text = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.emergency_edit_button = new System.Windows.Forms.Button();
            this.emergency_contact_text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_status = new System.Windows.Forms.Panel();
            this.info_text = new System.Windows.Forms.Label();
            this.profile_picture = new System.Windows.Forms.PictureBox();
            this.Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).BeginInit();
            this.content.SuspendLayout();
            this.info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.user_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.Banner.Controls.Add(this.profile);
            this.Banner.Controls.Add(this.logo_button);
            this.Banner.Controls.Add(this.menu_button);
            this.Banner.Location = new System.Drawing.Point(0, 0);
            this.Banner.Margin = new System.Windows.Forms.Padding(2);
            this.Banner.Name = "Banner";
            this.Banner.Size = new System.Drawing.Size(669, 60);
            this.Banner.TabIndex = 0;
            // 
            // profile
            // 
            this.profile.Image = global::CVIS.Properties.Resources.profile_placeholder;
            this.profile.Location = new System.Drawing.Point(570, 9);
            this.profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(72, 42);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 2;
            this.profile.TabStop = false;
            // 
            // logo_button
            // 
            this.logo_button.Image = global::CVIS.Properties.Resources.logo_white;
            this.logo_button.Location = new System.Drawing.Point(38, 10);
            this.logo_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_button.Name = "logo_button";
            this.logo_button.Size = new System.Drawing.Size(105, 40);
            this.logo_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_button.TabIndex = 1;
            this.logo_button.TabStop = false;
            // 
            // menu_button
            // 
            this.menu_button.Image = ((System.Drawing.Image)(resources.GetObject("menu_button.Image")));
            this.menu_button.ImageLocation = "";
            this.menu_button.Location = new System.Drawing.Point(12, 10);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(20, 40);
            this.menu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_button.TabIndex = 0;
            this.menu_button.TabStop = false;
            // 
            // content
            // 
            this.content.Controls.Add(this.hosdept_text);
            this.content.Controls.Add(this.position_text);
            this.content.Controls.Add(this.name_text);
            this.content.Controls.Add(this.admin_ID_text);
            this.content.Controls.Add(this.info);
            this.content.Controls.Add(this.user_status);
            this.content.Controls.Add(this.profile_picture);
            this.content.Location = new System.Drawing.Point(12, 65);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(630, 341);
            this.content.TabIndex = 8;
            // 
            // hosdept_text
            // 
            this.hosdept_text.AutoSize = true;
            this.hosdept_text.Location = new System.Drawing.Point(104, 76);
            this.hosdept_text.Name = "hosdept_text";
            this.hosdept_text.Size = new System.Drawing.Size(134, 15);
            this.hosdept_text.TabIndex = 10;
            this.hosdept_text.Text = "Hospital / Department : ";
            // 
            // position_text
            // 
            this.position_text.AutoSize = true;
            this.position_text.Location = new System.Drawing.Point(104, 54);
            this.position_text.Name = "position_text";
            this.position_text.Size = new System.Drawing.Size(59, 15);
            this.position_text.TabIndex = 9;
            this.position_text.Text = "Position : ";
            // 
            // name_text
            // 
            this.name_text.AutoSize = true;
            this.name_text.Location = new System.Drawing.Point(104, 31);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(48, 15);
            this.name_text.TabIndex = 8;
            this.name_text.Text = "Name : ";
            // 
            // admin_ID_text
            // 
            this.admin_ID_text.AutoSize = true;
            this.admin_ID_text.Location = new System.Drawing.Point(104, 12);
            this.admin_ID_text.Name = "admin_ID_text";
            this.admin_ID_text.Size = new System.Drawing.Size(66, 15);
            this.admin_ID_text.TabIndex = 6;
            this.admin_ID_text.Text = "Admin ID : ";
            // 
            // info
            // 
            this.info.Controls.Add(this.label1);
            this.info.Controls.Add(this.emergency_edit_button);
            this.info.Controls.Add(this.emergency_contact_text);
            this.info.Controls.Add(this.pictureBox1);
            this.info.Location = new System.Drawing.Point(372, 94);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(255, 194);
            this.info.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Qualifications / Relevant Documents";
            // 
            // emergency_edit_button
            // 
            this.emergency_edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(213)))), ((int)(((byte)(229)))));
            this.emergency_edit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("emergency_edit_button.BackgroundImage")));
            this.emergency_edit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.emergency_edit_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.FlatAppearance.BorderSize = 0;
            this.emergency_edit_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emergency_edit_button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.emergency_edit_button.Location = new System.Drawing.Point(10, 152);
            this.emergency_edit_button.Name = "emergency_edit_button";
            this.emergency_edit_button.Size = new System.Drawing.Size(235, 29);
            this.emergency_edit_button.TabIndex = 3;
            this.emergency_edit_button.Text = "Edit Documents";
            this.emergency_edit_button.UseVisualStyleBackColor = false;
            // 
            // emergency_contact_text
            // 
            this.emergency_contact_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.emergency_contact_text.Location = new System.Drawing.Point(10, 42);
            this.emergency_contact_text.Name = "emergency_contact_text";
            this.emergency_contact_text.Size = new System.Drawing.Size(235, 46);
            this.emergency_contact_text.TabIndex = 2;
            this.emergency_contact_text.Text = "None";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // user_status
            // 
            this.user_status.Controls.Add(this.info_text);
            this.user_status.Location = new System.Drawing.Point(3, 94);
            this.user_status.Name = "user_status";
            this.user_status.Size = new System.Drawing.Size(363, 229);
            this.user_status.TabIndex = 3;
            // 
            // info_text
            // 
            this.info_text.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_text.Location = new System.Drawing.Point(10, 9);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(348, 210);
            this.info_text.TabIndex = 7;
            this.info_text.Text = "[Info]";
            // 
            // profile_picture
            // 
            this.profile_picture.Image = global::CVIS.Properties.Resources.profile_placeholder;
            this.profile_picture.Location = new System.Drawing.Point(13, 12);
            this.profile_picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_picture.Name = "profile_picture";
            this.profile_picture.Size = new System.Drawing.Size(70, 72);
            this.profile_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_picture.TabIndex = 2;
            this.profile_picture.TabStop = false;
            // 
            // Staff_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(654, 413);
            this.Controls.Add(this.content);
            this.Controls.Add(this.Banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Staff_Profile";
            this.Text = "Staff_Profile";
            this.Banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).EndInit();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.user_status.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Banner;
        private PictureBox menu_button;
        private PictureBox logo_button;
        private PictureBox profile;
        private Panel content;
        private Label name_text;
        private Label admin_ID_text;
        private Panel info;
        private Label label1;
        private Button emergency_edit_button;
        private Label emergency_contact_text;
        private PictureBox pictureBox1;
        private Panel user_status;
        private Label info_text;
        private PictureBox profile_picture;
        private Label position_text;
        private Label hosdept_text;
    }
}