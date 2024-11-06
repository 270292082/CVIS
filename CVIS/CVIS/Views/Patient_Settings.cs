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
    public partial class Patient_Settings : Form
    {
        private Panel _page_display;
        private JSON.Patient _patient;
        public Patient_Settings(Panel page_display, JSON.Patient patient)
        {
            InitializeComponent();
            _page_display = page_display;
            _patient = patient;

            username_input.Text = patient.username;
            password_input.Text = patient.passwd;
            phone_input.Text = patient.Phone.ToString();


            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation_Patient(_page_display, qrcode_display, display_nav, patient));

            // Set the position and size for the qrcode display panel.
            qrcode_display.Visible = true;
            qrcode_display.Size = new Size(249, 311);
            qrcode_display.Location = new Point(0, 1000);
            Sys.loadPage(qrcode_display, new QR_Code_Form(qrcode_display, patient));

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }
    }
}
