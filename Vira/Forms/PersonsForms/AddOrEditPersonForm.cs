using DataLayer;
using DataLayer.Context;
using System;
using System.Windows.Forms;

namespace Vira.Forms.PersonsForms
{
    public partial class AddOrEditPersonForm : Form
    {
        public int personId = 0;
        UnitOfWork db = new UnitOfWork();
        public AddOrEditPersonForm()
        {
            InitializeComponent();
        }

        private void AddOrEditPersonForm_Load_1(object sender, EventArgs e)
        {
            if (personId != 0)
            {
                this.Text = "ویرایش شخص";
                cbGroup.Text = db.UserRepository.GetById(personId).Grouping;
                txtName.Text = db.UserRepository.GetById(personId).Name;
                txtCompany.Text = db.UserRepository.GetById(personId).Company;
                txtState.Text = db.UserRepository.GetById(personId).State;
                txtCity.Text = db.UserRepository.GetById(personId).City;
                txtMobile.Text = db.UserRepository.GetById(personId).Mobile;
                txtTelephone.Text = db.UserRepository.GetById(personId).Telephone;
                txtIdCode.Text = db.UserRepository.GetById(personId).NationalID;
                txtCompanyId.Text = db.UserRepository.GetById(personId).CompanyID;
                txtEconomicCode.Text = db.UserRepository.GetById(personId).EconomicCode;
                txtAdress.Text = db.UserRepository.GetById(personId).Adress;
                postalCode.Value = (int)(db.UserRepository.GetById(personId).PostalCode);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Persons persons = new Persons()
            {
                Grouping = cbGroup.Text.ToString(),
                Name = txtName.Text,
                Company = txtCompany.Text,
                State = txtState.Text,
                City = txtCity.Text,
                Mobile = txtMobile.Text,
                Telephone = txtTelephone.Text,
                NationalID = txtIdCode.Text,
                CompanyID = txtCompanyId.Text,
                EconomicCode = txtEconomicCode.Text,
                Adress = txtAdress.Text,
                PostalCode = int.Parse(postalCode.Value.ToString())
            };
            if (personId == 0)
            {
                db.UserRepository.Add(persons);
                db.UserRepository.Save();
                DialogResult = DialogResult.OK;
            }
            else
            {
                persons.PersonID = personId;
                db.UserRepository.update(persons, f => f.PersonID == persons.PersonID);
                db.UserRepository.Save();
                DialogResult = DialogResult.OK;
            }
        }
        private void btnCancell_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}