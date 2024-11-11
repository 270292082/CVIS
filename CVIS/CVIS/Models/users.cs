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
        public string ID { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string gender { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public List<string> vaccines_date { get; set; } = new List<string>();
        public List<string> vaccines_type { get; set; } = new List<string>();
        public List<string> vaccines_lot { get; set; } = new List<string>();
        public List<string> vaccines_doctor { get; set; } = new List<string>();
        public string emergencyContactFirstName { get; set; } = string.Empty;
        public string emergencyContactLastName { get; set; } = string.Empty;
        public string emergencyContactPhone { get; set; } = string.Empty;
        public string emergencyContactRelation { get; set; } = string.Empty;


        public static Patient dataToClass(Dictionary<string,string> data)
        {
            Patient patient = new Patient();

            // Init basics information.
            patient.ID = data["ID"];
            patient.username = data["username"];
            patient.password = data["password"];
            patient.firstName = data["firstName"];
            patient.lastName = data["lastName"];
            patient.DOB = data["DOB"];
            patient.gender = data["gender"];
            patient.phone = data["phone"];
            patient.email = data["email"];
            patient.address = data["address"];


            // Init Vaccines informatinos.
            Dictionary<string, Dictionary<string, string>> vaccines = Database.getPatientVaccines(patient.ID);
            foreach (var nb in vaccines.Keys)
            {
                patient.vaccines_date.Add(vaccines[nb]["date"]);
                patient.vaccines_type.Add(vaccines[nb]["type"]);
                patient.vaccines_lot.Add(vaccines[nb]["lot"]);
                patient.vaccines_doctor.Add(vaccines[nb]["doctor"]);
            }
            

            //// Init Emergency Contacts information.
            Dictionary<string, Dictionary<string, string>> emergencies = Database.getPatientEmergencyContact(patient.ID);
            patient.emergencyContactFirstName = emergencies[patient.ID]["firstName"];
            patient.emergencyContactLastName = emergencies[patient.ID]["lastName"];
            patient.emergencyContactPhone = emergencies[patient.ID]["phone"];
            patient.emergencyContactRelation = emergencies[patient.ID]["relation"];

            return patient;

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
        public string username { get; set; } = string.Empty;
        public string passwd { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public string ID { get; set; } = string.Empty;
        public int Phone { get; set; } = 0;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;

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