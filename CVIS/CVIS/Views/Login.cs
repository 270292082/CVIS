using System.Diagnostics;
using System.Text.Json;

using SysFunc;
using users;

namespace CVIS
{
    public partial class Login : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private Panel _page_display;
        public Login(Panel page_display)  
        {
            InitializeComponent();
            _page_display = page_display;
        }

        private void login_button_Click(object sender, EventArgs e)
        {

            if (username_input.Text.Length <= 0 && password_input.Text.Length <= 0)
            {
                return;
            }

            Dictionary<string, Patient> Patients = Database.getPatients();
            foreach (var patient in Patients.Values)
            {
                if (username_input.Text == patient.username && password_input.Text == patient.password)
                {
                    Sys.loadPage(_page_display, new Patient_Main(_page_display, patient));
                }
            }

            var STAFFS = Database.getStaffs();
            foreach (var s in STAFFS.Keys)
            {
                if (username_input.Text == STAFFS[s]["username"] && password_input.Text == STAFFS[s]["password"])
                {
                    Sys.loadPage(_page_display, new Staff_Main(_page_display, Staff.dataToClass(STAFFS[s])));
                }
            }

        }

    }
}
