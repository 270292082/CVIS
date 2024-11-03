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
        private Panel _qrcode_display;
        private Panel _display_nav;
        private JSON.Patient _patient;

        public Navigation_Patient(Panel page_display, Panel qrcode_display, Panel display_nav, JSON.Patient patient)
        {
            InitializeComponent();
            _qrcode_display = qrcode_display;
            _page_display = page_display;
            _display_nav= display_nav;
            _patient = patient;
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
            Sys.loadPage(_page_display, new Patient_Profile(_page_display, _patient));
        }
        private void profile_button2_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Patient_Profile(_page_display, _patient));
        }
        private void qrcode_button1_Click(object sender, EventArgs e)
        {
            _qrcode_display.Location = new Point(202, 25);
        }

        private void qrcode_button2_Click(object sender, EventArgs e)
        {
            _qrcode_display.Location = new Point(202, 25);
        }

        
    }
}
