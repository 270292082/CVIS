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
            Banner = new Panel();
            profile = new PictureBox();
            logo_button = new PictureBox();
            menu_button = new PictureBox();
            content = new Panel();
            hosdept_text = new Label();
            position_text = new Label();
            name_text = new Label();
            admin_ID_text = new Label();
            info = new Panel();
            label1 = new Label();
            emergency_edit_button = new Button();
            emergency_contact_text = new Label();
            pictureBox1 = new PictureBox();
            user_status = new Panel();
            info_text = new Label();
            profile_picture = new PictureBox();
            Banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            content.SuspendLayout();
            info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            user_status.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_picture).BeginInit();
            SuspendLayout();
            // 
            // Banner
            // 
            Banner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Banner.BackColor = Color.FromArgb(0, 151, 136);
            Banner.Controls.Add(profile);
            Banner.Controls.Add(logo_button);
            Banner.Controls.Add(menu_button);
            Banner.Location = new Point(0, 0);
            Banner.Name = "Banner";
            Banner.Size = new Size(956, 100);
            Banner.TabIndex = 0;
            // 
            // profile
            // 
            profile.Image = Properties.Resources.profile_placeholder;
            profile.Location = new Point(814, 15);
            profile.Margin = new Padding(4, 3, 4, 3);
            profile.Name = "profile";
            profile.Size = new Size(103, 70);
            profile.SizeMode = PictureBoxSizeMode.Zoom;
            profile.TabIndex = 2;
            profile.TabStop = false;
            // 
            // logo_button
            // 
            logo_button.Image = Properties.Resources.logo_white;
            logo_button.Location = new Point(54, 17);
            logo_button.Margin = new Padding(4, 3, 4, 3);
            logo_button.Name = "logo_button";
            logo_button.Size = new Size(150, 67);
            logo_button.SizeMode = PictureBoxSizeMode.Zoom;
            logo_button.TabIndex = 1;
            logo_button.TabStop = false;
            logo_button.Click += logo_button_Click;
            // 
            // menu_button
            // 
            menu_button.Image = (Image)resources.GetObject("menu_button.Image");
            menu_button.ImageLocation = "";
            menu_button.Location = new Point(17, 17);
            menu_button.Margin = new Padding(4, 5, 4, 5);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(29, 67);
            menu_button.SizeMode = PictureBoxSizeMode.Zoom;
            menu_button.TabIndex = 0;
            menu_button.TabStop = false;
            menu_button.Click += menu_button_Click;
            // 
            // content
            // 
            content.Controls.Add(hosdept_text);
            content.Controls.Add(position_text);
            content.Controls.Add(name_text);
            content.Controls.Add(admin_ID_text);
            content.Controls.Add(info);
            content.Controls.Add(user_status);
            content.Controls.Add(profile_picture);
            content.Location = new Point(17, 108);
            content.Margin = new Padding(4, 5, 4, 5);
            content.Name = "content";
            content.Size = new Size(900, 568);
            content.TabIndex = 8;
            // 
            // hosdept_text
            // 
            hosdept_text.AutoSize = true;
            hosdept_text.Location = new Point(149, 127);
            hosdept_text.Margin = new Padding(4, 0, 4, 0);
            hosdept_text.Name = "hosdept_text";
            hosdept_text.Size = new Size(204, 25);
            hosdept_text.TabIndex = 10;
            hosdept_text.Text = "Hospital / Department : ";
            // 
            // position_text
            // 
            position_text.AutoSize = true;
            position_text.Location = new Point(149, 90);
            position_text.Margin = new Padding(4, 0, 4, 0);
            position_text.Name = "position_text";
            position_text.Size = new Size(89, 25);
            position_text.TabIndex = 9;
            position_text.Text = "Position : ";
            // 
            // name_text
            // 
            name_text.AutoSize = true;
            name_text.Location = new Point(149, 52);
            name_text.Margin = new Padding(4, 0, 4, 0);
            name_text.Name = "name_text";
            name_text.Size = new Size(73, 25);
            name_text.TabIndex = 8;
            name_text.Text = "Name : ";
            // 
            // admin_ID_text
            // 
            admin_ID_text.AutoSize = true;
            admin_ID_text.Location = new Point(149, 20);
            admin_ID_text.Margin = new Padding(4, 0, 4, 0);
            admin_ID_text.Name = "admin_ID_text";
            admin_ID_text.Size = new Size(102, 25);
            admin_ID_text.TabIndex = 6;
            admin_ID_text.Text = "Admin ID : ";
            // 
            // info
            // 
            info.Controls.Add(label1);
            info.Controls.Add(emergency_edit_button);
            info.Controls.Add(emergency_contact_text);
            info.Controls.Add(pictureBox1);
            info.Location = new Point(531, 157);
            info.Margin = new Padding(4, 5, 4, 5);
            info.Name = "info";
            info.Size = new Size(364, 323);
            info.TabIndex = 4;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(178, 223, 219);
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(336, 33);
            label1.TabIndex = 4;
            label1.Text = "Qualifications / Relevant Documents";
            // 
            // emergency_edit_button
            // 
            emergency_edit_button.BackColor = Color.FromArgb(178, 213, 229);
            emergency_edit_button.BackgroundImage = (Image)resources.GetObject("emergency_edit_button.BackgroundImage");
            emergency_edit_button.BackgroundImageLayout = ImageLayout.Stretch;
            emergency_edit_button.FlatAppearance.BorderColor = Color.FromArgb(178, 223, 219);
            emergency_edit_button.FlatAppearance.BorderSize = 0;
            emergency_edit_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(178, 223, 219);
            emergency_edit_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(178, 223, 219);
            emergency_edit_button.FlatStyle = FlatStyle.Flat;
            emergency_edit_button.ForeColor = Color.WhiteSmoke;
            emergency_edit_button.Location = new Point(14, 254);
            emergency_edit_button.Margin = new Padding(4, 5, 4, 5);
            emergency_edit_button.Name = "emergency_edit_button";
            emergency_edit_button.Size = new Size(336, 48);
            emergency_edit_button.TabIndex = 3;
            emergency_edit_button.Text = "Edit Documents";
            emergency_edit_button.UseVisualStyleBackColor = false;
            // 
            // emergency_contact_text
            // 
            emergency_contact_text.BackColor = Color.FromArgb(178, 223, 219);
            emergency_contact_text.Location = new Point(14, 70);
            emergency_contact_text.Margin = new Padding(4, 0, 4, 0);
            emergency_contact_text.Name = "emergency_contact_text";
            emergency_contact_text.Size = new Size(336, 77);
            emergency_contact_text.TabIndex = 2;
            emergency_contact_text.Text = "None";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, 15);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 303);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // user_status
            // 
            user_status.Controls.Add(info_text);
            user_status.Location = new Point(4, 157);
            user_status.Margin = new Padding(4, 5, 4, 5);
            user_status.Name = "user_status";
            user_status.Size = new Size(519, 381);
            user_status.TabIndex = 3;
            // 
            // info_text
            // 
            info_text.Location = new Point(14, 15);
            info_text.Margin = new Padding(4, 0, 4, 0);
            info_text.Name = "info_text";
            info_text.Size = new Size(497, 350);
            info_text.TabIndex = 7;
            info_text.Text = "[Info]";
            // 
            // profile_picture
            // 
            profile_picture.Image = Properties.Resources.profile_placeholder;
            profile_picture.Location = new Point(19, 20);
            profile_picture.Margin = new Padding(4, 3, 4, 3);
            profile_picture.Name = "profile_picture";
            profile_picture.Size = new Size(100, 120);
            profile_picture.SizeMode = PictureBoxSizeMode.Zoom;
            profile_picture.TabIndex = 2;
            profile_picture.TabStop = false;
            // 
            // Staff_Profile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(934, 650);
            Controls.Add(content);
            Controls.Add(Banner);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff_Profile";
            Text = "Staff_Profile";
            Banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            content.ResumeLayout(false);
            content.PerformLayout();
            info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            user_status.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profile_picture).EndInit();
            ResumeLayout(false);
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