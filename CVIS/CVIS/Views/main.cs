/*  
 * To Do:
 *  Fix the class "DATABASE" in sysfunc.cs
 *      connecting to the database
 *      sending queries
 *      treating the outputs
 *  
 *  Progressing on the UI of the Staff/Mods/Admins
 *      adding a main page (for Mods and Admins)
 *      adding a profile page
 *      adding a settings page
 *      
 */


using System.Reflection.PortableExecutable;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SysFunc;

namespace CVIS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            Sys.loadPage(display, new Login(display));
            Debug.WriteLine("Launching query...");
            Database.getPatients();
        }

        
        private void display_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}