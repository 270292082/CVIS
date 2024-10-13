
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

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
        private string username { get; set; } = string.Empty;
        private string passwd { get; set; } = string.Empty;
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private string Phone { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
        private List<string> vaccines { get; set; } = new List<string>();

        public List<string> getVaccines(int permission)
        {
            if (permission <= 3) { return vaccines; }
            return new List<string>();
        }
 
    }

    public class Staff
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private string Phone { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
    }

    public class Mod
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private string Phone { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
    }
    public class Admin
    {
        private string FirstName { get; set; } = string.Empty;
        private string LastName { get; set; } = string.Empty;
        private int Age { get; set; } = 0;
        public int ID { get; set; } = 0;
        private string Phone { get; set; } = string.Empty;
        private string Email { get; set; } = string.Empty;
    }
}