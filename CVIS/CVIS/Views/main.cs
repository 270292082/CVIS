/*  
 * Classes to implement:
 *  
 *   Patient;
 *       name
 *       last_name
 *       id
 *       phone
 *       email
 *       vaccine_status
 *      
 *   Staff;
 *       name
 *       last_name
 *       id
 *       phone
 *       email
 *  
 *   Mod;
 *       name
 *       last_name
 *       id
 *       phone
 *       email
 *      
 *   Admin;
 *       name
 *       last_name
 *       id
 *       phone
 *       email
 *      
 *  
 * Functions to implement:
 *  
 *  
 *  
 *   getStaffInfo() ; No input and output an list of strings.
 *   getStaffReports() ; No input and output a list of "report" object.
 *   setStaffInfo(var dict) ; Receive a dictionary as input and redefine the dataset with it.
 *   setStaffReports(var list) ; Receive a list of "report" object and redefine the dataset with it.
 *  
 *  
 *   getModInfo() ; No input and output an list of strings.
 *   setModInfo(var dict) ; Receive a dictionary as input and redefine the dataset with this list.
 *  
 *  
 *   getAdminInfo() ; No input and output an list of strings.
 *   setAdminInfo(var dict) ; Receive a dictionary as input and redefine the dataset with this list.
 *  
 *  
 *   access_control() ; Launch the users' access control if logged as admin.
 *   system_update() ; Launch an update of the system if logged as admin.
 *   monitor_system() ; Launch the system monitor if logged as admin.
 *   backup_dataset() ; Make a backup of the dataset if logged as admin.
 *  
 *  
 *   report_issue() ; Launch the issue report page.
 *   reset_passwd() ; Launch the password reset page for the logged user.
 *  
 *  
 *   login(string username, string passwd) ; Check if the credentials are into the dataset.
 *   register() ; Launch the register page for the user to input it's information.
 *   logout() ; Log out the logged user.
 */


using PatientFunc;
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
            // string qrcode_content = Task.Run(async () => PatientFunc.PatientFunc.getStatusQR(654321, 0)).Result;
            Sys.loadPage(display, new Login(display)); 
        }

        
        private void display_Paint(object sender, PaintEventArgs e)
        {

        }

        public Panel Display => display;

    }
}