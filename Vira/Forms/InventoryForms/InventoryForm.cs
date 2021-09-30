using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms.InventoryForms
{
    public partial class InventoryForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            dgInventory.DataSource = db.InventoryRepository.Get(c => c.Name.Contains(search) || c.ID.ToString().Contains(search) || c.Adress.Contains(search));
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            dgInventory.DataSource = db.InventoryRepository.GetAll();
        }

        private void btnNewInventory_Click(object sender, EventArgs e)
        {
            AddOrEditInventoryForm addOrEdit = new AddOrEditInventoryForm();
            addOrEdit.Show();
        }
    }
}
