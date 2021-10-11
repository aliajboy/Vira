using DataLayer;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vira.Forms.Sales
{
    public partial class AddPoroductForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public FactorProducts Product { get; set; }
        public AddPoroductForm()
        {
            InitializeComponent();
            txtPrice.Controls.RemoveAt(0);
            txtOffer.Controls.RemoveAt(0);
            txtTotalPrice.Controls.RemoveAt(0);
            txtTax.Controls.RemoveAt(0);
        }

        private void AddPoroductForm_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dgCardex.DataSource = db.CardexRepository.GetAll();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgCardex.DataSource = db.CardexRepository.Search(c => c.Name.Contains(txtSearch.Text) ||
            c.ProductID.ToString().Contains(txtSearch.Text) && c.Number.ToString() != "0");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            BindGrid();
        }

        private void dgCardex_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productId = int.Parse(dgCardex.CurrentRow.Cells[0].Value.ToString());
            var product = db.CardexRepository.GetById(productId);
            if (product != null)
            {
                txtPrice.Value = int.Parse(product.Price.ToString());
                txtTotalPrice.Value = txtPrice.Value;
            }
        }

        private void txtNumber_ValueChanged(object sender, EventArgs e)
        {
            var tax = txtTotalPrice.Value * (txtTax.Value / 100);
            txtTotalPrice.Value = (txtPrice.Value * txtNumber.Value) - txtOffer.Value + tax;
        }

        private void txtOffer_ValueChanged(object sender, EventArgs e)
        {
            var tax = txtTotalPrice.Value * (txtTax.Value / 100);
            if (txtOffer.Value > 0)
            {
                txtTotalPrice.Value = (txtPrice.Value * txtNumber.Value) - txtOffer.Value + tax;
            }
            else
            {
                txtTotalPrice.Value = (txtPrice.Value * txtNumber.Value) + tax;
            }
        }

        private void txtTax_ValueChanged(object sender, EventArgs e)
        {
            var tax = txtTotalPrice.Value * (txtTax.Value / 100);
            txtTotalPrice.Value = (txtPrice.Value * txtNumber.Value) - txtOffer.Value + tax;
        }

        private void txtPrice_ValueChanged(object sender, EventArgs e)
        {
            var tax = txtTotalPrice.Value * (txtTax.Value / 100);
            txtTotalPrice.Value = (txtPrice.Value * txtNumber.Value) - txtOffer.Value + tax;
        }

        private void dgCardex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgCardex.CurrentRow.Cells[8].Selected)
            {
                var url = dgCardex.CurrentRow.Cells[8].Value.ToString();
                Process.Start(url);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var product = dgCardex.CurrentRow;
            NewSaleForm newSale = new NewSaleForm();
            FactorProducts factor = new FactorProducts()
            {
                FactorID = newSale.FID,
                ProductID = int.Parse(product.Cells[2].Value.ToString()),
                ProductName = product.Cells[3].Value.ToString(),
                Number = int.Parse(product.Cells[4].Value.ToString()),
                UnitPrice = int.Parse(product.Cells[5].Value.ToString()),
                OfferPrice = int.Parse(product.Cells[6].Value.ToString()),
                TotalPrice = int.Parse(product.Cells[7].Value.ToString())
            };
            Product = factor;
            DialogResult = DialogResult.OK;
        }
    }
}
