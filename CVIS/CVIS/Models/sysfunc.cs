using System.Timers;
using System.Text.Json;
using System.Diagnostics;

using CVIS;
using users;

using Microsoft.Data.Sqlite;
using System.Security;

namespace SysFunc {

    public class QR
    {
        public static async Task<String> Gen(string msg)
        {
            // Launch a client ready for interaction with QR gen website.
            using (var client = new HttpClient())
            {
                try
                {
                    string url = "https://qrcode.show/" + msg;
                    HttpResponseMessage response = await client.GetAsync(url); // Launch the get request on the website.
                    string qrcode = await response.Content.ReadAsStringAsync(); // Convert the response into string.
                    return qrcode;
                }
                catch (Exception error)
                {
                    Debug.WriteLine($"\n!!! Error : Couldn't load the QR code !!! :\n{error}\n");
                    return "";
                }
            }
        }
    }

    public class Database
    {
        public static Dictionary<string, Dictionary<string, string>> sendQuery(string query, string key="ID")
        {
            Dictionary<string, Dictionary<string, string>> result = new Dictionary<string, Dictionary<string, string>>();

            string connectionString = "Data Source=CVIS-DATABASE.db";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                
                var command = connection.CreateCommand();
                command.CommandText = query;

                using (var output = command.ExecuteReader())
                {

                    while (output.Read())
                    {

                        Dictionary<string, string> infos = new Dictionary<string, string>();

                        for (int i = 0; i < output.FieldCount; i++)
                        {
                            infos.Add(output.GetName(i), output.GetString(i));
                        }

                        // Store the infos in the dictionary with the ID of the users as a key for it's info.
                        result.Add(infos[key], infos);
                    }

                }

            }

            return result;

        }

        public static Dictionary<string, Dictionary<string, string>> getPatients()
        {
            // This functions gets every patients informations and their vaccines.
            Dictionary<string, Dictionary<string, string>> PATIENTS = new Dictionary<string, Dictionary<string, string>>();

            // Some code here to get request from SQL database.
            string query = "SELECT * FROM Patients";
            PATIENTS = sendQuery(query);

            return PATIENTS;

        }

        public static Dictionary<string, Dictionary<string, string>> getPatientVaccines(string ID) 
        {
            Dictionary<string, Dictionary<string, string>> VACCINES = new Dictionary<string, Dictionary<string, string>>();
            string query = "SELECT * FROM Patients_Vaccines as PB WHERE PB.patient_ID == \"" + ID + "\";";

            VACCINES = sendQuery(query, "date");

            return VACCINES;
            
        }

        public static Dictionary<string, string> getPatientEmergencyContact(string ID) 
        {
            Dictionary<string, Dictionary<string, string>> emergency = new Dictionary<string, Dictionary<string, string>>();
            string query = "SELECT * FROM Patients_Emergency_Contacts as PB WHERE PB.patient_ID == \"" + ID + "\";";

            emergency = sendQuery(query, "patient_ID");

            return emergency[ID];
            
        }

        public static Dictionary<string, Dictionary<string, string>> getStaffs()
        {
            Dictionary<string, Dictionary<string, string>> STAFFS = new Dictionary<string, Dictionary<string, string>>();

            // Some code here to get request from SQL database.
            string query = "SELECT * FROM Staffs";
            STAFFS = sendQuery(query);



            return STAFFS;

        }

        public static Dictionary<string, string> getStaffInfo(string ID)
        {
            Dictionary<string, Dictionary<string, string>> info = new Dictionary<string, Dictionary<string, string>>();

            string query = "SELECT * FROM Staffs_Info WHERE ID == \"" + ID + "\";";
            info = sendQuery(query);

            return info[ID];
        }

        public static Dictionary<string, Dictionary<string, string>> getUsers()
        {
            Dictionary<string, Dictionary<string, string>> USERS = new Dictionary<string, Dictionary<string,string>>();

            // Request for Patients.
            string query = "SELECT * FROM Patients";
            USERS = sendQuery(query);


            return USERS;



        }
        

    }

    public class Sys
    {

        private static System.Timers.Timer _timer;

        public static void toggleNav(Panel display, int active=2)
        {
            if (active == 2)
            {
                if (display.Location.X == -251 ) { showNav(display); }
                else { hideNav(display); }
            }
            if (active == 1) { showNav(display); }
            else if (active == 0) { hideNav(display); }
        }

        private static void showNav(Panel display)
        {
            if (display.Location.X == 0) return;

            // Clear the content of the timer.
            _timer = new System.Timers.Timer(10);

            // Set the timer actions.
            _timer.AutoReset = true; 
            _timer.Elapsed -= async (sender, e) => navTick(sender, e, display, 0);
            _timer.Elapsed += async (sender, e) => await navTick(sender, e, display, 1);
            _timer.Enabled = true;
            _timer.Start();
        }

        private static void hideNav(Panel display)
        {
            if (display.Location.X == -251) return;

            // Clear the content of the timer.
            _timer = new System.Timers.Timer(10);

            // Set the timer actions.
            _timer.AutoReset = true;
            _timer.Elapsed -= async (sender, e) => navTick(sender, e, display, 1);
            _timer.Elapsed += async (sender, e) => navTick(sender, e, display, 0);
            _timer.Enabled = true;
            _timer.Start();
        }

        private async static Task navTick(Object source, ElapsedEventArgs e, Panel display, int show)
        {
            int step = 10;

            if (show == 1)
            {

                // Animation for showing the navigation.
                if (display.Location.X >= -10) { display.Invoke(new Action(() => { display.Location = new Point(-10, 0); })); _timer.Stop(); }
                display.Invoke(new Action(() => { display.Location = new Point(display.Location.X + step, 0); }));
            }
            else if (show == 0)
            {
                // Animation for hiding the navigation.
                if (display.Location.X <= -251) { display.Invoke(new Action(() => { display.Location = new Point(-251, 0); }));  _timer.Stop(); }
                display.Invoke(new Action(() => { display.Location = new Point(display.Location.X - step, 0); }));

            }
        }

        public static void loadPage(Panel display, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            display.Controls.Clear();
            display.Controls.Add(form);
            form.Show();
        }

    }
}