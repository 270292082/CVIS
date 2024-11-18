using SysFunc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using users;

namespace CVIS.Views
{
    public partial class Navigation_Staff : Form
    {
        private Panel _page_display;
        private Panel _display_nav;
        private Staff _staff;
        public Navigation_Staff(Panel page_display, Panel display_nav, Staff staff)
        {
            InitializeComponent();
            _page_display = page_display;
            _display_nav = display_nav;
            _staff = staff;
        }

        private void logo_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Staff_Main(_page_display, _staff));
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
            Sys.loadPage(_page_display, new Staff_Profile(_page_display, _staff));
        }

        private void profile_button2_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Staff_Profile(_page_display, _staff));
        }

        private void settings_button1_Click(object sender, EventArgs e)
        {
            // setting to add
        }

        private void settings_button2_Click(object sender, EventArgs e)
        {
            // setting to add
        }
    }
}
