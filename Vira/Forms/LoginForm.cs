using DataLayer.Context;
using System;
using System.Linq;
using System.Windows.Forms;
using Utility;
using Vira.Utility;

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
            string tehranTime = OnlineDateTime.GetNetworkTime().AddHours(3).AddMinutes(30).ToString("HH:mm");
            if (tehranTime == DateTime.UtcNow.AddHours(3).AddMinutes(30).ToString("HH:mm"))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    string pass = Encrypte.EncryptPlainTextToCipherText(txtPassword.Text);
                    if (db.LoginRepository.Get(l => l.UserName == txtUsername.Text && l.Password == pass).Any())
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                    }
                }
            }
            else
            {
                MessageBox.Show("لطفا ساعت سیستم خود را بروز کنید");
            }
        }
    }
}