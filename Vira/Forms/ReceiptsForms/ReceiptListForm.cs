using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms.ReceiptsForms
{
    public partial class ReceiptListForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public ReceiptListForm()
        {
            InitializeComponent();
        }

        private void ReceiptListForm_Load(object sender, EventArgs e)
        {
            dgReceipts.AutoGenerateColumns = false;
            BindGrid();
            
        }

        private void BindGrid()
        {
            dgReceipts.DataSource = db.ReceiptRepository.Get();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dgReceipts.DataSource = db.ReceiptRepository.Get(c => c.ID.ToString().Contains(search) || c.Name.Contains(search) ||
            c.Price.ToString().Contains(search) || c.Description.Contains(search));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgReceipts.CurrentRow != null)
            {
                string name = dgReceipts.CurrentRow.Cells[2].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف کاربر {name} اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.UserRepository.Delete(int.Parse(dgReceipts.CurrentRow.Cells[0].Value.ToString()));
                    db.UserRepository.Save();
                }
                BindGrid();
            }
            else
            {
                MessageBox.Show("!لطفا یک کاربر را انتخاب کنید");
            }
        }

        private void btnNewReciept_Click(object sender, EventArgs e)
        {
            ReceiptForm receipt = new ReceiptForm();
            receipt.Show();
        }
    }
}