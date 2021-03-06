using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms
{
    public partial class UserTimesForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public UserTimesForm()
        {
            InitializeComponent();
        }

        private void UserTimesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'navik_DBDataSet1.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.navik_DBDataSet1.Login);
            dgTimes.DataSource = db.LogintimeRepository.Get();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgTimes.CurrentRow != null)
            {
                TimeEditForm timeEdit = new TimeEditForm();
                timeEdit.id = int.Parse(dgTimes.CurrentRow.Cells[0].Value.ToString());
                timeEdit.Show();
            }
        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cbName.Text;
            dgTimes.DataSource = db.LogintimeRepository.Get(c => c.Name.Contains(search));
        }

        private void btnNewTime_Click(object sender, EventArgs e)
        {
            NewTimeSubmitForm newTime = new NewTimeSubmitForm();
            newTime.ShowDialog();
        }
    }
}
