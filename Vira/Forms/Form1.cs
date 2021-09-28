using System;
using System.Windows.Forms;
using Utility.Converter;
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
    }
}