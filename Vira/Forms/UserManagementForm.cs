using DataLayer.Context;
using System;
using System.Windows.Forms;
using Vira.Forms;

namespace Vira
{
    public partial class UserManagementForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public UserManagementForm()
        {
            InitializeComponent();
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            dgUsers.AutoGenerateColumns = false;
            BindGrid();
        }

        void BindGrid()
        {
            dgUsers.DataSource = db.LoginRepository.GetAll();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgUsers.CurrentRow != null)
            {
                string name = dgUsers.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف کاربر {name} اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.LoginRepository.Delete(int.Parse(dgUsers.CurrentRow.Cells[0].Value.ToString()));
                    db.LoginRepository.Save();
                }
                BindGrid();
            }
            else
            {
                MessageBox.Show("!لطفا یک کاربر را انتخاب کنید");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddOrEditUserForm addOrEdit = new AddOrEditUserForm();
            if (addOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void dgUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var userId = int.Parse(dgUsers.CurrentRow.Cells[0].Value.ToString());
                var user = db.LoginRepository.GetById(userId);
                AddOrEditUserForm addOrEdit = new AddOrEditUserForm();
                addOrEdit.userID = userId;
                if (addOrEdit.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("ویرایش کاربر با موفقیت انجام شد");
                    BindGrid();
                }
            }
            catch
            {
                MessageBox.Show("!لطفا یک کاربر را برای ویرایش انتخاب کنید");
            }
        }
    }
}