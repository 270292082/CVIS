namespace CVIS.Views
{
    partial class Staff_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Setting));
            menu_button = new PictureBox();
            logo = new PictureBox();
            banner = new Panel();
            profile_button = new PictureBox();
            qrcode_display = new Panel();
            password_input = new TextBox();
            username_input = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            apply_btn = new Button();
            address_input = new TextBox();
            lastname_input = new TextBox();
            firstname_input = new TextBox();
            email_input = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            phone_input = new TextBox();
            label4 = new Label();
            role_input = new TextBox();
            label8 = new Label();
            licenseexp_input = new TextBox();
            medlicense_input = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            display_nav = new Panel();
            padding = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)profile_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)padding).BeginInit();
            SuspendLayout();
            // 
            // menu_button
            // 
            menu_button.Image = (Image)resources.GetObject("menu_button.Image");
            menu_button.Location = new Point(12, 10);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(20, 40);
            menu_button.SizeMode = PictureBoxSizeMode.Zoom;
            menu_button.TabIndex = 2;
            menu_button.TabStop = false;
            menu_button.Click += menu_button_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo_white;
            logo.Location = new Point(38, 10);
            logo.Margin = new Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new Size(105, 40);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // banner
            // 
            banner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            banner.AutoSize = true;
            banner.BackColor = Color.FromArgb(0, 151, 136);
            banner.Controls.Add(menu_button);
            banner.Controls.Add(logo);
            banner.Controls.Add(profile_button);
            banner.Location = new Point(-1, 0);
            banner.Margin = new Padding(3, 2, 3, 2);
            banner.Name = "banner";
            banner.Size = new Size(667, 60);
            banner.TabIndex = 12;
            // 
            // profile_button
            // 
            profile_button.Image = Properties.Resources.profile_placeholder;
            profile_button.Location = new Point(570, 9);
            profile_button.Margin = new Padding(3, 2, 3, 2);
            profile_button.Name = "profile_button";
            profile_button.Size = new Size(72, 42);
            profile_button.SizeMode = PictureBoxSizeMode.Zoom;
            profile_button.TabIndex = 1;
            profile_button.TabStop = false;
            profile_button.Click += profile_button_Click;
            // 
            // qrcode_display
            // 
            qrcode_display.AutoScroll = true;
            qrcode_display.Location = new Point(550, 11);
            qrcode_display.Name = "qrcode_display";
            qrcode_display.Size = new Size(8, 41);
            qrcode_display.TabIndex = 13;
            // 
            // password_input
            // 
            password_input.Location = new Point(333, 173);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(140, 23);
            password_input.TabIndex = 23;
            // 
            // username_input
            // 
            username_input.Location = new Point(333, 143);
            username_input.Name = "username_input";
            username_input.Size = new Size(140, 23);
            username_input.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(181, 177);
            label3.Name = "label3";
            label3.Size = new Size(56, 13);
            label3.TabIndex = 21;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(181, 147);
            label2.Name = "label2";
            label2.Size = new Size(58, 13);
            label2.TabIndex = 20;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(181, 107);
            label1.Name = "label1";
            label1.Size = new Size(81, 17);
            label1.TabIndex = 19;
            label1.Text = "Your Profile";
            // 
            // apply_btn
            // 
            apply_btn.BackColor = Color.Transparent;
            apply_btn.BackgroundImage = (Image)resources.GetObject("apply_btn.BackgroundImage");
            apply_btn.BackgroundImageLayout = ImageLayout.Stretch;
            apply_btn.FlatAppearance.BorderSize = 0;
            apply_btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            apply_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            apply_btn.FlatStyle = FlatStyle.Flat;
            apply_btn.ForeColor = Color.White;
            apply_btn.Location = new Point(483, 614);
            apply_btn.Name = "apply_btn";
            apply_btn.Size = new Size(75, 23);
            apply_btn.TabIndex = 24;
            apply_btn.Text = "Apply";
            apply_btn.UseVisualStyleBackColor = false;
            apply_btn.Click += apply_btn_Click;
            // 
            // address_input
            // 
            address_input.Location = new Point(333, 403);
            address_input.Name = "address_input";
            address_input.Size = new Size(140, 23);
            address_input.TabIndex = 53;
            // 
            // lastname_input
            // 
            lastname_input.Location = new Point(333, 312);
            lastname_input.Name = "lastname_input";
            lastname_input.Size = new Size(140, 23);
            lastname_input.TabIndex = 52;
            // 
            // firstname_input
            // 
            firstname_input.Location = new Point(333, 283);
            firstname_input.Name = "firstname_input";
            firstname_input.Size = new Size(140, 23);
            firstname_input.TabIndex = 51;
            // 
            // email_input
            // 
            email_input.Location = new Point(333, 371);
            email_input.Name = "email_input";
            email_input.Size = new Size(140, 23);
            email_input.TabIndex = 50;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(181, 406);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 48;
            label10.Text = "Address";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(181, 376);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 47;
            label9.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 316);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 45;
            label7.Text = "Last Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 286);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 44;
            label6.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(181, 246);
            label5.Name = "label5";
            label5.Size = new Size(139, 17);
            label5.TabIndex = 43;
            label5.Text = "Personal Information";
            // 
            // phone_input
            // 
            phone_input.Location = new Point(333, 432);
            phone_input.Name = "phone_input";
            phone_input.Size = new Size(140, 23);
            phone_input.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(182, 436);
            label4.Name = "label4";
            label4.Size = new Size(84, 13);
            label4.TabIndex = 41;
            label4.Text = "Phone Number";
            // 
            // role_input
            // 
            role_input.Location = new Point(333, 342);
            role_input.Name = "role_input";
            role_input.Size = new Size(140, 23);
            role_input.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(181, 346);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 46;
            label8.Text = "Role Permission";
            // 
            // licenseexp_input
            // 
            licenseexp_input.Location = new Point(333, 554);
            licenseexp_input.Name = "licenseexp_input";
            licenseexp_input.Size = new Size(140, 23);
            licenseexp_input.TabIndex = 62;
            // 
            // medlicense_input
            // 
            medlicense_input.Location = new Point(333, 525);
            medlicense_input.Name = "medlicense_input";
            medlicense_input.Size = new Size(140, 23);
            medlicense_input.TabIndex = 61;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(181, 558);
            label13.Name = "label13";
            label13.Size = new Size(107, 15);
            label13.TabIndex = 56;
            label13.Text = "License Expiry Date";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(181, 528);
            label12.Name = "label12";
            label12.Size = new Size(91, 15);
            label12.TabIndex = 55;
            label12.Text = "Medical License";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(181, 489);
            label11.Name = "label11";
            label11.Size = new Size(53, 17);
            label11.TabIndex = 54;
            label11.Text = "License";
            // 
            // display_nav
            // 
            display_nav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            display_nav.Location = new Point(0, 0);
            display_nav.Name = "display_nav";
            display_nav.Size = new Size(5, 700);
            display_nav.TabIndex = 63;
            // 
            // padding
            // 
            padding.Location = new Point(138, 643);
            padding.Name = "padding";
            padding.Size = new Size(420, 23);
            padding.TabIndex = 64;
            padding.TabStop = false;
            // 
            // Staff_Setting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightCyan;
            ClientSize = new Size(654, 700);
            Controls.Add(padding);
            Controls.Add(display_nav);
            Controls.Add(licenseexp_input);
            Controls.Add(medlicense_input);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(address_input);
            Controls.Add(lastname_input);
            Controls.Add(firstname_input);
            Controls.Add(email_input);
            Controls.Add(role_input);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(phone_input);
            Controls.Add(label4);
            Controls.Add(apply_btn);
            Controls.Add(password_input);
            Controls.Add(username_input);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(banner);
            Controls.Add(qrcode_display);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff_Setting";
            Text = "Staff_Setting";
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)profile_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)padding).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox menu_button;
        private PictureBox logo;
        private Panel banner;
        private PictureBox profile_button;
        private Panel qrcode_display;
        private TextBox password_input;
        private TextBox username_input;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button apply_btn;
        private TextBox address_input;
        private TextBox lastname_input;
        private TextBox firstname_input;
        private TextBox email_input;
        private Label label10;
        private Label label9;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox phone_input;
        private Label label4;
        private TextBox role_input;
        private Label label8;
        private TextBox licenseexp_input;
        private TextBox medlicense_input;
        private Label label13;
        private Label label12;
        private Label label11;
        private Panel display_nav;
        private PictureBox padding;
    }
}