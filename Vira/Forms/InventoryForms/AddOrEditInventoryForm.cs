using DataLayer;
using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms.InventoryForms
{
    public partial class AddOrEditInventoryForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int inventoryId = 0;
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
            if (inventoryId == 0)
            {
                db.InventoryRepository.Add(inventory);
                db.InventoryRepository.Save();
                MessageBox.Show("انبار با موفقیت افزوده شد");
                DialogResult = DialogResult.OK;
            }
            else
            {
                inventory.ID = inventoryId;
                db.InventoryRepository.update(inventory, p => p.ID == inventoryId);
                db.InventoryRepository.Save();
                MessageBox.Show("انبار با موفقیت ویرایش شد");
                DialogResult = DialogResult.OK;
            }
        }

        private void AddOrEditInventoryForm_Load(object sender, EventArgs e)
        {
            if (inventoryId != 0)
            {
                this.Text = "     ویرایش انبار";
                txtName.Text = db.InventoryRepository.GetById(inventoryId).Name;
                txtAdress.Text = db.InventoryRepository.GetById(inventoryId).Adress;
            }
        }
    }
}