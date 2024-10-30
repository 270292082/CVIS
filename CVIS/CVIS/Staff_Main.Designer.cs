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
            this.display_nav = new System.Windows.Forms.Panel();
            this.banner = new System.Windows.Forms.Panel();
            this.menu_button = new System.Windows.Forms.PictureBox();
            this.logo_button = new System.Windows.Forms.PictureBox();
            this.profile = new System.Windows.Forms.PictureBox();
            this.welcome_text = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.banner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display_nav
            // 
            this.display_nav.Location = new System.Drawing.Point(0, 0);
            this.display_nav.Name = "display_nav";
            this.display_nav.Size = new System.Drawing.Size(5, 361);
            this.display_nav.TabIndex = 11;
            // 
            // banner
            // 
            this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.banner.AutoSize = true;
            this.banner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(151)))), ((int)(((byte)(136)))));
            this.banner.Controls.Add(this.menu_button);
            this.banner.Controls.Add(this.logo_button);
            this.banner.Controls.Add(this.profile);
            this.banner.Location = new System.Drawing.Point(0, 0);
            this.banner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.banner.Name = "banner";
            this.banner.Size = new System.Drawing.Size(654, 60);
            this.banner.TabIndex = 10;
            // 
            // menu_button
            // 
            this.menu_button.Image = ((System.Drawing.Image)(resources.GetObject("menu_button.Image")));
            this.menu_button.Location = new System.Drawing.Point(12, 10);
            this.menu_button.Name = "menu_button";
            this.menu_button.Size = new System.Drawing.Size(20, 40);
            this.menu_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menu_button.TabIndex = 8;
            this.menu_button.TabStop = false;
            // 
            // logo_button
            // 
            this.logo_button.Image = global::CVIS.Properties.Resources.logo_white;
            this.logo_button.Location = new System.Drawing.Point(38, 10);
            this.logo_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo_button.Name = "logo_button";
            this.logo_button.Size = new System.Drawing.Size(105, 40);
            this.logo_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_button.TabIndex = 0;
            this.logo_button.TabStop = false;
            // 
            // profile
            // 
            this.profile.Image = global::CVIS.Properties.Resources.profile_placeholder;
            this.profile.Location = new System.Drawing.Point(570, 9);
            this.profile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(72, 42);
            this.profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile.TabIndex = 1;
            this.profile.TabStop = false;
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_text.Location = new System.Drawing.Point(6, 3);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(140, 23);
            this.welcome_text.TabIndex = 13;
            this.welcome_text.Text = "Welcome [USER]!";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(54, 25);
            this.tabControl1.Location = new System.Drawing.Point(11, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(30, 3);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 284);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.welcome_text);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 251);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 251);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(623, 251);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vaccination Management";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(623, 251);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vaccination Reports";
            // 
            // Staff_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(654, 361);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.display_nav);
            this.Controls.Add(this.banner);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Staff_Main";
            this.Text = "Staff_Main";
            this.banner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.menu_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel display_nav;
        private Panel banner;
        private PictureBox menu_button;
        private PictureBox logo_button;
        private PictureBox profile;
        private Label welcome_text;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}