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
            this.menu_button = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.banner = new System.Windows.Forms.Panel();
            this.profile_button = new System.Windows.Forms.PictureBox();
            this.qrcode_display = new System.Windows.Forms.Panel();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.apply_btn = new System.Windows.Forms.Button();
            this.address_input = new System.Windows.Forms.TextBox();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.firstname_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.role_input = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.licenseexp_input = new System.Windows.Forms.TextBox();
            this.medlicense_input = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.display_nav = new System.Windows.Forms.Panel();
            this.padding = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padding)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_button
            // 
            this.menu_button.Image = ((System.Drawing.Image)(resources.GetObject("menu_button.Image")));
            this.menu_button.Location = new System.Drawing.Point(12, 10);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(20, 40);
            this.menu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_button.TabIndex = 2;
            this.menu_button.TabStop = false;
            this.menu_button.Click += new System.EventHandler(this.menu_button_Click);
            // 
            // logo
            // 
            this.logo.Image = global::CVIS.Properties.Resources.logo_white;
            this.logo.Location = new System.Drawing.Point(38, 10);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 40);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.AutoSize = true;
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.banner.Controls.Add(this.menu_button);
            this.banner.Controls.Add(this.logo);
            this.banner.Controls.Add(this.profile_button);
            this.banner.Location = new System.Drawing.Point(-1, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(667, 60);
            this.banner.TabIndex = 12;
            // 
            // profile_button
            // 
            this.profile_button.Image = global::CVIS.Properties.Resources.profile_placeholder;
            this.profile_button.Location = new System.Drawing.Point(570, 9);
            this.profile_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile_button.Name = "profile_button";
            this.profile_button.Size = new System.Drawing.Size(72, 42);
            this.profile_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_button.TabIndex = 1;
            this.profile_button.TabStop = false;
            this.profile_button.Click += new System.EventHandler(this.profile_button_Click);
            // 
            // qrcode_display
            // 
            this.qrcode_display.AutoScroll = true;
            this.qrcode_display.Location = new System.Drawing.Point(550, 11);
            this.qrcode_display.Name = "qrcode_display";
            this.qrcode_display.Size = new System.Drawing.Size(8, 41);
            this.qrcode_display.TabIndex = 13;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(333, 173);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(140, 23);
            this.password_input.TabIndex = 23;
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(333, 143);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(140, 23);
            this.username_input.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(181, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(181, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(181, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Your Profile";
            // 
            // apply_btn
            // 
            this.apply_btn.BackColor = System.Drawing.Color.Transparent;
            this.apply_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("apply_btn.BackgroundImage")));
            this.apply_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.apply_btn.FlatAppearance.BorderSize = 0;
            this.apply_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.apply_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply_btn.ForeColor = System.Drawing.Color.White;
            this.apply_btn.Location = new System.Drawing.Point(483, 614);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 24;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = false;
            // 
            // address_input
            // 
            this.address_input.Location = new System.Drawing.Point(333, 403);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(140, 23);
            this.address_input.TabIndex = 53;
            // 
            // lastname_input
            // 
            this.lastname_input.Location = new System.Drawing.Point(333, 312);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(140, 23);
            this.lastname_input.TabIndex = 52;
            // 
            // firstname_input
            // 
            this.firstname_input.Location = new System.Drawing.Point(333, 283);
            this.firstname_input.Name = "firstname_input";
            this.firstname_input.Size = new System.Drawing.Size(140, 23);
            this.firstname_input.TabIndex = 51;
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(333, 371);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(140, 23);
            this.email_input.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 406);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 47;
            this.label9.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(181, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 45;
            this.label7.Text = "Last Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(181, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Personal Information";
            // 
            // phone_input
            // 
            this.phone_input.Location = new System.Drawing.Point(333, 432);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(140, 23);
            this.phone_input.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(182, 436);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Phone Number";
            // 
            // role_input
            // 
            this.role_input.Location = new System.Drawing.Point(333, 342);
            this.role_input.Name = "role_input";
            this.role_input.Size = new System.Drawing.Size(140, 23);
            this.role_input.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(181, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Role Permission";
            // 
            // licenseexp_input
            // 
            this.licenseexp_input.Location = new System.Drawing.Point(333, 554);
            this.licenseexp_input.Name = "licenseexp_input";
            this.licenseexp_input.Size = new System.Drawing.Size(140, 23);
            this.licenseexp_input.TabIndex = 62;
            // 
            // medlicense_input
            // 
            this.medlicense_input.Location = new System.Drawing.Point(333, 525);
            this.medlicense_input.Name = "medlicense_input";
            this.medlicense_input.Size = new System.Drawing.Size(140, 23);
            this.medlicense_input.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(181, 558);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 15);
            this.label13.TabIndex = 56;
            this.label13.Text = "License Expiry Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(181, 528);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 15);
            this.label12.TabIndex = 55;
            this.label12.Text = "Medical License";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(181, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "License";
            // 
            // display_nav
            // 
            this.display_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.display_nav.Location = new System.Drawing.Point(0, 0);
            this.display_nav.Name = "display_nav";
            this.display_nav.Size = new System.Drawing.Size(5, 700);
            this.display_nav.TabIndex = 63;
            // 
            // padding
            // 
            this.padding.Location = new System.Drawing.Point(138, 643);
            this.padding.Name = "padding";
            this.padding.Size = new System.Drawing.Size(420, 23);
            this.padding.TabIndex = 64;
            this.padding.TabStop = false;
            // 
            // Staff_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(654, 700);
            this.Controls.Add(this.padding);
            this.Controls.Add(this.display_nav);
            this.Controls.Add(this.licenseexp_input);
            this.Controls.Add(this.medlicense_input);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.address_input);
            this.Controls.Add(this.lastname_input);
            this.Controls.Add(this.firstname_input);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.role_input);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.qrcode_display);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Setting";
            this.Text = "Staff_Setting";
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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