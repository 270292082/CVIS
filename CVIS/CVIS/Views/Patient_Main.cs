using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using users;
using SysFunc;

namespace CVIS
{
    public partial class Patient_Main : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private Panel _page_display;
        private Patient _patient;
        public Panel QRCode_Display => qrcode_display;
        public Patient_Main(Panel page_display, Patient patient) {
            InitializeComponent();
            _page_display = page_display;
            _patient = patient; 

            string info = string.Empty;
            info += "Name : " + patient.firstName + " " + patient.lastName + "\n\n";
            info += "DOB : " + patient.DOB + "\n\n";
            info += "Gender : " + patient.gender + "\n\n";

            info_text.Text = info;

            vac_data.AllowUserToAddRows = false;

            for (int i = 0; i < patient.getVaccines(0).Count; i++)
            {
                vac_data.Rows.Add(i, patient.getVaccines(i));
                vac_data.Rows[i].Cells[0].Value = (i+1) + " Dose";
                vac_data.Rows[i].Cells[1].Value = patient.vaccines_type[i];
                vac_data.Rows[i].Cells[2].Value = patient.vaccines_lot[i];
                vac_data.Rows[i].Cells[3].Value = patient.vaccines_date[i];
                vac_data.Rows[i].Cells[4].Value = patient.vaccines_doctor[i];
            }

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

        private async Task InitializeAsync()
        {
            string qrcode_content = await _patient.getStatusQR();
            qrcode_text.Text = qrcode_content;

        }
        private async void Patient_Main_Load(object sender, EventArgs e)
        {
            await InitializeAsync(); 
        }


        private void profile_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Patient_Profile(_page_display, _patient));
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }
    }
}
