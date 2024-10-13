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

using JSON;

namespace funcPatient
{
    public class Patient
    {
        public static List<string> getVaccines(string patient, int permission)
        {
            List<string> vaccines = new List<string>();

            if (!File.Exists(".data")) { return vaccines; }

            var data = JsonSerializer.Deserialize<Data>(File.ReadAllText(".data"));
           
            if (data == null ) { return vaccines; }

            foreach ( var p in data.Patients ) 
            {

                vaccines = p.getVaccines(permission);
            }
            return vaccines;
        }

        public static string getStat()
        {
            string result = string.Empty;
            
            return result;
        }

    }
}