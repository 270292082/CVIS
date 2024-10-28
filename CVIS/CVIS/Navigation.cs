using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SysFunc;

namespace CVIS
{
    public partial class Navigation : Form
    {
        private Panel _display_nav;

        public Navigation(Panel display_nav)
        {
            InitializeComponent();
            _display_nav= display_nav;
        }

        private void Navigation_Load(object sender, EventArgs e)
        {
        }

        private void logo_button_Click(object sender, EventArgs e)
        {
            Sys.toggleNav(_display_nav, 0);
        }
    }
}
