using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vira.Utility;
using Utility.Converter;

namespace Vira
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Date.Text = DateConvertor.PersianDate(OnlineDateTime.GetDateTime());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string tehranTime = OnlineDateTime.GetNetworkTime().AddHours(4).AddMinutes(30).ToString("HH:mm:ss");
            this.Time.Text = tehranTime;
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
        }
    }
}
