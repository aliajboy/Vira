using DataLayer;
using DataLayer.Context;
using System;
using System.Windows.Forms;
using Utility;

namespace Vira.Forms
{
    public partial class AddOrEditUserForm : Form
    {
        public int userID = 0;
        UnitOfWork db = new UnitOfWork();
        public AddOrEditUserForm()
        {
            InitializeComponent();
        }

        private void AddOrEditUserForm_Load(object sender, EventArgs e)
        {
            if (userID != 0)
            {
                this.Text = "ویرایش کاربر";
                btnAdd.Text = "ویرایش";
                txtUsername.Text = db.LoginRepository.GetById(userID).UserName;
                txtPassword.Text = db.LoginRepository.GetById(userID).Password;
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int pass = txtPassword.Text.GetHashCode();
            Login login = new Login()
            {
                UserName = txtUsername.Text,
                Password = Encrypte.EncryptPlainTextToCipherText(txtPassword.Text)
            };

            if (userID == 0)
            {
                db.LoginRepository.Add(login);
                db.LoginRepository.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                login.LoginID = userID;
                db.LoginRepository.update(login, f => f.LoginID == login.LoginID);
                db.LoginRepository.Save();
                DialogResult = DialogResult.OK;
            }
        }
    }
}