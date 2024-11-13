using System.Collections.Immutable;
using System.Diagnostics;
using SysFunc;

namespace users
{
    public class Data {
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Staff> Staffs { get; set; } = new List<Staff>();
        public List<Mod> Mods { get; set; } = new List<Mod>();
        public List<Admin> Admins { get; set; } = new List<Admin>();

   }

   public class Patient
   {
        // ! Permission breach !
        //   Needs of fixing, but I don't know yet how to switch them to private without breaking the code
        //   (public functions amongst the Patient class don't have the permission to read for some reasons.)
        public string ID = string.Empty;
        public string username = string.Empty;
        public string password = string.Empty;
        public string firstName = string.Empty;
        public string lastName = string.Empty;
        public string DOB = string.Empty;
        public string gender = string.Empty;
        public string phone = string.Empty;
        public string email = string.Empty;
        public string address = string.Empty;
        public List<string> vaccines_date = new List<string>();
        public List<string> vaccines_type = new List<string>();
        public List<string> vaccines_lot = new List<string>();
        public List<string> vaccines_doctor = new List<string>();
        public string emergencyContactFirstName = string.Empty;
        public string emergencyContactLastName = string.Empty;
        public string emergencyContactPhone = string.Empty;
        public string emergencyContactRelation = string.Empty;


        public void dataToClass(Dictionary<string,string> data)
        {
            // Init basics information.
            ID = data["ID"];
            username = data["username"];
            password = data["password"];
            firstName = data["firstName"];
            lastName = data["lastName"];
            DOB = data["DOB"];
            gender = data["gender"];
            phone = data["phone"];
            email = data["email"];
            address = data["address"];


            // Init Vaccines informatinos.
            Dictionary<string, Dictionary<string, string>> vaccines = Database.getPatientVaccines(ID);
            foreach (var nb in vaccines.Keys)
            {
                vaccines_date.Add(vaccines[nb]["date"]);
                vaccines_type.Add(vaccines[nb]["type"]);
                vaccines_lot.Add(vaccines[nb]["lot"]);
                vaccines_doctor.Add(vaccines[nb]["doctor"]);
            }
            

            //// Init Emergency Contacts information.
            Dictionary<string, string> emergency = Database.getPatientEmergencyContact(ID);
            emergencyContactFirstName = emergency["firstName"];
            emergencyContactLastName = emergency["lastName"];
            emergencyContactPhone = emergency["phone"];
            emergencyContactRelation = emergency["relation"];

        } 

        public List<string> getVaccines(int permission)
        {
            if (permission > 3) { return new List<string> { "ERR-403" }; }
            return vaccines_date;
        }

        public string getStatus(int permission)
        {
            if (permission > 3)
            {
                Console.WriteLine("Error : Access Denied.");
                return "";
            }
            if (vaccines_date.Count == 0 ) { return "Non-Vaccinated"; }
            if (vaccines_date.Count == 1 ) { return "Partially"; }
            if (vaccines_date.Count == 2 ) { return "Vaccinated"; }
            return "";
        }
        public async Task<string> getStatusQR()
        {
            try
            {
                string msg = string.Empty;
                msg += firstName + "_" + lastName + "-";
                foreach (string v in vaccines_date )
                {
                    msg += v + "_";
                }
                msg += "-";

                // Specifies the message we want on the QR code.
                if (vaccines_date.Count == 0) { msg += "Non-Vaccinated"; }
                if (vaccines_date.Count == 1) { msg += "Partially"; }
                if (vaccines_date.Count == 2) { msg += "Vaccinated"; }

                string qrcode = await QR.Gen(msg);


                if (qrcode[0] != '█') return "";
                return qrcode;

            }
            catch (Exception error) 
            {
                Debug.WriteLine($"\n!!! Error : Couldn't get the status !!! :\n{error}\n");
                return "";
            }
        }

         
   }

    public class Staff
    {
        public string ID { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string position { get; set; } = string.Empty;
        public string hospitalDepartment { get; set; } = string.Empty;
        public string medicalLicense { get; set; } = string.Empty;
        public string licenseExp { get; set; } = string.Empty;
        public string specialization { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string rolePermission { get; set; } = string.Empty;


        public static Staff dataToClass(Dictionary<string,string> data)
        {

            // THIS FUNCTION IS NOT FINISHED YET!
            // DO NOT CALL IT!
            // or fix it before


            Staff staff = new Staff();

            // Init basics information.
            staff.ID = data["ID"];
            staff.username = data["username"];
            staff.password = data["password"];
            staff.firstName = data["firstName"];
            staff.lastName = data["lastName"];
            staff.email = data["email"];
            staff.position = data["position"];
            staff.hospitalDepartment = data["hospitalDepartment"];


            // Init advanced information.
            Dictionary<string, string> adv_info = Database.getStaffInfo(staff.ID);
            staff.medicalLicense = adv_info["medicalLicense"];
            staff.licenseExp = adv_info["licenseExp"];
            staff.specialization = adv_info["specialization"];
            staff.phone = adv_info["phone"];
            staff.address = adv_info["address"];
            staff.rolePermission = adv_info["rolePermission"];


            return staff;

        } 

    }

    public class Mod
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public string ID { get; set; } = string.Empty;
        private int Phone { get; set; } = 0;
        private string Email { get; set; } = string.Empty;
    }
    public class Admin
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public string ID { get; set; } = string.Empty;
        private int Phone { get; set; } = 0;
        private string Email { get; set; } = string.Empty;
    }
}