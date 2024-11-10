using System.Diagnostics;
using SysFunc;

namespace users
{
   public class Patient
   {
        public string ID { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public string DOB { get; set; } = string.Empty;
        public string gender { get; set; } = string.Empty;
        public int phone { get; set; } = 0;
        public string email { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public List<string> vaccines { get; set; } = new List<string>();
        public List<string> vaccines_type { get; set; } = new List<string>();
        public List<string> vaccines_lot { get; set; } = new List<string>();
        public List<string> vaccines_doctor { get; set; } = new List<string>();
        public string emergencyContactFirstName { get; set; } = string.Empty;
        public string emergencyContactLastName { get; set; } = string.Empty;
        public int emergencyContactPhone { get; set; } = 0;
        public string emergencyContactRelation { get; set; } = string.Empty;

   }

    public class Staff
    {
        public string ID { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public int age { get; set; } = 0;
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