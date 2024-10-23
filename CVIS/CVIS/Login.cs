using System.Diagnostics;
using System.Text.Json;

using SysFunc;

namespace CVIS
{
    public partial class Login : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private main _main;
        public Login(main Main)
        {
            InitializeComponent();
            _main = Main;
        }

        private void username_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_input_TextChanged(object sender, EventArgs e)
        {

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
                    Sys.loadPage(_main.Display, new Patient_Main(_main, patient));
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
