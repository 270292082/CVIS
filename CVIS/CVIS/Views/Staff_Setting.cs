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
            lastname_input.Text = staff.lastName;
            role_input.Text = staff.rolePermission;
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
    }
}
