namespace CVIS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.login_button = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.username_input = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.password_input);
            this.panel1.Controls.Add(this.username_input);
            this.panel1.Location = new System.Drawing.Point(192, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(269, 319);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CVIS.Properties.Resources.logo_dark;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_button.Location = new System.Drawing.Point(83, 206);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 43);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_input
            // 
            this.password_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_input.BackColor = System.Drawing.Color.Azure;
            this.password_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.password_input.Location = new System.Drawing.Point(0, 152);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(269, 33);
            this.password_input.TabIndex = 2;
            // 
            // username_input
            // 
            this.username_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_input.BackColor = System.Drawing.Color.Azure;
            this.username_input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username_input.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.username_input.Location = new System.Drawing.Point(0, 106);
            this.username_input.Name = "username_input";
            this.username_input.Size = new System.Drawing.Size(269, 33);
            this.username_input.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(154)))));
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox password_input;
        private TextBox username_input;
        private Button login_button;
        private PictureBox pictureBox1;
    }
}