using DataLayer.Context;
using System;
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
            dgPersons.DataSource = db.UserRepository.GetAll();
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

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtsearch.Text;
            dgPersons.DataSource = db.UserRepository.Get(c => c.Name.Contains(search) || c.PersonID.ToString().Contains(search) || c.Mobile.Contains(search) || c.Company.Contains(search)
            || c.Telephone.Contains(search) || c.NationalID.Contains(search));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var personId = int.Parse(dgPersons.CurrentRow.Cells[0].Value.ToString());
            var person = db.UserRepository.GetById(personId);
            AddOrEditPersonForm addOrEdit = new AddOrEditPersonForm();
            addOrEdit.personId = personId;
            if (addOrEdit.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
                MessageBox.Show("ویرایش شخص با موفقیت انجام شد");
            }
        }
        public string name { get; private set; }
        private void dgPersons_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            name = dgPersons.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            AddOrEditPersonForm addOrEdit = new AddOrEditPersonForm();
            addOrEdit.ShowDialog();
        }
    }
}