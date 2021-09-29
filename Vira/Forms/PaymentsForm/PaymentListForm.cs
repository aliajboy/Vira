using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms.PaymentsForm
{
    public partial class PaymentListForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public PaymentListForm()
        {
            InitializeComponent();
        }

        private void PaymentListForm_Load(object sender, EventArgs e)
        {
            dgPayment.AutoGenerateColumns = false;
            BindGrid();

        }

        private void BindGrid()
        {
            dgPayment.DataSource = db.PaymentRepository.GetAll();
        }

        private void btnNewPayment_Click(object sender, EventArgs e)
        {
            PaymentForm paymentForm = new PaymentForm();
            paymentForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPayment.CurrentRow != null)
            {
                string name = dgPayment.CurrentRow.Cells[2].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف کاربر {name} اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.UserRepository.Delete(int.Parse(dgPayment.CurrentRow.Cells[0].Value.ToString()));
                    db.UserRepository.Save();
                }
                BindGrid();
            }
            else
            {
                MessageBox.Show("!لطفا یک کاربر را انتخاب کنید");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dgPayment.DataSource = db.PaymentRepository.Get(c => c.ID.ToString().Contains(search) || c.Name.Contains(search) ||
            c.TotalPrice.ToString().Contains(search) || c.Description.Contains(search));
        }
    }
}
