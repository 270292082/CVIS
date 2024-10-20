using System.Text.Json;
using System.Diagnostics;

using JSON;

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
    public class Sys
    {
        public static void loadPage(Panel display, Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            display.Controls.Clear();
            display.Controls.Add(form);
            form.Show();
        }

        public static JSON.Data readJSON(string data) {

            if (!File.Exists(data)) { Debug.WriteLine("! ERROR ! : The file doesn't exist!");  return new JSON.Data(); }
            var result = JsonSerializer.Deserialize<Data>(File.ReadAllText(data));

            if (result == null) { return new JSON.Data(); }
            return result;
        }
    }
}