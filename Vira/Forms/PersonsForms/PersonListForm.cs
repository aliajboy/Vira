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

namespace Vira.Forms.PersonsForms
{
    public partial class PersonListForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public PersonListForm()
        {
            InitializeComponent();
        }
        void BindGrid()
        {
            dgPersons.DataSource = db.UserRepository.Get();
        }

        private void PersonListForm_Load_1(object sender, EventArgs e)
        {
            dgPersons.AutoGenerateColumns = false;
            BindGrid();
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgPersons.CurrentRow != null)
            {
                string name = dgPersons.CurrentRow.Cells[2].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف کاربر {name} اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.UserRepository.Delete(int.Parse(dgPersons.CurrentRow.Cells[0].Value.ToString()));
                    db.UserRepository.Save();
                }
                BindGrid();
            }
            else
            {
                MessageBox.Show("!لطفا یک کاربر را انتخاب کنید");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
