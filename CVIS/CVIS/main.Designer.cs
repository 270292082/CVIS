namespace CVIS
{
    partial class index
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qrcode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qrcode
            // 
            this.qrcode.AutoSize = true;
            this.qrcode.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qrcode.Location = new System.Drawing.Point(12, 9);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(43, 13);
            this.qrcode.TabIndex = 0;
            this.qrcode.Text = "QRCode";
            this.qrcode.Click += new System.EventHandler(this.qrcode_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 207);
            this.Controls.Add(this.qrcode);
            this.Name = "index";
            this.Text = "CVIS";
            this.Load += new System.EventHandler(this.index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label qrcode;
    }
}