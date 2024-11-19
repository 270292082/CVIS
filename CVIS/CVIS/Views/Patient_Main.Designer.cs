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
            menu_button = new PictureBox();
            logo = new PictureBox();
            profile_button = new PictureBox();
            panel2 = new Panel();
            vac_data = new DataGridView();
            panel3 = new Panel();
            qrcode_text = new Label();
            panel1 = new Panel();
            info_text = new Label();
            display_nav = new Panel();
            qrcode_display = new Panel();
            vaccination = new DataGridViewTextBoxColumn();
            manufacturer = new DataGridViewTextBoxColumn();
            lot_number = new DataGridViewTextBoxColumn();
            dov = new DataGridViewTextBoxColumn();
            vaccinator = new DataGridViewTextBoxColumn();
            banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menu_button).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profile_button).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vac_data).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
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
            banner.Margin = new Padding(3, 2, 3, 2);
            banner.Name = "banner";
            banner.Size = new Size(654, 60);
            banner.TabIndex = 5;
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
            // panel2
            // 
            panel2.Controls.Add(vac_data);
            panel2.Location = new Point(12, 196);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(630, 148);
            panel2.TabIndex = 7;
            // 
            // vac_data
            // 
            vac_data.AllowUserToAddRows = false;
            vac_data.AllowUserToDeleteRows = false;
            vac_data.BackgroundColor = Color.LightCyan;
            vac_data.BorderStyle = BorderStyle.None;
            vac_data.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            vac_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vac_data.Columns.AddRange(new DataGridViewColumn[] { vaccination, manufacturer, lot_number, dov, vaccinator });
            vac_data.Location = new Point(0, 3);
            vac_data.Name = "vac_data";
            vac_data.ReadOnly = true;
            vac_data.RowTemplate.Height = 25;
            vac_data.Size = new Size(627, 142);
            vac_data.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(qrcode_text);
            panel3.Location = new Point(515, 64);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(127, 127);
            panel3.TabIndex = 8;
            // 
            // qrcode_text
            // 
            qrcode_text.BackColor = Color.LightCyan;
            qrcode_text.Font = new Font("Consolas", 3.75F, FontStyle.Bold, GraphicsUnit.Point);
            qrcode_text.ForeColor = Color.DarkSlateGray;
            qrcode_text.Location = new Point(0, 0);
            qrcode_text.Name = "qrcode_text";
            qrcode_text.Size = new Size(127, 127);
            qrcode_text.TabIndex = 0;
            qrcode_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(info_text);
            panel1.Location = new Point(12, 64);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(497, 127);
            panel1.TabIndex = 6;
            // 
            // info_text
            // 
            info_text.AutoSize = true;
            info_text.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            info_text.Location = new Point(4, 9);
            info_text.Name = "info_text";
            info_text.Size = new Size(45, 20);
            info_text.TabIndex = 0;
            info_text.Text = "[Info]";
            // 
            // display_nav
            // 
            display_nav.Location = new Point(0, 0);
            display_nav.Name = "display_nav";
            display_nav.Size = new Size(5, 361);
            display_nav.TabIndex = 1;
            // 
            // qrcode_display
            // 
            qrcode_display.Location = new Point(554, 10);
            qrcode_display.Name = "qrcode_display";
            qrcode_display.Size = new Size(11, 41);
            qrcode_display.TabIndex = 9;
            // 
            // vaccination
            // 
            vaccination.HeaderText = "Vaccination";
            vaccination.Name = "vaccination";
            vaccination.ReadOnly = true;
            vaccination.Width = 120;
            // 
            // manufacturer
            // 
            manufacturer.HeaderText = "Manufacturer";
            manufacturer.Name = "manufacturer";
            manufacturer.ReadOnly = true;
            manufacturer.Width = 120;
            // 
            // lot_number
            // 
            lot_number.HeaderText = "Lot Number";
            lot_number.Name = "lot_number";
            lot_number.ReadOnly = true;
            lot_number.Width = 120;
            // 
            // dov
            // 
            dov.HeaderText = "Date of Vaccination";
            dov.Name = "dov";
            dov.ReadOnly = true;
            dov.Width = 105;
            // 
            // vaccinator
            // 
            vaccinator.HeaderText = "Vaccinator";
            vaccinator.Name = "vaccinator";
            vaccinator.ReadOnly = true;
            vaccinator.Width = 120;
            // 
            // Patient_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(654, 361);
            Controls.Add(qrcode_display);
            Controls.Add(display_nav);
            Controls.Add(banner);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Patient_Main";
            Text = "Patient_Main";
            Load += Patient_Main_Load;
            banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)menu_button).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)profile_button).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vac_data).EndInit();
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel banner;
        private PictureBox logo;
        private PictureBox profile_button;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Label qrcode_text;
        private Label info_text;
        private DataGridView vac_data;
        private Panel display_nav;
        private PictureBox menu_button;
        private Panel qrcode_display;
        private DataGridViewTextBoxColumn vaccination;
        private DataGridViewTextBoxColumn manufacturer;
        private DataGridViewTextBoxColumn lot_number;
        private DataGridViewTextBoxColumn dov;
        private DataGridViewTextBoxColumn vaccinator;
    }
}