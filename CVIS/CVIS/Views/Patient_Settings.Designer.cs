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
            this.banner = new System.Windows.Forms.Panel();
            this.menu_button = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.profile_button = new System.Windows.Forms.PictureBox();
            this.display_nav = new System.Windows.Forms.Panel();
            this.qrcode_display = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.username_input = new System.Windows.Forms.TextBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.phone_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ephone_input = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.erelation_input = new System.Windows.Forms.TextBox();
            this.elastname_input = new System.Windows.Forms.TextBox();
            this.efirstname_input = new System.Windows.Forms.TextBox();
            this.lastname_input = new System.Windows.Forms.TextBox();
            this.firstname_input = new System.Windows.Forms.TextBox();
            this.email_input = new System.Windows.Forms.TextBox();
            this.dob_input = new System.Windows.Forms.TextBox();
            this.address_input = new System.Windows.Forms.TextBox();
            this.padding = new System.Windows.Forms.PictureBox();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padding)).BeginInit();
            this.SuspendLayout();
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
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(654, 60);
            this.banner.TabIndex = 6;
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
            // 
            // display_nav
            // 
            this.display_nav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.display_nav.Location = new System.Drawing.Point(0, 0);
            this.display_nav.Name = "display_nav";
            this.display_nav.Size = new System.Drawing.Size(5, 744);
            this.display_nav.TabIndex = 10;
            // 
            // qrcode_display
            // 
            this.qrcode_display.AutoScroll = true;
            this.qrcode_display.Location = new System.Drawing.Point(554, 10);
            this.qrcode_display.Name = "qrcode_display";
            this.qrcode_display.Size = new System.Drawing.Size(11, 41);
            this.qrcode_display.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(144, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your Profile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(144, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(145, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Phone Number";
            // 
            // username_input
            // 
            this.username_input.Location = new System.Drawing.Point(296, 126);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(140, 23);
            this.username_input.TabIndex = 17;
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(296, 156);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(140, 23);
            this.password_input.TabIndex = 18;
            // 
            // phone_input
            // 
            this.phone_input.Location = new System.Drawing.Point(296, 446);
            this.phone_input.Name = "phone_input";
            this.phone_input.Size = new System.Drawing.Size(140, 23);
            this.phone_input.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(490, 683);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(144, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Personal Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(144, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Date of Birth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(144, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(144, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 26;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(144, 521);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 27;
            this.label11.Text = "Emergency Contact";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 560);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "First Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 590);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Last Name";
            // 
            // ephone_input
            // 
            this.ephone_input.Location = new System.Drawing.Point(296, 616);
            this.ephone_input.Name = "ephone_input";
            this.ephone_input.Size = new System.Drawing.Size(140, 23);
            this.ephone_input.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(144, 620);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(145, 650);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Relation";
            // 
            // erelation_input
            // 
            this.erelation_input.Location = new System.Drawing.Point(296, 645);
            this.erelation_input.Name = "erelation_input";
            this.erelation_input.Size = new System.Drawing.Size(140, 23);
            this.erelation_input.TabIndex = 33;
            // 
            // elastname_input
            // 
            this.elastname_input.Location = new System.Drawing.Point(296, 586);
            this.elastname_input.Name = "elastname_input";
            this.elastname_input.Size = new System.Drawing.Size(140, 23);
            this.elastname_input.TabIndex = 35;
            // 
            // efirstname_input
            // 
            this.efirstname_input.Location = new System.Drawing.Point(296, 557);
            this.efirstname_input.Name = "efirstname_input";
            this.efirstname_input.Size = new System.Drawing.Size(140, 23);
            this.efirstname_input.TabIndex = 34;
            // 
            // lastname_input
            // 
            this.lastname_input.Location = new System.Drawing.Point(296, 326);
            this.lastname_input.Name = "lastname_input";
            this.lastname_input.Size = new System.Drawing.Size(140, 23);
            this.lastname_input.TabIndex = 39;
            // 
            // firstname_input
            // 
            this.firstname_input.Location = new System.Drawing.Point(296, 297);
            this.firstname_input.Name = "firstname_input";
            this.firstname_input.Size = new System.Drawing.Size(140, 23);
            this.firstname_input.TabIndex = 38;
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(296, 385);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(140, 23);
            this.email_input.TabIndex = 37;
            // 
            // dob_input
            // 
            this.dob_input.Location = new System.Drawing.Point(296, 356);
            this.dob_input.Name = "dob_input";
            this.dob_input.Size = new System.Drawing.Size(140, 23);
            this.dob_input.TabIndex = 36;
            // 
            // address_input
            // 
            this.address_input.Location = new System.Drawing.Point(296, 417);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(140, 23);
            this.address_input.TabIndex = 40;
            // 
            // padding
            // 
            this.padding.Location = new System.Drawing.Point(145, 709);
            this.padding.Name = "padding";
            this.padding.Size = new System.Drawing.Size(420, 23);
            this.padding.TabIndex = 41;
            this.padding.TabStop = false;
            // 
            // Patient_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(654, 744);
            this.Controls.Add(this.padding);
            this.Controls.Add(this.qrcode_display);
            this.Controls.Add(this.display_nav);
            this.Controls.Add(this.address_input);
            this.Controls.Add(this.lastname_input);
            this.Controls.Add(this.firstname_input);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.dob_input);
            this.Controls.Add(this.elastname_input);
            this.Controls.Add(this.efirstname_input);
            this.Controls.Add(this.erelation_input);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ephone_input);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phone_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Settings";
            this.Text = "Patient_Settings";
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button button1;
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