/*  
 * Classes to implement:
 *  
 *   Patient;
 *     - name
 *     - last_name
 *     - id
 *     - phone
 *     - email
 *     - vaccine_status
 *
 *     + getName()
 *     + getLastName()
 *     + getID()
 *     + getPhone()
 *     + getEmail()
 *     + getVaccineStat()
 *      
 *   Staff;
 *     - name
 *     - last_name
 *     - id
 *     - phone
 *     - email
 *
 *     + getName()
 *     + getLastName()
 *     + getID()
 *     + getPhone()
 *     + getEmail()
 *  
 *   Mod;
 *     - name
 *     - last_name
 *     - id
 *     - phone
 *     - email
 *
 *     + getName()
 *     + getLastName()
 *     + getID()
 *     + getPhone()
 *     + getEmail()
 *      
 *   Admin;
 *     - name
 *     - last_name
 *     - id
 *     - phone
 *     - email
 *
 *     + getName()
 *     + getLastName()
 *     + getID()
 *     + getPhone()
 *     + getEmail()
 *
 *     + access_control() ; Launch the users' access control if logged as admin.
 *     + system_update() ; Launch an update of the system if logged as admin.
 *     + monitor_system() ; Launch the system monitor if logged as admin.
 *     + backup_dataset() ; Make a backup of the dataset if logged as admin.
 *      
 *  
 * Functions to implement:
 *  
 *   getPatientVaccines() ; No input and output an list of strings (date).
 *   getPatientStat() ; No input and output the status of the patient in a string.
 *   getPatientStatQR() ; No input and output the status of the patient in a QR code.
 *   getPatientInfo() ; No input and output a dictionary of strings.
 *   setPatientVaccines(var list) ; Receive a list of strings (date) as input and redefine the dataset with this list.
 *   setPatientStat(string stat) ; Receive a string (status of patient regarding the vaccination) and redefine the dataset with this string.
 *   setPatientInfo(var dict) ; Receive a dictionary as input and redefine the dataset with this dictionary.
 *  
 *  
 *   getStaffInfo() ; No input and output an dictionary of strings.
 *   getStaffReports() ; No input and output a list of "report" object.
 *   setStaffInfo(var dict) ; Receive a dictionary as input and redefine the dataset with it.
 *   setStaffReports(var list) ; Receive a list of "report" object and redefine the dataset with it.
 *  
 *  
 *   getModInfo() ; No input and output a dictionary of strings.
 *   setModInfo(var dict) ; Receive a dictionary as input and redefine the dataset with this list.
 *  
 *  
 *   getAdminInfo() ; No input and output a dictionary of strings.
 *   setAdminInfo(var dict) ; Receive a dictionary as input and redefine the dataset with this list.
 *  
 * 
 *  
 *   report_issue() ; Launch the issue report page.
 *   reset_passwd() ; Launch the password reset page for the logged user.
 *  
 *  
 *   login() ; Launch the login page.
 *   register() ; Launch the register page for the user to input it's information.
 *   logout() ; Log out the logged user.
 */



namespace CVIS
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
