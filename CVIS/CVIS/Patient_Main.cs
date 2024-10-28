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

using SysFunc;

namespace CVIS
{
    public partial class Patient_Main : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private main _main;
        private JSON.Patient _patient;
        public Patient_Main(main Main, JSON.Patient patient) {
            InitializeComponent();
            _main = Main;
            _patient = patient; 

            string info = string.Empty;
            info += "Name : " + patient.FirstName + " " + patient.LastName + "\n\n";
            info += "DOB : " + patient.DOB + "\n\n";
            info += "Gender : " + patient.Gender + "\n\n";

            string qrcode_content = Task.Run(async () => PatientFunc.PatientFunc.getStatusQR(patient.ID, 0)).Result;
            qrcode_text.Text = qrcode_content;


            info_text.Text = info;

            vac_data.AllowUserToAddRows = false;

            for (int i = 0; i < patient.getVaccines(0).Count; i++)
            {
                vac_data.Rows.Add(i, patient.getVaccines(i));
                vac_data.Rows[i].Cells[0].Value = (i+1) + " Dose";
                vac_data.Rows[i].Cells[1].Value = patient.vaccines_type[i];
                vac_data.Rows[i].Cells[2].Value = patient.vaccines_lot[i];
                vac_data.Rows[i].Cells[3].Value = patient.vaccines[i];
                vac_data.Rows[i].Cells[4].Value = patient.vaccines_doctor[i];
            }

            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;

            Sys.loadPage(display_nav, new Navigation(display_nav));
        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_main.Display, new Patient_Profile(_main, _patient));
        }

        private void Patient_Main_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
        }

    }
}
