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
using Utility.Converter;

namespace Vira.Forms
{
    public partial class TimeEditForm : Form
    {
        UnitOfWork db = new UnitOfWork();
        public int id;
        public TimeEditForm()
        {
            InitializeComponent();
        }

        private void TimeEditForm_Load(object sender, EventArgs e)
        {
            var userTime = db.LogintimeRepository.GetById(id);
            txtName.Text = userTime.Name;
            txtIntime.Text = userTime.InTime;
            txtExitTime.Text = userTime.ExitTime;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var userTime = db.LogintimeRepository.GetById(id);
            userTime.Name = txtName.Text;
            userTime.InTime = txtIntime.Text;
            userTime.ExitTime = txtExitTime.Text;
            db.LogintimeRepository.update(userTime);
            db.LogintimeRepository.Save();
            MessageBox.Show("ساعت ورود کاربر با موفقیت بروزرسانی شد");
        }
    }
}
