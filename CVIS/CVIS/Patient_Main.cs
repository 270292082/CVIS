using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVIS
{
    public partial class Patient_Main : Form
    {
        // This variable is defined in order to interract with the component of main, in this case we want to interact with it's display to change pages.
        private main _main;
        public Patient_Main(main Main, JSON.Patient patient) {
            InitializeComponent();
            _main = Main;
        }

        private void banner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Patient_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
