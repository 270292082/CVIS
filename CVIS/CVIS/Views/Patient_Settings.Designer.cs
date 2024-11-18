namespace CVIS
{
    partial class Patient_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Settings));
            banner = new Panel();
            menu_button = new PictureBox();
            logo = new PictureBox();
            profile_button = new PictureBox();
            display_nav = new Panel();
            qrcode_display = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            username_input = new TextBox();
            password_input = new TextBox();
            phone_input = new TextBox();
            apply_button = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ephone_input = new TextBox();
            label14 = new Label();
            label15 = new Label();
            erelation_input = new TextBox();
            elastname_input = new TextBox();
            efirstname_input = new TextBox();
            lastname_input = new TextBox();
            firstname_input = new TextBox();
            email_input = new TextBox();
            dob_input = new TextBox();
            address_input = new TextBox();
            padding = new PictureBox();
            banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)padding).BeginInit();
            SuspendLayout();
            // 
            // banner
            // 
            banner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            banner.AutoSize = true;
            banner.BackColor = Color.FromArgb(0, 151, 136);
            banner.Controls.Add(menu_button);
            banner.Controls.Add(logo);
            banner.Controls.Add(profile_button);
            banner.Location = new Point(0, 0);
            banner.Margin = new Padding(4, 3, 4, 3);
            banner.Name = "banner";
            banner.Size = new Size(921, 100);
            banner.TabIndex = 6;
            // 
            // menu_button
            // 
            menu_button.Image = (Image)resources.GetObject("menu_button.Image");
            menu_button.Location = new Point(17, 17);
            menu_button.Margin = new Padding(4, 5, 4, 5);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(29, 67);
            menu_button.SizeMode = PictureBoxSizeMode.Zoom;
            menu_button.TabIndex = 2;
            menu_button.TabStop = false;
            menu_button.Click += menu_button_Click;
            // 
            // logo
            // 
            logo.Image = Properties.Resources.logo_white;
            logo.Location = new Point(54, 17);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(150, 67);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // profile_button
            // 
            profile_button.Image = Properties.Resources.profile_placeholder;
            profile_button.Location = new Point(814, 15);
            profile_button.Margin = new Padding(4, 3, 4, 3);
            profile_button.Name = "profile_button";
            profile_button.Size = new Size(103, 70);
            profile_button.SizeMode = PictureBoxSizeMode.Zoom;
            profile_button.TabIndex = 1;
            profile_button.TabStop = false;
            // 
            // display_nav
            // 
            display_nav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            display_nav.Location = new Point(0, 0);
            display_nav.Margin = new Padding(4, 5, 4, 5);
            display_nav.Name = "display_nav";
            display_nav.Size = new Size(7, 1468);
            display_nav.TabIndex = 10;
            // 
            // qrcode_display
            // 
            qrcode_display.AutoScroll = true;
            qrcode_display.Location = new Point(791, 17);
            qrcode_display.Margin = new Padding(4, 5, 4, 5);
            qrcode_display.Name = "qrcode_display";
            qrcode_display.Size = new Size(16, 68);
            qrcode_display.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(206, 150);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 28);
            label1.TabIndex = 13;
            label1.Text = "Your Profile";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(206, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(206, 267);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(207, 750);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 16;
            label4.Text = "Phone Number";
            // 
            // username_input
            // 
            username_input.Location = new Point(423, 210);
            username_input.Margin = new Padding(4, 5, 4, 5);
            username_input.Name = "username_input";
            username_input.Size = new Size(198, 31);
            username_input.TabIndex = 17;
            // 
            // password_input
            // 
            password_input.Location = new Point(423, 260);
            password_input.Margin = new Padding(4, 5, 4, 5);
            password_input.Name = "password_input";
            password_input.PasswordChar = '*';
            password_input.Size = new Size(198, 31);
            password_input.TabIndex = 18;
            // 
            // phone_input
            // 
            phone_input.Location = new Point(423, 743);
            phone_input.Margin = new Padding(4, 5, 4, 5);
            phone_input.Name = "phone_input";
            phone_input.Size = new Size(198, 31);
            phone_input.TabIndex = 19;
            // 
            // apply_button
            // 
            apply_button.BackColor = Color.Transparent;
            apply_button.BackgroundImage = (Image)resources.GetObject("apply_button.BackgroundImage");
            apply_button.BackgroundImageLayout = ImageLayout.Stretch;
            apply_button.FlatAppearance.BorderSize = 0;
            apply_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            apply_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            apply_button.FlatStyle = FlatStyle.Flat;
            apply_button.ForeColor = Color.White;
            apply_button.Location = new Point(700, 1138);
            apply_button.Margin = new Padding(4, 5, 4, 5);
            apply_button.Name = "apply_button";
            apply_button.Size = new Size(107, 38);
            apply_button.TabIndex = 20;
            apply_button.Text = "Apply";
            apply_button.UseVisualStyleBackColor = false;
            apply_button.Click += apply_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(206, 433);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(211, 28);
            label5.TabIndex = 21;
            label5.Text = "Personal Information";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(206, 500);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 25);
            label6.TabIndex = 22;
            label6.Text = "First Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(206, 550);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(95, 25);
            label7.TabIndex = 23;
            label7.Text = "Last Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(206, 600);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(112, 25);
            label8.TabIndex = 24;
            label8.Text = "Date of Birth";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 650);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 25);
            label9.TabIndex = 25;
            label9.Text = "Email";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(206, 700);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(77, 25);
            label10.TabIndex = 26;
            label10.Text = "Address";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(206, 868);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(195, 28);
            label11.TabIndex = 27;
            label11.Text = "Emergency Contact";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(206, 933);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(97, 25);
            label12.TabIndex = 28;
            label12.Text = "First Name";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(206, 983);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(95, 25);
            label13.TabIndex = 29;
            label13.Text = "Last Name";
            // 
            // ephone_input
            // 
            ephone_input.Location = new Point(423, 1027);
            ephone_input.Margin = new Padding(4, 5, 4, 5);
            ephone_input.Name = "ephone_input";
            ephone_input.Size = new Size(198, 31);
            ephone_input.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(206, 1033);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(127, 23);
            label14.TabIndex = 30;
            label14.Text = "Phone Number";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(207, 1083);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(72, 23);
            label15.TabIndex = 32;
            label15.Text = "Relation";
            // 
            // erelation_input
            // 
            erelation_input.Location = new Point(423, 1075);
            erelation_input.Margin = new Padding(4, 5, 4, 5);
            erelation_input.Name = "erelation_input";
            erelation_input.Size = new Size(198, 31);
            erelation_input.TabIndex = 33;
            // 
            // elastname_input
            // 
            elastname_input.Location = new Point(423, 977);
            elastname_input.Margin = new Padding(4, 5, 4, 5);
            elastname_input.Name = "elastname_input";
            elastname_input.Size = new Size(198, 31);
            elastname_input.TabIndex = 35;
            // 
            // efirstname_input
            // 
            efirstname_input.Location = new Point(423, 928);
            efirstname_input.Margin = new Padding(4, 5, 4, 5);
            efirstname_input.Name = "efirstname_input";
            efirstname_input.Size = new Size(198, 31);
            efirstname_input.TabIndex = 34;
            // 
            // lastname_input
            // 
            lastname_input.Location = new Point(423, 543);
            lastname_input.Margin = new Padding(4, 5, 4, 5);
            lastname_input.Name = "lastname_input";
            lastname_input.Size = new Size(198, 31);
            lastname_input.TabIndex = 39;
            // 
            // firstname_input
            // 
            firstname_input.Location = new Point(423, 495);
            firstname_input.Margin = new Padding(4, 5, 4, 5);
            firstname_input.Name = "firstname_input";
            firstname_input.Size = new Size(198, 31);
            firstname_input.TabIndex = 38;
            // 
            // email_input
            // 
            email_input.Location = new Point(423, 642);
            email_input.Margin = new Padding(4, 5, 4, 5);
            email_input.Name = "email_input";
            email_input.Size = new Size(198, 31);
            email_input.TabIndex = 37;
            // 
            // dob_input
            // 
            dob_input.Location = new Point(423, 593);
            dob_input.Margin = new Padding(4, 5, 4, 5);
            dob_input.Name = "dob_input";
            dob_input.Size = new Size(198, 31);
            dob_input.TabIndex = 36;
            // 
            // address_input
            // 
            address_input.Location = new Point(423, 695);
            address_input.Margin = new Padding(4, 5, 4, 5);
            address_input.Name = "address_input";
            address_input.Size = new Size(198, 31);
            address_input.TabIndex = 40;
            // 
            // padding
            // 
            padding.Location = new Point(207, 1182);
            padding.Margin = new Padding(4, 5, 4, 5);
            padding.Name = "padding";
            padding.Size = new Size(600, 38);
            padding.TabIndex = 41;
            padding.TabStop = false;
            // 
            // Patient_Settings
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightCyan;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(934, 1106);
            Controls.Add(padding);
            Controls.Add(qrcode_display);
            Controls.Add(display_nav);
            Controls.Add(address_input);
            Controls.Add(lastname_input);
            Controls.Add(firstname_input);
            Controls.Add(email_input);
            Controls.Add(dob_input);
            Controls.Add(elastname_input);
            Controls.Add(efirstname_input);
            Controls.Add(erelation_input);
            Controls.Add(label15);
            Controls.Add(ephone_input);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(apply_button);
            Controls.Add(phone_input);
            Controls.Add(password_input);
            Controls.Add(username_input);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(banner);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Patient_Settings";
            Text = "Patient_Settings";
            Load += Patient_Settings_Load;
            banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)padding).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel banner;
        private PictureBox menu_button;
        private PictureBox logo;
        private PictureBox profile_button;
        private Panel display_nav;
        private Panel qrcode_display;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox username_input;
        private TextBox password_input;
        private TextBox phone_input;
        private Button apply_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox ephone_input;
        private Label label14;
        private Label label15;
        private TextBox erelation_input;
        private TextBox elastname_input;
        private TextBox efirstname_input;
        private TextBox lastname_input;
        private TextBox firstname_input;
        private TextBox email_input;
        private TextBox dob_input;
        private TextBox address_input;
        private PictureBox padding;
    }
}