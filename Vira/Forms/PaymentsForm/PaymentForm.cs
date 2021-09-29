using DataLayer;
using DataLayer.Context;
using System;
using System.Windows.Forms;
using Utility.Converter;
using ValidationComponents;
using Vira.Forms.PersonsForms;

namespace Vira.Forms.PaymentsForm
{
    public partial class PaymentForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public PaymentForm()
        {
            InitializeComponent();
            TotalPrice.Controls.RemoveAt(0);
            Price1.Controls.RemoveAt(0);
            Price2.Controls.RemoveAt(0);
            Price3.Controls.RemoveAt(0);
            Price4.Controls.RemoveAt(0);
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (TotalPrice.Value == Price1.Value + Price2.Value + Price3.Value + Price4.Value &&
                    BaseValidator.IsFormValid(this.components) && TotalPrice.Value != 0 && Price1.Value != 0)
                {
                    Payment pay = new Payment()
                    {
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        TotalPrice = int.Parse(TotalPrice.Value.ToString()),
                        Date = txtDate.Text,
                        Price1 = int.Parse(Price1.Value.ToString()),
                        Type1 = cbType1.Text,
                        Price2 = int.Parse(Price2.Value.ToString()),
                        Type2 = cbType2.Text,
                        Price3 = int.Parse(Price3.Value.ToString()),
                        Type3 = cbType3.Text,
                        Price4 = int.Parse(Price4.Value.ToString()),
                        Type4 = cbType4.Text
                    };
                    db.PaymentRepository.Add(pay);
                    db.PaymentRepository.Save();
                    if (RtlMessageBox.Show("سند پرداخت با موفقیت ثبت شد" + "\n" + "آیا سند جدیدی برای ثبت دارید؟", "تایید",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        txtName.Text = "";
                        txtDescription.Text = "";
                        TotalPrice.Value = 0;
                        txtDate.Text = "";
                        Price1.Value = 0;
                        Price2.Value = 0;
                        Price3.Value = 0;
                        Price4.Value = 0;
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    RtlMessageBox.Show("مقادیر وارد شده صحیح نمی‌باشند", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("!سند پرداخت با خطا مواجه شد");
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            string date = DateConvertor.PersianDate(DateTime.Now);
            string time = DateTime.Now.ToString("HH:mm");
            txtDate.Text = date + "-" + time;
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            string date = DateConvertor.PersianDate(DateTime.Now);
            string time = DateTime.Now.ToString("HH:mm");
            txtDate.Text = date + "-" + time;
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            PersonListForm Person = new PersonListForm();
            Person.ShowDialog();
            txtName.Text = Person.name;
            Person.Dispose();
        }
    }
}
