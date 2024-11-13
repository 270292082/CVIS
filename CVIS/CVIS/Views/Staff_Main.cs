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
using SysFunc;

namespace CVIS
{
    public partial class Staff_Main : Form
    {
        private Panel _display;
        public Staff_Main(Panel display, Staff staff)
        {
            InitializeComponent();
            _display= display;

            tabMenu.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabMenu.Region = new Region(new RectangleF(tabHome.Left, tabHome.Top, tabHome.Width, tabHome.Height));

            welcome_text.Text = "Welcome, ";
            welcome_text.Text += staff.firstName + " ";
            welcome_text.Text += staff.lastName + "!\n";
            welcome_text.Text += "CVIS / Helix Corp";

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
            // display_nav.Size = new Size(251, 361);
            // display_nav.Location = new Point(-251, 0);
            // display_nav.Visible = true;
            //Sys.loadPage(display_nav, new Navigation_Staff(_display, display_nav));       Navigation_Staff needs to be defined!

            
        }

        private void scan_qr_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No scanners were detected!", "ERROR!");
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            //Sys.toggleNav(display_nav, 1);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabBtn1_Click(object sender, EventArgs e)
        {
            tabMenu.SelectTab(tabHome);
            tabBtn1.BackColor = Color.LightCyan;
            tabBtn2.BackColor = Color.FromArgb(178, 223, 220);
            tabBtn3.BackColor = Color.FromArgb(178, 223, 220);
        }

        private void tabBtn2_Click(object sender, EventArgs e)
        {
            tabMenu.SelectTab(tabVaccinationManagement);
            tabBtn1.BackColor = Color.FromArgb(178, 223, 220);
            tabBtn2.BackColor = Color.LightCyan;
            tabBtn3.BackColor = Color.FromArgb(178, 223, 220);

        }

        private void tabBtn3_Click(object sender, EventArgs e)
        {
            tabMenu.SelectTab(tabVaccinationReports);
            tabBtn1.BackColor = Color.FromArgb(178, 223, 220);
            tabBtn2.BackColor = Color.FromArgb(178, 223, 220);
            tabBtn3.BackColor = Color.LightCyan;

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
