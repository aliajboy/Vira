namespace Vira.Forms.PersonsForms
{
    partial class PersonListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonListForm));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgPersons = new System.Windows.Forms.DataGridView();
            this.Personid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comapny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompanyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EconomicCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNewPerson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(648, 33);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtsearch.Size = new System.Drawing.Size(266, 26);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(920, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "جستجو :";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 67);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // dgPersons
            // 
            this.dgPersons.AllowUserToAddRows = false;
            this.dgPersons.AllowUserToDeleteRows = false;
            this.dgPersons.AllowUserToResizeRows = false;
            this.dgPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Personid,
            this.Group,
            this.PersonName,
            this.Comapny,
            this.State,
            this.City,
            this.Mobile,
            this.Telephone,
            this.NationalID,
            this.CompanyID,
            this.EconomicCode,
            this.Adress});
            this.dgPersons.Location = new System.Drawing.Point(12, 85);
            this.dgPersons.Name = "dgPersons";
            this.dgPersons.ReadOnly = true;
            this.dgPersons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgPersons.Size = new System.Drawing.Size(960, 564);
            this.dgPersons.TabIndex = 5;
            this.dgPersons.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPersons_CellContentDoubleClick);
            // 
            // Personid
            // 
            this.Personid.DataPropertyName = "PersonID";
            this.Personid.HeaderText = "کد";
            this.Personid.Name = "Personid";
            this.Personid.ReadOnly = true;
            this.Personid.Width = 46;
            // 
            // Group
            // 
            this.Group.DataPropertyName = "Grouping";
            this.Group.HeaderText = "دسته بندی";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            this.Group.Width = 87;
            // 
            // PersonName
            // 
            this.PersonName.DataPropertyName = "Name";
            this.PersonName.HeaderText = "نام";
            this.PersonName.Name = "PersonName";
            this.PersonName.ReadOnly = true;
            this.PersonName.Width = 47;
            // 
            // Comapny
            // 
            this.Comapny.DataPropertyName = "Company";
            this.Comapny.HeaderText = "شرکت";
            this.Comapny.Name = "Comapny";
            this.Comapny.ReadOnly = true;
            this.Comapny.Width = 63;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "استان";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 62;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "شهر";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 52;
            // 
            // Mobile
            // 
            this.Mobile.DataPropertyName = "Mobile";
            this.Mobile.HeaderText = "موبایل";
            this.Mobile.Name = "Mobile";
            this.Mobile.ReadOnly = true;
            this.Mobile.Width = 64;
            // 
            // Telephone
            // 
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "تلفن";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            this.Telephone.Width = 55;
            // 
            // NationalID
            // 
            this.NationalID.DataPropertyName = "NationalID";
            this.NationalID.HeaderText = "کد ملی";
            this.NationalID.Name = "NationalID";
            this.NationalID.ReadOnly = true;
            this.NationalID.Width = 68;
            // 
            // CompanyID
            // 
            this.CompanyID.DataPropertyName = "CompanyID";
            this.CompanyID.HeaderText = "شناسه ملی";
            this.CompanyID.Name = "CompanyID";
            this.CompanyID.ReadOnly = true;
            this.CompanyID.Width = 87;
            // 
            // EconomicCode
            // 
            this.EconomicCode.DataPropertyName = "EconomicCode";
            this.EconomicCode.HeaderText = "کد اقتصادی";
            this.EconomicCode.Name = "EconomicCode";
            this.EconomicCode.ReadOnly = true;
            this.EconomicCode.Width = 90;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "آدرس";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 62;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 67);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNewPerson
            // 
            this.btnNewPerson.Location = new System.Drawing.Point(216, 12);
            this.btnNewPerson.Name = "btnNewPerson";
            this.btnNewPerson.Size = new System.Drawing.Size(96, 67);
            this.btnNewPerson.TabIndex = 10;
            this.btnNewPerson.Text = "افزودن";
            this.btnNewPerson.UseVisualStyleBackColor = true;
            this.btnNewPerson.Click += new System.EventHandler(this.btnNewPerson_Click);
            // 
            // PersonListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btnNewPerson);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgPersons);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonListForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "     لیست اشخاص";
            this.Load += new System.EventHandler(this.PersonListForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgPersons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comapny;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn NationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EconomicCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNewPerson;
    }
}