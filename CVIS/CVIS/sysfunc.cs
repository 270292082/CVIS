using System.Timers;
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

        private static System.Timers.Timer _timer = new System.Timers.Timer(10);

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

            // define a timer for executing command at each tick.
            _timer.AutoReset = true;
            _timer.Elapsed += async (sender, e) => navTick(sender, e, display, 1);
            _timer.Enabled = true;
            _timer.Start();
        }

        private static void hideNav(Panel display)
        {
            if (display.Location.X == -251) return;

            // define a timer for executing command at each tick.
            _timer.AutoReset = true;
            _timer.Elapsed += (sender, e) => navTick(sender, e, display, 0);
            _timer.Enabled = true;
            _timer.Start();
        }

        private async static Task navTick(Object source, ElapsedEventArgs e, Panel display, int show)
        {
            int step = 10;
            if (show == 1)
            {

                // ! ERROR !
                // Doesn't perform the animation.
                Debug.WriteLine("Hello");
                Debug.WriteLine(display.Location.ToString());

                // Show the navigation.
                if (display.Location.X >= -10) { display.Invoke(new Action(() => { display.Location = new Point(-10, 0); })); _timer.Stop(); }
                display.Invoke(new Action(() => { display.Location = new Point(display.Location.X + step, 0); }));
            }
            else
            {
                // Hide the navigation.
                if (display.Location.X <= 0) { display.Invoke(new Action(() => { display.Location = new Point(-251, 0); })); display.Visible = false; _timer.Stop(); }
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

        public static JSON.Data readJSON(string data) {

            if (!File.Exists(data)) { Debug.WriteLine("! ERROR ! : The file doesn't exist!");  return new JSON.Data(); }
            var result = JsonSerializer.Deserialize<Data>(File.ReadAllText(data));

            if (result == null) { return new JSON.Data(); }
            return result;
        }
    }
}