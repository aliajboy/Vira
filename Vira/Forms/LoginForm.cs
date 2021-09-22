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
            using (UnitOfWork db = new UnitOfWork())
            {

                if (db.LoginRepository.Get(l => l.UserName == txtUsername.Text && l.Password == txtPassword.Text).Any())
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("نام کاربری یا رمز عبور اشتباه است");
                }
            }
        }
    }
}