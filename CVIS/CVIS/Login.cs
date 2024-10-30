using System.Diagnostics;
using System.Text.Json;

using SysFunc;

namespace CVIS
{
    public partial class Login : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private Panel _display;
        public Login(Panel display)
        {
            InitializeComponent();
            _display = display;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var dataset = Sys.readJSON("data");
            if (username_input.Text.Length <= 0 && password_input.Text.Length <= 0)
            {
                return;
            }

            foreach (var patient in dataset.Patients)
            {
                if (username_input.Text == patient.username && password_input.Text == patient.passwd)
                {
                    Sys.loadPage(_display, new Patient_Main(_display, patient));
                }
            }

            foreach (var staff in dataset.Staffs)
            {
                if (username_input.Text == staff.username && password_input.Text == staff.passwd)
                {
                    Sys.loadPage(_display, new Staff_Main(_display, staff));
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
