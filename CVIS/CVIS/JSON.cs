using System.Diagnostics;
using SysFunc;

namespace JSON
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
        public string username { get; set; } = string.Empty;
        public string passwd { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; } = 0;
        public string Gender { get; set; } = string.Empty;
        public int ID { get; set; } = 0;
        public int Phone { get; set; } = 0;
        public string Email { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public List<string> vaccines { get; set; } = new List<string>();
        public List<string> vaccines_type { get; set; } = new List<string>();
        public List<string> vaccines_lot { get; set; } = new List<string>();
        public List<string> vaccines_doctor { get; set; } = new List<string>();
        public string EmergencyContactName { get; set; } = string.Empty;
        public int EmergencyContactPhone { get; set; } = 0;
        public string EmergencyContactRelation { get; set; } = string.Empty;


        public List<string> getVaccines(int permission)
        {
            if (permission > 3) { return new List<string> { "ERR-403" }; }
            return vaccines;
        }

        public string getStatus(int permission)
        {
            if (permission > 3)
            {
                Console.WriteLine("Error : Access Denied.");
                return "";
            }
            if (vaccines.Count == 0 ) { return "Non-Vaccinated"; }
            if (vaccines.Count == 1 ) { return "Partially"; }
            if (vaccines.Count == 2 ) { return "Vaccinated"; }
            return "";
        }
        public string getStatusQR(int permission)
        {
            if (permission > 3)
            {
                Debug.WriteLine("Error : Access Denied.");
                return "";
            }

            try
            {
                string msg = string.Empty;
                msg += FirstName + "_" + LastName + "-";
                foreach (string v in vaccines )
                {
                    msg += v + "_";
                }
                msg += "-";

                // Specifies the message we want on the QR code.
                if (vaccines.Count == 0) { msg += "Non-Vaccinated"; }
                if (vaccines.Count == 1) { msg += "Partially"; }
                if (vaccines.Count == 2) { msg += "Vaccinated"; }

                string qrcode = QR.Gen(msg).Result;


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
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private int Phone { get; set; } = 0;
        private string Email { get; set; } = string.Empty;
    }

    public class Mod
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private int Phone { get; set; } = 0;
        private string Email { get; set; } = string.Empty;
    }
    public class Admin
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private int Phone { get; set; } = 0;
        private string Email { get; set; } = string.Empty;
    }
}