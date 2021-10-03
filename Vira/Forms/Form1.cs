using System;
using System.Windows.Forms;
using Utility.Converter;
using Vira.Forms;
using Vira.Forms.InventoryForms;
using Vira.Forms.PaymentsForm;
using Vira.Forms.PersonsForms;
using Vira.Forms.ReceiptsForms;

namespace Vira
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.Hide();
            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                this.Date.Text = DateConvertor.PersianDate(DateTime.Now);
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //string tehranTime = OnlineDateTime.GetNetworkTime().AddHours(3).AddMinutes(30).ToString("HH:mm:ss");
            this.Time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            PersonListForm personListForm = new PersonListForm();
            personListForm.Show();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            AddOrEditPersonForm personForm = new AddOrEditPersonForm();
            if (personForm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("!شخص مورد نظر با موفقیت افزوده شد");
            }
        }

        private void btnNewReceipt_Click(object sender, EventArgs e)
        {
            ReceiptForm receipt = new ReceiptForm();
            receipt.Show();
        }

        private void btnReceipts_Click(object sender, EventArgs e)
        {
            ReceiptListForm receiptList = new ReceiptListForm();
            receiptList.Show();
        }

        private void PayForm_Click(object sender, EventArgs e)
        {
            PaymentForm pay = new PaymentForm();
            pay.Show();
        }

        private void PayListForm_Click(object sender, EventArgs e)
        {
            PaymentListForm paymentList = new PaymentListForm();
            paymentList.Show();
        }

        private void btnCardex_Click(object sender, EventArgs e)
        {
            CardexForm cardex = new CardexForm();
            cardex.Show();
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            NewProductOrServiceForm newProduct = new NewProductOrServiceForm();
            newProduct.Show();
        }

        private void btnNewService_Click(object sender, EventArgs e)
        {
            NewProductOrServiceForm newProduct = new NewProductOrServiceForm();
            newProduct.Service = 1;
            newProduct.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventory = new InventoryForm();
            inventory.Show();
        }

        private void btnCheckReciept_Click(object sender, EventArgs e)
        {

        }

        private void btnTimeSubmit_Click(object sender, EventArgs e)
        {
            TimeSubmitForm submitForm = new TimeSubmitForm();
            submitForm.Show();
        }

        private void btnTimes_Click(object sender, EventArgs e)
        {
            UserTimesForm userTimes = new UserTimesForm();
            userTimes.Show();
        }
    }
}