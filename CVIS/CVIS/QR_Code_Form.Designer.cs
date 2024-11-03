namespace CVIS
{
    partial class QR_Code_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Code_Form));
            this.qr_code_text = new System.Windows.Forms.Label();
            this.user_id_text = new System.Windows.Forms.Label();
            this.user_name_text = new System.Windows.Forms.Label();
            this.cross_button = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cross_button)).BeginInit();
            this.SuspendLayout();
            // 
            // qr_code_text
            // 
            this.qr_code_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.qr_code_text.Location = new System.Drawing.Point(12, 45);
            this.qr_code_text.Name = "qr_code_text";
            this.qr_code_text.Size = new System.Drawing.Size(314, 293);
            this.qr_code_text.TabIndex = 0;
            this.qr_code_text.Text = "[QR Code]";
            this.qr_code_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_id_text
            // 
            this.user_id_text.Location = new System.Drawing.Point(12, 361);
            this.user_id_text.Name = "user_id_text";
            this.user_id_text.Size = new System.Drawing.Size(314, 23);
            this.user_id_text.TabIndex = 1;
            this.user_id_text.Text = "[User ID]";
            this.user_id_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user_name_text
            // 
            this.user_name_text.Location = new System.Drawing.Point(12, 338);
            this.user_name_text.Name = "user_name_text";
            this.user_name_text.Size = new System.Drawing.Size(314, 23);
            this.user_name_text.TabIndex = 2;
            this.user_name_text.Text = "[User First + Last Name]";
            this.user_name_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cross_button
            // 
            this.cross_button.Image = ((System.Drawing.Image)(resources.GetObject("cross_button.Image")));
            this.cross_button.Location = new System.Drawing.Point(296, 12);
            this.cross_button.Name = "cross_button";
            this.cross_button.Size = new System.Drawing.Size(30, 30);
            this.cross_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cross_button.TabIndex = 3;
            this.cross_button.TabStop = false;
            this.cross_button.Click += new System.EventHandler(this.cross_button_Click);
            // 
            // QR_Code_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 450);
            this.Controls.Add(this.cross_button);
            this.Controls.Add(this.user_name_text);
            this.Controls.Add(this.user_id_text);
            this.Controls.Add(this.qr_code_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QR_Code_Form";
            this.Text = "QR_Code_Form";
            this.Load += new System.EventHandler(this.QR_Code_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cross_button)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label qr_code_text;
        private Label user_id_text;
        private Label user_name_text;
        private PictureBox cross_button;
    }
}