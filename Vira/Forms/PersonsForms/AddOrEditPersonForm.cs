﻿using System;
using System.Windows.Forms;

namespace Vira.Forms.PersonsForms
{
    public partial class AddOrEditPersonForm : Form
    {
        int personId = 0;
        public AddOrEditPersonForm()
        {
            InitializeComponent();
        }

        private void AddOrEditPersonForm_Load_1(object sender, EventArgs e)
        {
            if (personId != 0)
            {
                this.Text = "ویرایش شخص";
            }
        }
    }
}