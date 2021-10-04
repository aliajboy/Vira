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
            dgInventory.AutoGenerateColumns = false;
            BindGrid();
        }

        private void BindGrid()
        {
            dgInventory.DataSource = db.InventoryRepository.GetAll();
        }

        private void btnNewInventory_Click(object sender, EventArgs e)
        {
            AddOrEditInventoryForm addOrEdit = new AddOrEditInventoryForm();
            if (addOrEdit.ShowDialog() == DialogResult.OK)
            {
                addOrEdit.Close();
                BindGrid();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgInventory.CurrentRow != null)
            {
                var inventoryID = int.Parse(dgInventory.CurrentRow.Cells[0].Value.ToString());
                AddOrEditInventoryForm addOrEdit = new AddOrEditInventoryForm();
                addOrEdit.inventoryId = inventoryID;
                if (addOrEdit.ShowDialog() == DialogResult.OK)
                {
                    addOrEdit.Close();
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک انبار را انتخاب نمایید");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgInventory.CurrentRow != null)
            {
                string name = dgInventory.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"آیا از حذف انبار {name} اطمینان دارید؟", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.InventoryRepository.Delete(int.Parse(dgInventory.CurrentRow.Cells[0].Value.ToString()));
                    db.InventoryRepository.Save();
                    BindGrid();
                }
            }
            else
            {
                MessageBox.Show("لطفا یک انبار را انتخاب نمایید");
            }
        }
    }
}
