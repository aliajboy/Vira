using DataLayer.Context;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Vira.Forms.InventoryForms
{
    public partial class CardexForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public CardexForm()
        {
            InitializeComponent();
        }

        private void CardexForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgCardex.DataSource = db.CardexRepository.GetAll();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dgCardex.DataSource = db.CardexRepository.Get(c => c.Name.Contains(search) || c.ID.ToString().Contains(search) || c.Description.Contains(search) || c.Place1.Contains(search)
            || c.Place2.Contains(search));
        }

        private void dgCardex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCardex.CurrentRow.Cells[4].Selected)
            {
                Process.Start(dgCardex.CurrentRow.Cells[4].Value.ToString());
            }
        }
    }
}