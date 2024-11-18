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
using System.Diagnostics;
using System.CodeDom;
using CVIS.Views;

namespace CVIS
{
    public partial class Staff_Main : Form
    {
        private Panel _display;
        private Staff _staff;
        private Dictionary<string, Patient> _patients = Database.getPatients();
        public Staff_Main(Panel display, Staff staff)
        {
            InitializeComponent();
            _display= display;
            _staff= staff;

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
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation_Staff(_display, display_nav, staff));
            display_nav.BringToFront();

        }

        private void scan_qr_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No scanners were detected!", "ERROR!");
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            //Sys.toggleNav(display_nav, 1);
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

        private void Staff_Main_Load(object sender, EventArgs e)
        {
            // ! Should put the initialisation of the patient in an async function to not make the program freeze if there's a lot of patient to load. !
            Dictionary<string, Patient> patients = Database.getPatients();

            int nb = 0;
            foreach (var patient in patients.Values)
            {
                dataGridHome.Rows.Add(nb, patient);
                dataGridHome.Rows[nb].Cells[0].Value = patient.ID;
                dataGridHome.Rows[nb].Cells[1].Value = patient.username;
                dataGridHome.Rows[nb].Cells[2].Value = patient.firstName;
                dataGridHome.Rows[nb].Cells[3].Value = patient.lastName;
                dataGridHome.Rows[nb].Cells[4].Value = patient.DOB;
                dataGridHome.Rows[nb].Cells[5].Value = patient.gender;
                dataGridHome.Rows[nb].Cells[6].Value = patient.phone;
                dataGridHome.Rows[nb].Cells[7].Value = patient.email;
                dataGridHome.Rows[nb].Cells[8].Value = patient.address;
                dataGridHome.Rows[nb].Cells[9].Value = patient.emergencyContactFirstName;
                dataGridHome.Rows[nb].Cells[10].Value = patient.emergencyContactLastName;
                dataGridHome.Rows[nb].Cells[11].Value = patient.emergencyContactPhone;
                dataGridHome.Rows[nb].Cells[12].Value = patient.emergencyContactRelation;
                nb++;
            }

            infoInit(null);            
            dataGridVaccine.AllowUserToAddRows= false;


            

        }

        private void infoInit(Patient patient)
        {
            if (patient == null)
            {
                info1.Text = string.Empty;
                info1.Text += "User ID     :\n";
                info1.Text += "First Name  :\n";
                info1.Text += "LastName    :\n";
                info1.Text += "DOB         :\n";
                info1.Text += "Gender      :\n";

                info2.Text = string.Empty;
                info2.Text += "Username     :\n";
                info2.Text += "Email        :\n";
                info2.Text += "Mobile       :\n";
                info2.Text += "Address      :\n";

                return;
            }

            info1.Text = string.Empty;
            info1.Text += "Users ID    : " + patient.ID + "\n";
            info1.Text += "First Name  : " + patient.firstName + "\n";
            info1.Text += "Last Name   : " + patient.lastName + "\n";
            info1.Text += "DOB         : " + patient.DOB + "\n";
            info1.Text += "Gender      : " + patient.gender + "\n";

            info2.Text = string.Empty;
            info2.Text += "Username     : " + patient.username + "\n";
            info2.Text += "Email        : " + patient.email + "\n";
            info2.Text += "Mobile       : " + patient.phone + "\n";
            info2.Text += "Address      : \n" + patient.address + "\n";

        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            foreach (var patient in _patients)
            {
                if (search.Text != patient.Key.ToString() && search.Text != patient.Value.username)
                {
                    dataGridVaccine.AllowUserToAddRows = false;
                    infoInit(null);
                    vacInit(null);
                    continue;
                }

                dataGridVaccine.AllowUserToAddRows = true;
                infoInit(patient.Value);
                vacInit(patient.Value);
                return;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            foreach (var patient in _patients)
            {
                if (search.Text != patient.Key.ToString())
                {
                    dataGridVaccine.AllowUserToAddRows = false;
                    infoInit(null);
                    vacInit(null);
                    continue;
                }

                dataGridVaccine.AllowUserToAddRows = true;
                infoInit(patient.Value);
                vacInit(patient.Value);
                return;
            }
        }


        private void vacInit(Patient patient)
        {
            if (patient == null) 
            { 
                dataGridVaccine.Rows.Clear();
                return;
            }


            dataGridVaccine.Rows.Clear();
            for (int i = 0; i < patient.vaccines_date.Count(); i++)
            {
                // Adding the rows for the vaccines.
                dataGridVaccine.Rows.Add(i, patient);
                dataGridVaccine.Rows[i].Cells[0].Value = i+1 + " Dose";

                // Adding the datas
                dataGridVaccine.Rows[i].Cells[1].Value = patient.vaccines_type[i];
                dataGridVaccine.Rows[i].Cells[2].Value = patient.vaccines_lot[i];
                dataGridVaccine.Rows[i].Cells[3].Value = patient.vaccines_date[i];
                dataGridVaccine.Rows[i].Cells[4].Value = patient.vaccines_doctor[i];
            }

        }

        private void dataGridVaccine_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!_patients.ContainsKey(search.Text))
            {
                return;
            }

            _patients[search.Text].vaccines_type.Clear();
            _patients[search.Text].vaccines_lot.Clear();
            _patients[search.Text].vaccines_date.Clear();
            _patients[search.Text].vaccines_doctor.Clear();

            for (int i = 0; i < dataGridVaccine.Rows.Count; i++)
            {
                if (search.Text == "") return;
                // Update the local variables.
                if (dataGridVaccine.Rows[i].Cells[1].Value != null) _patients[search.Text].vaccines_type.Add(dataGridVaccine.Rows[i].Cells[1].Value.ToString());
                if (dataGridVaccine.Rows[i].Cells[2].Value != null) _patients[search.Text].vaccines_lot.Add(dataGridVaccine.Rows[i].Cells[2].Value.ToString());
                if (dataGridVaccine.Rows[i].Cells[3].Value != null) _patients[search.Text].vaccines_date.Add(dataGridVaccine.Rows[i].Cells[3].Value.ToString());
                if (dataGridVaccine.Rows[i].Cells[4].Value != null) _patients[search.Text].vaccines_doctor.Add(dataGridVaccine.Rows[i].Cells[4].Value.ToString());

            }

            Database.setVaccines(_patients[search.Text]);

            infoInit(_patients[search.Text]);
            vacInit(_patients[search.Text]);
            return;


        }

        private void profile_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_display, new Staff_Profile(_display, _staff));
        }
    }
}
