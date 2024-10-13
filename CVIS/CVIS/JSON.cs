﻿
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http;

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
        private int Phone { get; set; } = 0;
        private string Email { get; set; } = string.Empty;
        private List<string> vaccines { get; set; } = new List<string>();


        public List<string> getVaccines(int permission)
        {
            if (permission <= 3) { return vaccines; }
            return new List<string> { "ERR-403" };
        }

        public string getStatus(int permission)
        {
            if (permission <= 3)
            {
                System.Diagnostics.Debug.WriteLine(vaccines.Count);
                if (vaccines.Count == 0 ) { return "Non-Vaccinated"; }
                if (vaccines.Count == 1 ) { return "Partially"; }
                if (vaccines.Count == 2 ) { return "Vaccinated"; }
            }
            return "";
        }
        public async Task<string> getStatusQR(int permission)
        {
            if (permission > 3)
            {
                Console.WriteLine("Error : Access Denied.");
                return "";
            }

            // Launch a client ready for interaction with qr gen website.
            HttpClient client = new HttpClient(); 
            string url = "https://qrcode.show/";


            // Specifies the message we want on the QR code.
            if (vaccines.Count == 0) { url += "Non-Vaccinated"; }
            if (vaccines.Count == 1 ) { url += "Partially"; }
            if (vaccines.Count == 2 ) { url += "Vaccinated"; }


            HttpResponseMessage response = await client.GetAsync(url); // Launch the get request on the website.

            if (response.IsSuccessStatusCode)
            {
                string qrcode = await response.Content.ReadAsStringAsync(); // Convert the response into string.
                return qrcode;
            }
            else
            {
                Console.WriteLine($"Error : Couldn't load the QR code ({response.StatusCode})");
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