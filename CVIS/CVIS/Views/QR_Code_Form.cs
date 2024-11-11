using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using users;
using SysFunc;

namespace CVIS
{
    public partial class QR_Code_Form : Form
    {
        Panel _display;
        Patient _patient;
        public QR_Code_Form(Panel display, Patient patient)
        {
            InitializeComponent();
            _display = display;
            _patient = patient;

        }
        private async Task InitializeAsync()
        {
            qr_code_text.Text = await _patient.getStatusQR();
            user_name_text.Text = _patient.firstName + " " + _patient.lastName;
            user_id_text.Text = _patient.ID.ToString();
        }

        private async void QR_Code_Form_Load(object sender, EventArgs e)
        {
            await InitializeAsync(); 
        }
        private void cross_button_Click(object sender, EventArgs e)
        {
            _display.Visible = false;
            _display.Location = new Point(0, 1000);
        }
    }
}
