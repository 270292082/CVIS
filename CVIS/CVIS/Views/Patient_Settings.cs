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


            // read only fields
            firstname_input.ReadOnly = true;
            lastname_input.ReadOnly = true;
            dob_input.ReadOnly = true;

            // user cannot tab
            firstname_input.TabStop = false;
            lastname_input.TabStop = false;
            dob_input.TabStop = false;  


            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation_Patient(_page_display, qrcode_display, display_nav, patient));

            // Set the position and size for the qrcode display panel.
            qrcode_display.Visible = false;
            qrcode_display.Size = new Size(249, 311);
            Sys.loadPage(qrcode_display, new QR_Code_Form(qrcode_display, patient));

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }

        private void Patient_Settings_Load(object sender, EventArgs e)
        {

        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username_input.Text) ||
                string.IsNullOrWhiteSpace(password_input.Text) ||
                string.IsNullOrWhiteSpace(firstname_input.Text) ||
                string.IsNullOrWhiteSpace(lastname_input.Text) ||
                string.IsNullOrWhiteSpace(dob_input.Text) ||
                string.IsNullOrWhiteSpace(email_input.Text) ||
                string.IsNullOrWhiteSpace(address_input.Text) ||
                string.IsNullOrWhiteSpace(phone_input.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            if (string.IsNullOrWhiteSpace(efirstname_input.Text) ||
        string.IsNullOrWhiteSpace(ephone_input.Text))
            {
                MessageBox.Show("Emergency contact's first name and phone number are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Patient updatedPatient = new Patient
            {
                ID = _patient.ID,
                username = username_input.Text,
                password = password_input.Text,

                email = email_input.Text,
                address = address_input.Text,
                phone = phone_input.Text,

                emergencyContactFirstName = efirstname_input.Text,
                emergencyContactLastName = elastname_input.Text,
                emergencyContactPhone = ephone_input.Text,
                emergencyContactRelation = erelation_input.Text,
            };

            // call update function
            Database.UpdatePatientInDatabase(updatedPatient);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Patient_Main(_page_display, _patient));
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Patient_Profile(_page_display, _patient));
        }
    }
}
