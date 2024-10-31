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
    public partial class Staff_Main : Form
    {
        private Panel _display;
        public Staff_Main(Panel display, JSON.Staff staff)
        {
            InitializeComponent();
            _display= display;

            welcome_text.Text = "Welcome, ";
            welcome_text.Text += staff.FirstName + " ";
            welcome_text.Text += staff.LastName + "!";

            daily_report_info.Text = "Date: ";
            daily_report_info.Text += "" + "\n"; // Insert the data.
            daily_report_info.Text += "Total Vaccinated: " + "\n";
            daily_report_info.Text += ""; // Insert the data.

            montly_report_info.Text = "Month: ";
            montly_report_info.Text += "" + "\n"; // Insert the data.
            montly_report_info.Text += "Total Vaccinated: " + "\n";
            montly_report_info.Text += "" + "\n"; // Insert the data.

            yearly_report_info.Text = "Year: ";
            yearly_report_info.Text += "" + "\n"; // Insert the data.
            yearly_report_info.Text += "Total Vaccinated: " + "\n";
            yearly_report_info.Text += "" + "\n"; // Insert the data.


            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation(_display, display_nav));

        }

        private void scan_qr_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No scanners were detected!", "ERROR!");
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }
    }
}
