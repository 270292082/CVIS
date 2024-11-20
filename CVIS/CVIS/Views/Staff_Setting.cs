using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SysFunc;
using users;

namespace CVIS.Views
{
    public partial class Staff_Setting : Form
    {
        private Panel _display;
        private Staff _staff;
        public Staff_Setting(Panel display, Staff staff)
        {
            InitializeComponent();
            _display = display;
            _staff = staff;

            // Set the position and size for the navigation panel.
            display_nav.Size = new Size(251, 361);
            display_nav.Location = new Point(-251, 0);
            display_nav.Visible = true;
            Sys.loadPage(display_nav, new Navigation_Staff(_display, display_nav, staff));
            display_nav.BringToFront();

            username_input.Text = staff.username;
            password_input.Text = staff.password;

            firstname_input.Text = staff.firstName;
            firstname_input.ReadOnly = true;
            lastname_input.Text = staff.lastName;
            lastname_input.ReadOnly = true;
            role_input.Text = staff.rolePermission;
            role_input.ReadOnly = true;
            email_input.Text = staff.email;
            address_input.Text = staff.address;
            phone_input.Text = staff.phone;

            medlicense_input.Text = staff.medicalLicense;
            licenseexp_input.Text = staff.licenseExp;

        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_display, new Staff_Profile(_display, _staff));
        }

        private void logo_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_display, new Staff_Main(_display, _staff));
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(display_nav, 1);
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
