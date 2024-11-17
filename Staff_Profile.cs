using SysFunc;
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

namespace CVIS
{
    public partial class Staff_Profile : Form
    {
        private Panel _page_display;
        private Staff _staff;
        public Staff_Profile(Panel page_display, Staff staff)
        {
            InitializeComponent();
            _page_display = page_display;
            _staff = staff;

            string info_msg = string.Empty;
            info_msg += "Medical License : " + staff.medicalLicense + "\n\n";
            info_msg += "License Exp Date : " + staff.licenseExp + "\n\n";
            info_msg += "Specialization : " + staff.specialization + "\n\n";
            info_msg += "Email Address : " + staff.email + "\n\n";
            info_msg += "Mobile Number : " + staff.phone + "\n\n";
            info_msg += "Address : " + staff.address + "\n\n";
            info_msg += "Role Permission : " + staff.rolePermission + "\n\n";

            admin_ID_text.Text = "Admin ID : " + staff.ID;
            name_text.Text = "Name : " + staff.firstName + " " + staff.lastName;
            position_text.Text = "Position : " + staff.position;
            hosdept_text.Text = "Hospital / Department : " + staff.hospitalDepartment;
            info_text.Text = info_msg;
        }

        private void logo_button_Click(object sender, EventArgs e)
        {
            Sys.loadPage(_page_display, new Staff_Main(_page_display, _staff));
        }

        private void menu_button_Click(object sender, EventArgs e)
        {
            // navigation
        }
    }
}
