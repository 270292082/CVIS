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
    public partial class Staff_Main : Form
    {
        private Panel _display;
        public Staff_Main(Panel display, JSON.Staff staff)
        {
            InitializeComponent();
            _display= display;

            welcome_text.Text = "Welcome, ";
            welcome_text.Text += staff.FirstName + " ";
            welcome_text.Text += staff.LastName + "!";
        }
    }
}
