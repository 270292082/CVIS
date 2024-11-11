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

            //Debug.WriteLine(Database.getPatientVaccines("654321"));

            var PATIENTS = Database.getPatients();
            if (username_input.Text.Length <= 0 && password_input.Text.Length <= 0)
            {
                return;
            }

            foreach (var p in PATIENTS.Keys)
            {
                if (username_input.Text == PATIENTS[p]["username"] && password_input.Text == PATIENTS[p]["password"])
                {
                    Sys.loadPage(_page_display, new Patient_Main(_page_display, Patient.dataToClass(PATIENTS[p])));
                }
            }

            var STAFFS = Database.getStaffs();
            foreach (var staff in STAFFS)
            {

            }

        }

    }
}
