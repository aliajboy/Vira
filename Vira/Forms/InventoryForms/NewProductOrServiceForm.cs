using DataLayer;
using DataLayer.Context;
using System;
using System.Windows.Forms;
using System.Linq;
using ValidationComponents;

namespace Vira.Forms.InventoryForms
{
    public partial class NewProductOrServiceForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int Service = 0;
        public NewProductOrServiceForm()
        {
            InitializeComponent();
            txtNumber.Controls.RemoveAt(0);
            txtOrderNumber.Controls.RemoveAt(0);
            txtMinNumber.Controls.RemoveAt(0);
            txtCode.Controls.RemoveAt(0);
            txtPrice.Controls.RemoveAt(0);
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    Cardex cardex = new Cardex()
                    {
                        ProductID = int.Parse(txtCode.Value.ToString()),
                        Name = txtName.Text,
                        Number = int.Parse(txtNumber.Value.ToString()),
                        Inventory = cbInventory.Text,
                        Place1 = txtPlace1.Text,
                        Place2 = txtPlace2.Text,
                        MinNumber = int.Parse(txtMinNumber.Value.ToString()),
                        Link = txtLink.Text,
                        OrderNumber = int.Parse(txtOrderNumber.Value.ToString()),
                        Description = txtDesciption.Text,
                        Price = int.Parse(txtPrice.Value.ToString()),
                    };
                    var product = db.CardexRepository.Get(p => p.ProductID == cardex.ProductID);
                    if (product.Count() == 0)
                    {
                        db.CardexRepository.Add(cardex);
                        db.CardexRepository.Save();
                        RtlMessageBox.Show("کالا با موفقیت ذخیره شد", "تایید", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("این کد وجود دارد");
                    }
                }
                else
                {
                    RtlMessageBox.Show("مقادیر وارد شده صحیح نمی‌باشند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("!افزودن کالا با خطا مواجه شد");
            }
        }

        private void NewProductOrServiceForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'navik_DBDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.navik_DBDataSet.Inventory);
            if (Service != 0)
            {
                this.Text = "     خدمات جدید";
                lblName.Text = "نام خدمات :";
                lblPrice.Text = "قیمت خدمات :";
            }
        }
    }
}