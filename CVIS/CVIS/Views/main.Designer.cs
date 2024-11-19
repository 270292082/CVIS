namespace CVIS
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            display = new Panel();
            SuspendLayout();
            // 
            // display
            // 
            display.Dock = DockStyle.Fill;
            display.Location = new Point(0, 0);
            display.Margin = new Padding(3, 2, 3, 2);
            display.Name = "display";
            display.Size = new Size(654, 361);
            display.TabIndex = 0;
            // 
            // main
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = Color.LightCyan;
            ClientSize = new Size(654, 361);
            Controls.Add(display);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "main";
            Text = " CVIS";
            Load += main_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel display;
    }
}