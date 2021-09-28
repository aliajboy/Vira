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
            dgReceipts.DataSource = db.ReceiptRepository.Get();
            dgReceipts.AutoGenerateColumns = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dgReceipts.DataSource = db.ReceiptRepository.Get(c => c.ID.ToString().Contains(search) || c.Name.Contains(search) ||
            c.Price.ToString().Contains(search) || c.Description.Contains(search));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}