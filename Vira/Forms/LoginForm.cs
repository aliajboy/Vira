using DataLayer;
using DataLayer.Context;
using DataLayer.Repository;
using DataLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vira
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

            if (true)
            {
                this.Hide();
                var mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            else
            {
                lblError.Text = "نام کاربری یا کلمه عبور نادرست می‌باشد";
            }
        }
    }
}
