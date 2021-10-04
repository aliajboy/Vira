using DataLayer;
using DataLayer.Context;
using System;
using System.Linq;
using System.Windows.Forms;
using Utility.Converter;

namespace Vira.Forms
{
    public partial class TimeSubmitForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public TimeSubmitForm()
        {
            InitializeComponent();
        }

        private void TimeSubmitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'navik_DBDataSet1.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.navik_DBDataSet1.Login);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            var user = db.LogintimeRepository.Get(c => c.Name == cbName.Text && c.ExitTime == null).Last();
            string date = DateConvertor.PersianDate(DateTime.Now);
            string time = DateTime.UtcNow.AddHours(3).AddMinutes(30).ToString("HH:mm:ss");
            string datetime = date + "-" + time;
            user.ExitTime = time;
            if (db.LogintimeRepository.Get(c => c.Name == cbName.Text && c.ExitTime != null).Any())
            {
                MessageBox.Show("خروج شما ثبت شده است");
            }
            else
            {
                db.LogintimeRepository.update(user);
                db.LogintimeRepository.Save();
                MessageBox.Show("خروج شما با موفقیت ثبت شد");
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //for online time Submit
            //string date = DateConvertor.PersianDate(OnlineDateTime.GetDateTime());
            //string time = OnlineDateTime.GetNetworkTime().AddHours(3).AddMinutes(30).ToString("HH:mm:ss");
            string date = DateConvertor.PersianDate(DateTime.Now);
            string time = DateTime.UtcNow.AddHours(3).AddMinutes(30).ToString("HH:mm:ss");
            string datetime = date + "-" + time;
            if (db.LogintimeRepository.Get(c => c.Name == cbName.Text && c.ExitTime == null).Any())
            {
                MessageBox.Show("ورود شما ثبت شده است");
            }
            else
            {
                LoginTime loginTime = new LoginTime()
                {
                    Name = cbName.Text,
                    InTime = time,
                    date = DateTime.Parse(date)
                };
                db.LogintimeRepository.Add(loginTime);
                db.LogintimeRepository.Save();
                MessageBox.Show("ورود شما با موفقیت ثبت شد");
            }
        }
    }
}
