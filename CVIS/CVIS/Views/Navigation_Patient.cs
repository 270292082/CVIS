using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SysFunc;

namespace CVIS
{
    public partial class Navigation_Patient : Form
    {
        private Panel _page_display;
        private Form page;
        private Panel _display_nav;

        public Navigation_Patient(Panel page_display, Form page, Panel display_nav)
        {
            InitializeComponent();
            Form _page = page;
            _page_display = page_display;
            _display_nav= display_nav;
        }

        private void logo_button_Click(object sender, EventArgs e)
        {
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(_display_nav, 0);
        }

        private void logout_button1_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Login(_page_display));
        }

        private void logout_button2_Click(object sender, EventArgs e)
        {

            Sys.loadPage(_page_display, new Login(_page_display));
        }

        private void profile_button1_Click(object sender, EventArgs e)
        {

        }

        private void qrcode_button1_Click(object sender, EventArgs e)
        {
            
        }

        private void qrcode_button2_Click(object sender, EventArgs e)
        {

        }
    }
}
