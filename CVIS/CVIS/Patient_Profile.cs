using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SysFunc;

namespace CVIS
{
    public partial class Patient_Profile : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private main _main;
        public Patient_Profile(main Main, JSON.Patient patient)
        {
            InitializeComponent();
            _main = Main;

            patient_ID_text.Text = patient.ID.ToString();
            name_text.Text = patient.FirstName + " " + patient.LastName;
        }

        private void profile_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Profile_Load(object sender, EventArgs e)
        {
        }
    }
}
