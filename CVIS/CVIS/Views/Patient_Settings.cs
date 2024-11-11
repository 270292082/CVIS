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
    public partial class Patient_Settings : Form
    {
        private Panel _page_display;
        private Patient _patient;
        public Patient_Settings(Panel page_display, Patient patient)
        {
            InitializeComponent();
            _page_display = page_display;
            _patient = patient;

            username_input.Text = patient.username;
            password_input.Text = patient.password;

            firstname_input.Text = patient.firstName;
            lastname_input.Text = patient.lastName;
            dob_input.Text = patient.DOB;
            email_input.Text = patient.email;
            address_input.Text = patient.address;
            phone_input.Text = patient.phone;

            efirstname_input.Text = patient.emergencyContactFirstName;
            elastname_input.Text = patient.emergencyContactLastName;
            ephone_input.Text = patient.emergencyContactPhone;
            erelation_input.Text = patient.emergencyContactRelation;




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
