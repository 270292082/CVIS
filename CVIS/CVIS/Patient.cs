/*
 *   getPatientStat(); No input and output the status of the patient in a string.
 *   getPatientStatQR() ; No input and output the status of the patient in a QR code.
 *   getPatientInfo() ; No input and output a list of strings.
 *   setPatientVaccines(var list) ; Receive a list of strings (date) as input and redefine the dataset with this list.
 *   setPatientStat(string stat) ; Receive a string (status of patient regarding the vaccination) and redefine the dataset with this string.
 *   setPatientInfo(var dict) ; Receive a dictionary as input and redefine the dataset with this list.
*/

using System.Net.NetworkInformation;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;

using JSON;

namespace funcPatient
{
    public class Patient
    {
        public static List<string> getVaccines(int patient, int permission)
        {
            List<string> vaccines = new List<string>();

            if (!File.Exists("data")) { return vaccines; } // Couldn't open the dataset, because doesn't exist.

            var data = JsonSerializer.Deserialize<Data>(File.ReadAllText("data"));
            if (data == null ) { return vaccines; } // Couldn't open the dataset, permission issues or used by another process.
            
            foreach ( var p in data.Patients ) 
            {
                
                if (p.ID == patient) // Check if the iteration patient matches with the target.
                {
                    vaccines = p.getVaccines(permission);
                    return vaccines;
                }
            }
            Debug.WriteLine("Error: The patient wasn't found in the dataset!");
            return vaccines;
        }

        public static string getStatus(int patient, int permission)
        {
            string result = string.Empty;

            if (!File.Exists("data")) { return result; } // Couldn't open the dataset, because doesn't exist.

            var data = JsonSerializer.Deserialize<Data>(File.ReadAllText("data"));
            if (data == null ) { return result; } // Couldn't open the dataset, permission issues or used by another process.

            foreach ( var p in data.Patients ) 
            {
                
                if (p.ID == patient) // Check if the iteration patient matches with the target.
                {
                    result = p.getStatus(permission);
                    return result;
                }
            }

            Debug.WriteLine("Error: The patient wasn't found in the dataset!");
            return result;
        }
        public static string getStatusQR(int patient, int permission)
        {
            string result = string.Empty;
            
            if (!File.Exists("data")) { return result; } // Couldn't open the dataset, because doesn't exist.

            var data = JsonSerializer.Deserialize<Data>(File.ReadAllText("data"));
            if (data == null ) { return result; } // Couldn't open the dataset, permission issues or used by another process.

            foreach ( var p in data.Patients ) 
            {
                if (p.ID == patient) // Check if the iteration patient matches with the target.
                {
                    result = p.getStatusQR(permission).Result;
                    return result;
                }
            }

            Debug.WriteLine("Error: The patient wasn't found in the dataset!");
            return result;
        }


    }
}