using DataLayer;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vira.Forms
{
    public partial class AddOrEditUserForm : Form
    {
        public int? productId;
        UnitOfWork db = new UnitOfWork();
        public AddOrEditUserForm()
        {
            InitializeComponent();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Login login = new Login()
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text
            };
            //db.LoginRepository.AddUser(login);
            //db.loginRepository.Save();
            DialogResult = DialogResult.OK;
        }
    }
}