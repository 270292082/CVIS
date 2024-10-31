using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SysFunc;

namespace CVIS
{
    public partial class Patient_Profile : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private Panel _display;
        private JSON.Patient _patient;
        public Patient_Profile(Panel display, JSON.Patient patient)
        {
            InitializeComponent();
            _display= display;
            _patient= patient;

            string info_msg = string.Empty;
            info_msg += "Name : " + patient.FirstName + " " + patient.LastName + "\n\n";
            info_msg += "DOB : " + patient.DOB + "\n\n";
            info_msg += "Gender : " + patient.Gender + "\n\n";
            info_msg += "ID Number : " + patient.ID + "\n\n";
            info_msg += "Email Address : " + patient.Email + "\n\n";
            info_msg += "Mobile Number : " + patient.Phone + "\n\n";
            info_msg += "Address : " + patient.Address + "\n\n";

            patient_ID_text.Text = "User ID : " + patient.ID.ToString();
            info_text.Text = info_msg;

            info_msg = string.Empty;
            info_msg += "Name : " + patient.EmergencyContactName+ "\n";
            info_msg += "Mobile Number : " + patient.EmergencyContactPhone + "\n";
            info_msg += "Relation : " + patient.EmergencyContactRelation + "\n";
            emergency_contact_text.Text = info_msg;

            string qrcode_content = Task.Run(async () => PatientFunc.PatientFunc.getStatusQR(patient.ID, 0)).Result;
            qrcode_text.Text = qrcode_content;

            vac_stat_text.Text = "Vaccination Status : " + patient.getStatus(0);


            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation(_display, display_nav));


        }

        private void logo_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_display, new Patient_Main(_display, _patient));
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }

        private void Patient_Profile_Load(object sender, EventArgs e)
        {

        }
    }
}
