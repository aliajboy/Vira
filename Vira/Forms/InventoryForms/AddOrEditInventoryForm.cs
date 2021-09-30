using DataLayer;
using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms.InventoryForms
{
    public partial class AddOrEditInventoryForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public AddOrEditInventoryForm()
        {
            InitializeComponent();
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory()
            {
                Name = txtName.Text,
                Adress = txtAdress.Text,
            };
            db.InventoryRepository.Add(inventory);
            db.InventoryRepository.Save();
        }
    }
}