using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SysFunc;

using users;

namespace CVIS
{
    public partial class Patient_Profile : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private Panel _page_display;
        private Patient _patient;
        public Panel QRCode_Display => qrcode_display;

        public Patient_Profile(Panel page_display, Patient patient)
        {
            InitializeComponent();
            _page_display = page_display;
            _patient= patient;

            string info_msg = string.Empty;
            info_msg += "Name : " + patient.firstName + " " + patient.lastName + "\n\n";
            info_msg += "DOB : " + patient.DOB + "\n\n";
            info_msg += "Gender : " + patient.gender + "\n\n";
            info_msg += "ID Number : " + patient.ID + "\n\n";
            info_msg += "Email Address : " + patient.email + "\n\n";
            info_msg += "Mobile Number : " + patient.phone + "\n\n";
            info_msg += "Address : " + patient.address + "\n\n";

            patient_ID_text.Text = "User ID : " + patient.ID.ToString();
            info_text.Text = info_msg;

            info_msg = string.Empty;
            info_msg += "Name : " + patient.emergencyContactFirstName + " " + patient.emergencyContactLastName + "\n";
            info_msg += "Mobile Number : " + patient.emergencyContactPhone + "\n";
            info_msg += "Relation : " + patient.emergencyContactRelation + "\n";
            emergency_contact_text.Text = info_msg;

            
            vac_stat_text.Text = "Vaccination Status : " + patient.getStatus(0);


            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation_Patient(page_display, qrcode_display, display_nav, patient));


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
        private async void Patient_Profile_Load(object sender, EventArgs e)
        {
            await InitializeAsync();
        }
        private void logo_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Patient_Main(_page_display, _patient));
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }

        private void banner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emergency_edit_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Patient_Settings(_page_display, _patient));
        }
    }
}
