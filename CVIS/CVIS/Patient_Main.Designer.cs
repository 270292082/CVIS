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
            this.banner = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.profile_button = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.vac_data = new System.Windows.Forms.DataGridView();
            this.vaccination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lot_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dov = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vaccinator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.qrcode_text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.info_text = new System.Windows.Forms.Label();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vac_data)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.AutoSize = true;
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.banner.Controls.Add(this.logo);
            this.banner.Controls.Add(this.profile_button);
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(654, 60);
            this.banner.TabIndex = 5;
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
            // panel2
            // 
            this.panel2.Controls.Add(this.vac_data);
            this.panel2.Location = new System.Drawing.Point(12, 196);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 148);
            this.panel2.TabIndex = 7;
            // 
            // vac_data
            // 
            this.vac_data.BackgroundColor = System.Drawing.Color.LightCyan;
            this.vac_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vac_data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.vac_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vac_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vaccination,
            this.manufacturer,
            this.lot_number,
            this.dov,
            this.vaccinator});
            this.vac_data.Location = new System.Drawing.Point(0, 3);
            this.vac_data.Name = "vac_data";
            this.vac_data.RowTemplate.Height = 25;
            this.vac_data.Size = new System.Drawing.Size(627, 142);
            this.vac_data.TabIndex = 0;
            // 
            // vaccination
            // 
            this.vaccination.HeaderText = "Vaccination";
            this.vaccination.Name = "vaccination";
            this.vaccination.Width = 120;
            // 
            // manufacturer
            // 
            this.manufacturer.HeaderText = "Manufacturer";
            this.manufacturer.Name = "manufacturer";
            this.manufacturer.Width = 120;
            // 
            // lot_number
            // 
            this.lot_number.HeaderText = "Lot Number";
            this.lot_number.Name = "lot_number";
            this.lot_number.Width = 120;
            // 
            // dov
            // 
            this.dov.HeaderText = "Date of Vaccination";
            this.dov.Name = "dov";
            this.dov.Width = 105;
            // 
            // vaccinator
            // 
            this.vaccinator.HeaderText = "Vaccinator";
            this.vaccinator.Name = "vaccinator";
            this.vaccinator.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.qrcode_text);
            this.panel3.Location = new System.Drawing.Point(515, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(127, 127);
            this.panel3.TabIndex = 8;
            // 
            // qrcode_text
            // 
            this.qrcode_text.BackColor = System.Drawing.Color.LightCyan;
            this.qrcode_text.Font = new System.Drawing.Font("Consolas", 3.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qrcode_text.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.qrcode_text.Location = new System.Drawing.Point(0, 0);
            this.qrcode_text.Name = "qrcode_text";
            this.qrcode_text.Size = new System.Drawing.Size(127, 127);
            this.qrcode_text.TabIndex = 0;
            this.qrcode_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.info_text);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 127);
            this.panel1.TabIndex = 6;
            // 
            // info_text
            // 
            this.info_text.AutoSize = true;
            this.info_text.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.info_text.Location = new System.Drawing.Point(4, 9);
            this.info_text.Name = "info_text";
            this.info_text.Size = new System.Drawing.Size(45, 20);
            this.info_text.TabIndex = 0;
            this.info_text.Text = "[Info]";
            // 
            // Patient_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.banner);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient_Main";
            this.Text = "Patient_Main";
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_button)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vac_data)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DataGridViewTextBoxColumn vaccination;
        private DataGridViewTextBoxColumn manufacturer;
        private DataGridViewTextBoxColumn lot_number;
        private DataGridViewTextBoxColumn dov;
        private DataGridViewTextBoxColumn vaccinator;
    }
}