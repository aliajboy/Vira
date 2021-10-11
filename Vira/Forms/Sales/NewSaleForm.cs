using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vira.Forms.Sales
{
    public partial class NewSaleForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int FID { get; set; }
        public NewSaleForm()
        {
            InitializeComponent();
        }

        private void NewSaleForm_Load(object sender, EventArgs e)
        {
            dgFactor.AutoGenerateColumns = false;
            var lastFactor = db.FactorRepository.Get().Last();
            int lastID = lastFactor.ID + 1;
            txtFactorNumber.Text = lastID.ToString();
            FID = lastID;
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddPoroductForm addPoroduct = new AddPoroductForm();
            if (addPoroduct.ShowDialog() == DialogResult.OK)
            {
                var products = addPoroduct.Product;
                dgFactor.DataSource = products;
            }

        }
    }
}