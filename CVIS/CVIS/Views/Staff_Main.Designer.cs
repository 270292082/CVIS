namespace CVIS
{
    partial class Staff_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff_Main));
            banner = new Panel();
            menu_button = new PictureBox();
            logo_button = new PictureBox();
            profile = new PictureBox();
            tabMenu = new TabControl();
            tabHome = new TabPage();
            dataGridHome = new DataGridView();
            textBox1 = new TextBox();
            welcome_text = new Label();
            pictureBox2 = new PictureBox();
            scan_qr_button = new Button();
            tabVaccinationManagement = new TabPage();
            dataGridVaccines1 = new DataGridView();
            tabVaccinationReports = new TabPage();
            dataGridVaccines2 = new DataGridView();
            yearly_report_info = new Label();
            montly_report_info = new Label();
            daily_report_info = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox8 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            tabBtn3 = new Button();
            tabBtn2 = new Button();
            tabBtn1 = new Button();
            patient_ID = new DataGridViewTextBoxColumn();
            patient_username = new DataGridViewTextBoxColumn();
            patient_password = new DataGridViewTextBoxColumn();
            patient_firstName = new DataGridViewTextBoxColumn();
            patient_lastName = new DataGridViewTextBoxColumn();
            patient_dob = new DataGridViewTextBoxColumn();
            patient_gender = new DataGridViewTextBoxColumn();
            patient_phone = new DataGridViewTextBoxColumn();
            patient_email = new DataGridViewTextBoxColumn();
            patient_address = new DataGridViewTextBoxColumn();
            patient_emergencyFirstName = new DataGridViewTextBoxColumn();
            patient_emergencyLastName = new DataGridViewTextBoxColumn();
            patient_emergencyPhone = new DataGridViewTextBoxColumn();
            patient_emergencyRelation = new DataGridViewTextBoxColumn();
            banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile).BeginInit();
            tabMenu.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabVaccinationManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVaccines1).BeginInit();
            tabVaccinationReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVaccines2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // banner
            // 
            banner.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            banner.AutoSize = true;
            banner.BackColor = Color.FromArgb(0, 151, 136);
            banner.Controls.Add(menu_button);
            banner.Controls.Add(logo_button);
            banner.Controls.Add(profile);
            banner.Location = new Point(0, 0);
            banner.Margin = new Padding(3, 2, 3, 2);
            banner.Name = "banner";
            banner.Size = new Size(654, 60);
            banner.TabIndex = 10;
            // 
            // menu_button
            // 
            menu_button.Image = (Image)resources.GetObject("menu_button.Image");
            menu_button.Location = new Point(12, 10);
            menu_button.Name = "menu_button";
            menu_button.Size = new Size(20, 40);
            menu_button.SizeMode = PictureBoxSizeMode.Zoom;
            menu_button.TabIndex = 8;
            menu_button.TabStop = false;
            menu_button.Click += menu_button_Click;
            // 
            // logo_button
            // 
            logo_button.Image = Properties.Resources.logo_white;
            logo_button.Location = new Point(38, 10);
            logo_button.Margin = new Padding(3, 2, 3, 2);
            logo_button.Name = "logo_button";
            logo_button.Size = new Size(105, 40);
            logo_button.SizeMode = PictureBoxSizeMode.Zoom;
            logo_button.TabIndex = 0;
            logo_button.TabStop = false;
            // 
            // profile
            // 
            profile.Image = Properties.Resources.profile_placeholder;
            profile.Location = new Point(570, 9);
            profile.Margin = new Padding(3, 2, 3, 2);
            profile.Name = "profile";
            profile.Size = new Size(72, 42);
            profile.SizeMode = PictureBoxSizeMode.Zoom;
            profile.TabIndex = 1;
            profile.TabStop = false;
            // 
            // tabMenu
            // 
            tabMenu.Appearance = TabAppearance.FlatButtons;
            tabMenu.Controls.Add(tabHome);
            tabMenu.Controls.Add(tabVaccinationManagement);
            tabMenu.Controls.Add(tabVaccinationReports);
            tabMenu.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabMenu.ItemSize = new Size(54, 25);
            tabMenu.Location = new Point(-4, 76);
            tabMenu.Multiline = true;
            tabMenu.Name = "tabMenu";
            tabMenu.Padding = new Point(49, 3);
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(661, 289);
            tabMenu.TabIndex = 14;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.LightCyan;
            tabHome.Controls.Add(dataGridHome);
            tabHome.Controls.Add(textBox1);
            tabHome.Controls.Add(welcome_text);
            tabHome.Controls.Add(pictureBox2);
            tabHome.Controls.Add(scan_qr_button);
            tabHome.Location = new Point(4, 29);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(653, 256);
            tabHome.TabIndex = 0;
            tabHome.Text = "Home";
            tabHome.Click += tabPage1_Click;
            // 
            // dataGridHome
            // 
            dataGridHome.BackgroundColor = Color.LightCyan;
            dataGridHome.BorderStyle = BorderStyle.None;
            dataGridHome.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridHome.Columns.AddRange(new DataGridViewColumn[] { patient_ID, patient_username, patient_password, patient_firstName, patient_lastName, patient_dob, patient_gender, patient_phone, patient_email, patient_address, patient_emergencyFirstName, patient_emergencyLastName, patient_emergencyPhone, patient_emergencyRelation });
            dataGridHome.Location = new Point(7, 127);
            dataGridHome.Name = "dataGridHome";
            dataGridHome.RowTemplate.Height = 25;
            dataGridHome.Size = new Size(639, 117);
            dataGridHome.TabIndex = 20;
            dataGridHome.CellContentClick += dataGridView3_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(549, 25);
            textBox1.TabIndex = 19;
            // 
            // welcome_text
            // 
            welcome_text.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            welcome_text.Location = new Point(329, 2);
            welcome_text.Name = "welcome_text";
            welcome_text.Size = new Size(309, 87);
            welcome_text.TabIndex = 18;
            welcome_text.Text = "Welcome back, [user]!";
            welcome_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_white;
            pictureBox2.Location = new Point(6, 2);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(317, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // scan_qr_button
            // 
            scan_qr_button.BackgroundImage = (Image)resources.GetObject("scan_qr_button.BackgroundImage");
            scan_qr_button.BackgroundImageLayout = ImageLayout.Zoom;
            scan_qr_button.FlatAppearance.BorderSize = 0;
            scan_qr_button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            scan_qr_button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            scan_qr_button.FlatStyle = FlatStyle.Flat;
            scan_qr_button.Location = new Point(561, 89);
            scan_qr_button.Name = "scan_qr_button";
            scan_qr_button.Size = new Size(82, 32);
            scan_qr_button.TabIndex = 17;
            scan_qr_button.UseVisualStyleBackColor = true;
            // 
            // tabVaccinationManagement
            // 
            tabVaccinationManagement.BackColor = Color.LightCyan;
            tabVaccinationManagement.Controls.Add(dataGridVaccines1);
            tabVaccinationManagement.Location = new Point(4, 29);
            tabVaccinationManagement.Name = "tabVaccinationManagement";
            tabVaccinationManagement.Size = new Size(653, 256);
            tabVaccinationManagement.TabIndex = 2;
            tabVaccinationManagement.Text = "Vaccination Management";
            // 
            // dataGridVaccines1
            // 
            dataGridVaccines1.BackgroundColor = Color.LightCyan;
            dataGridVaccines1.BorderStyle = BorderStyle.None;
            dataGridVaccines1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVaccines1.Location = new Point(7, 127);
            dataGridVaccines1.Name = "dataGridVaccines1";
            dataGridVaccines1.RowTemplate.Height = 25;
            dataGridVaccines1.Size = new Size(639, 117);
            dataGridVaccines1.TabIndex = 21;
            // 
            // tabVaccinationReports
            // 
            tabVaccinationReports.BackColor = Color.LightCyan;
            tabVaccinationReports.Controls.Add(dataGridVaccines2);
            tabVaccinationReports.Controls.Add(yearly_report_info);
            tabVaccinationReports.Controls.Add(montly_report_info);
            tabVaccinationReports.Controls.Add(daily_report_info);
            tabVaccinationReports.Controls.Add(label4);
            tabVaccinationReports.Controls.Add(label3);
            tabVaccinationReports.Controls.Add(label2);
            tabVaccinationReports.Controls.Add(pictureBox8);
            tabVaccinationReports.Controls.Add(pictureBox1);
            tabVaccinationReports.Controls.Add(pictureBox7);
            tabVaccinationReports.Controls.Add(pictureBox6);
            tabVaccinationReports.Controls.Add(pictureBox5);
            tabVaccinationReports.Controls.Add(pictureBox4);
            tabVaccinationReports.Controls.Add(pictureBox3);
            tabVaccinationReports.Location = new Point(4, 29);
            tabVaccinationReports.Name = "tabVaccinationReports";
            tabVaccinationReports.Size = new Size(653, 256);
            tabVaccinationReports.TabIndex = 3;
            tabVaccinationReports.Text = "Vaccination Reports";
            // 
            // dataGridVaccines2
            // 
            dataGridVaccines2.BackgroundColor = Color.LightCyan;
            dataGridVaccines2.BorderStyle = BorderStyle.None;
            dataGridVaccines2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridVaccines2.Location = new Point(7, 127);
            dataGridVaccines2.Name = "dataGridVaccines2";
            dataGridVaccines2.RowTemplate.Height = 25;
            dataGridVaccines2.Size = new Size(639, 117);
            dataGridVaccines2.TabIndex = 21;
            // 
            // yearly_report_info
            // 
            yearly_report_info.AutoSize = true;
            yearly_report_info.BackColor = Color.FromArgb(178, 223, 219);
            yearly_report_info.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            yearly_report_info.Location = new Point(453, 53);
            yearly_report_info.Name = "yearly_report_info";
            yearly_report_info.Size = new Size(44, 17);
            yearly_report_info.TabIndex = 15;
            yearly_report_info.Text = "Year : ";
            // 
            // montly_report_info
            // 
            montly_report_info.AutoSize = true;
            montly_report_info.BackColor = Color.FromArgb(178, 223, 219);
            montly_report_info.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            montly_report_info.Location = new Point(236, 53);
            montly_report_info.Name = "montly_report_info";
            montly_report_info.Size = new Size(57, 17);
            montly_report_info.TabIndex = 14;
            montly_report_info.Text = "Month : ";
            // 
            // daily_report_info
            // 
            daily_report_info.AutoSize = true;
            daily_report_info.BackColor = Color.FromArgb(178, 223, 219);
            daily_report_info.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            daily_report_info.Location = new Point(24, 53);
            daily_report_info.Name = "daily_report_info";
            daily_report_info.Size = new Size(46, 17);
            daily_report_info.TabIndex = 13;
            daily_report_info.Text = "Date : ";
            // 
            // label4
            // 
            label4.BackColor = Color.FromArgb(0, 150, 136);
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(461, 13);
            label4.Name = "label4";
            label4.Size = new Size(161, 24);
            label4.TabIndex = 12;
            label4.Text = "Yearly Report";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(0, 150, 136);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(244, 12);
            label3.Name = "label3";
            label3.Size = new Size(161, 24);
            label3.TabIndex = 11;
            label3.Text = "Monthly Report";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(0, 150, 136);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(32, 12);
            label2.Name = "label2";
            label2.Size = new Size(161, 24);
            label2.TabIndex = 10;
            label2.Text = "Daily Report";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(178, 223, 219);
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(453, 9);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(178, 31);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(178, 223, 219);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(178, 223, 219);
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(24, 8);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(178, 31);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 7;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(610, 97);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(8, 8);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(436, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(210, 117);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 2;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(220, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(210, 117);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(7, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(210, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tabBtn3
            // 
            tabBtn3.BackColor = Color.FromArgb(178, 223, 220);
            tabBtn3.FlatAppearance.BorderSize = 0;
            tabBtn3.FlatStyle = FlatStyle.Flat;
            tabBtn3.Location = new Point(440, 60);
            tabBtn3.Name = "tabBtn3";
            tabBtn3.Size = new Size(215, 35);
            tabBtn3.TabIndex = 23;
            tabBtn3.Text = "Vaccination Reports";
            tabBtn3.UseVisualStyleBackColor = false;
            tabBtn3.Click += tabBtn3_Click;
            // 
            // tabBtn2
            // 
            tabBtn2.BackColor = Color.FromArgb(178, 223, 220);
            tabBtn2.FlatAppearance.BorderSize = 0;
            tabBtn2.FlatStyle = FlatStyle.Flat;
            tabBtn2.Location = new Point(219, 60);
            tabBtn2.Name = "tabBtn2";
            tabBtn2.Size = new Size(215, 35);
            tabBtn2.TabIndex = 22;
            tabBtn2.Text = "Vaccination Management";
            tabBtn2.UseVisualStyleBackColor = false;
            tabBtn2.Click += tabBtn2_Click;
            // 
            // tabBtn1
            // 
            tabBtn1.BackColor = Color.LightCyan;
            tabBtn1.FlatAppearance.BorderSize = 0;
            tabBtn1.FlatStyle = FlatStyle.Flat;
            tabBtn1.Location = new Point(-2, 60);
            tabBtn1.Name = "tabBtn1";
            tabBtn1.Size = new Size(215, 35);
            tabBtn1.TabIndex = 21;
            tabBtn1.Text = "Home";
            tabBtn1.UseVisualStyleBackColor = false;
            tabBtn1.Click += tabBtn1_Click;
            // 
            // patient_ID
            // 
            patient_ID.HeaderText = "ID";
            patient_ID.Name = "patient_ID";
            // 
            // patient_username
            // 
            patient_username.HeaderText = "Username";
            patient_username.Name = "patient_username";
            // 
            // patient_password
            // 
            patient_password.HeaderText = "Password";
            patient_password.Name = "patient_password";
            // 
            // patient_firstName
            // 
            patient_firstName.HeaderText = "First Name";
            patient_firstName.Name = "patient_firstName";
            // 
            // patient_lastName
            // 
            patient_lastName.HeaderText = "Last Name";
            patient_lastName.Name = "patient_lastName";
            // 
            // patient_dob
            // 
            patient_dob.HeaderText = "DOB";
            patient_dob.Name = "patient_dob";
            // 
            // patient_gender
            // 
            patient_gender.HeaderText = "Gender";
            patient_gender.Name = "patient_gender";
            // 
            // patient_phone
            // 
            patient_phone.HeaderText = "Phone";
            patient_phone.Name = "patient_phone";
            // 
            // patient_email
            // 
            patient_email.HeaderText = "Email";
            patient_email.Name = "patient_email";
            // 
            // patient_address
            // 
            patient_address.HeaderText = "Address";
            patient_address.Name = "patient_address";
            // 
            // patient_emergencyFirstName
            // 
            patient_emergencyFirstName.HeaderText = "Emergency First name";
            patient_emergencyFirstName.Name = "patient_emergencyFirstName";
            // 
            // patient_emergencyLastName
            // 
            patient_emergencyLastName.HeaderText = "Emergency Last Name";
            patient_emergencyLastName.Name = "patient_emergencyLastName";
            // 
            // patient_emergencyPhone
            // 
            patient_emergencyPhone.HeaderText = "Emergency Phone";
            patient_emergencyPhone.Name = "patient_emergencyPhone";
            // 
            // patient_emergencyRelation
            // 
            patient_emergencyRelation.HeaderText = "Emergency Relation";
            patient_emergencyRelation.Name = "patient_emergencyRelation";
            // 
            // Staff_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(654, 361);
            Controls.Add(tabBtn1);
            Controls.Add(tabBtn2);
            Controls.Add(tabBtn3);
            Controls.Add(tabMenu);
            Controls.Add(banner);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff_Main";
            RightToLeft = RightToLeft.No;
            Text = "Staff_Main";
            Load += Staff_Main_Load;
            banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile).EndInit();
            tabMenu.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabVaccinationManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridVaccines1).EndInit();
            tabVaccinationReports.ResumeLayout(false);
            tabVaccinationReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridVaccines2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel banner;
        private PictureBox menu_button;
        private PictureBox logo_button;
        private PictureBox profile;
        private TabControl tabMenu;
        private TabPage tabHome;
        private TabPage tabVaccinationManagement;
        private TabPage tabVaccinationReports;
        private PictureBox pictureBox1;
        private Label daily_report_info;
        private DataGridViewTextBoxColumn passwdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emergencyContactNameDataGridViewTextBoxColumn;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label yearly_report_info;
        private Label montly_report_info;
        private Button scan_qr_button;
        private Label welcome_text;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private DataGridView dataGridHome;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emergencyContactFirstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emergencyContactLastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emergencyContactPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emergencyContactRelationDataGridViewTextBoxColumn;
        private Button tabBtn3;
        private Button tabBtn2;
        private Button tabBtn1;
        private DataGridView dataGridVaccines2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridView dataGridVaccines1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn patient_ID;
        private DataGridViewTextBoxColumn patient_username;
        private DataGridViewTextBoxColumn patient_password;
        private DataGridViewTextBoxColumn patient_firstName;
        private DataGridViewTextBoxColumn patient_lastName;
        private DataGridViewTextBoxColumn patient_dob;
        private DataGridViewTextBoxColumn patient_gender;
        private DataGridViewTextBoxColumn patient_phone;
        private DataGridViewTextBoxColumn patient_email;
        private DataGridViewTextBoxColumn patient_address;
        private DataGridViewTextBoxColumn patient_emergencyFirstName;
        private DataGridViewTextBoxColumn patient_emergencyLastName;
        private DataGridViewTextBoxColumn patient_emergencyPhone;
        private DataGridViewTextBoxColumn patient_emergencyRelation;
    }
}