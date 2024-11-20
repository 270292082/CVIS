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

namespace CVIS.Views
{
    public partial class Staff_Setting : Form
    {
        private Panel _page_display;
        private Staff _staff;

        public Staff_Setting(Panel page_display, Staff staff)
        {
            InitializeComponent();
            _page_display = page_display;
            _staff = staff;

            username_input.Text = staff.username;
            password_input.Text = staff.password;

            firstname_input.Text = staff.firstName;
            lastname_input.Text = staff.lastName;
            role_input.Text = staff.rolePermission;
            email_input.Text = staff.email;
            address_input.Text = staff.address;
            phone_input.Text = staff.phone;

            medlicense_input.Text = staff.medicalLicense;
            licenseexp_input.Text = staff.licenseExp;

            // read only fields
            firstname_input.ReadOnly = true;
            lastname_input.ReadOnly = true;
            role_input.ReadOnly = true;

            // tab skip
            firstname_input.TabStop = false;
            lastname_input.TabStop = false;
            role_input.TabStop = false;

            // to set the navigation panel position and size

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            // navigation
        }

        private void logo_Click(object sender, EventArgs e)
        {
            // staff home page
        }

        private void profile_button_Click(object sender, EventArgs e)
        {

        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            // not to leave blank
            if (string.IsNullOrWhiteSpace(username_input.Text) ||
                string.IsNullOrWhiteSpace(password_input.Text) ||
                string.IsNullOrWhiteSpace(firstname_input.Text) ||
                string.IsNullOrWhiteSpace(lastname_input.Text) ||
                string.IsNullOrWhiteSpace(role_input.Text) ||
                string.IsNullOrWhiteSpace(email_input.Text) ||
                string.IsNullOrWhiteSpace(address_input.Text) ||
                string.IsNullOrWhiteSpace(phone_input.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop further execution
            }

            if (string.IsNullOrWhiteSpace(medlicense_input.Text) ||
                string.IsNullOrWhiteSpace(licenseexp_input.Text))
            {
                MessageBox.Show("Medical license and license expiry date are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Staff updateStaff = new Staff
            {
                ID = _staff.ID,
                username = username_input.Text,
                password = password_input.Text,

                email = email_input.Text,
                phone = phone_input.Text,
                address = address_input.Text,

                medicalLicense = medlicense_input.Text,
                licenseExp = licenseexp_input.Text
            };

            // database update function
            Database.UpdateStaffInDatabase(updateStaff);
        }
    }
}
