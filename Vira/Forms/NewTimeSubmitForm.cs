using DataLayer;
using DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vira.Forms
{
    public partial class NewTimeSubmitForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public NewTimeSubmitForm()
        {
            InitializeComponent();
        }

        private void NewTimeSubmitForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'navik_DBDataSet1.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.navik_DBDataSet1.Login);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            LoginTime time = new LoginTime()
            {
                Name = cbName.Text,
                date = DateTime.Parse(txtDate.Text),
                InTime = txtInTime.Text,
                ExitTime = txtExitTime.Text,
            };
            db.LogintimeRepository.Add(time);
            db.LogintimeRepository.Save();
            MessageBox.Show($"ساعت جدید برای کاربر {time.Name} ثبت گردید");
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
