namespace Vira.Forms
{
    partial class UserTimesForm
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
            this.components = new System.ComponentModel.Container();
            this.dgTimes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.navik_DBDataSet1 = new Vira.Navik_DBDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Vira.Navik_DBDataSet1TableAdapters.LoginTableAdapter();
            this.btnEdit = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navik_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgTimes
            // 
            this.dgTimes.AllowUserToAddRows = false;
            this.dgTimes.AllowUserToDeleteRows = false;
            this.dgTimes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTimes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTimes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UserName,
            this.InTime,
            this.ExitTime,
            this.Date});
            this.dgTimes.Location = new System.Drawing.Point(12, 70);
            this.dgTimes.Name = "dgTimes";
            this.dgTimes.ReadOnly = true;
            this.dgTimes.Size = new System.Drawing.Size(493, 331);
            this.dgTimes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(453, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو :";
            // 
            // cbName
            // 
            this.cbName.DataSource = this.loginBindingSource;
            this.cbName.DisplayMember = "UserName";
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(255, 24);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(192, 27);
            this.cbName.TabIndex = 2;
            this.cbName.SelectedIndexChanged += new System.EventHandler(this.cbName_SelectedIndexChanged);
            // 
            // navik_DBDataSet1
            // 
            this.navik_DBDataSet1.DataSetName = "Navik_DBDataSet1";
            this.navik_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.navik_DBDataSet1;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 52);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "Name";
            this.UserName.HeaderText = "نام کاربر";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            // 
            // InTime
            // 
            this.InTime.DataPropertyName = "Intime";
            this.InTime.HeaderText = "ساعت ورود";
            this.InTime.Name = "InTime";
            this.InTime.ReadOnly = true;
            // 
            // ExitTime
            // 
            this.ExitTime.DataPropertyName = "ExitTime";
            this.ExitTime.HeaderText = "ساعت خروج";
            this.ExitTime.Name = "ExitTime";
            this.ExitTime.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "date";
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // UserTimesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 413);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgTimes);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserTimesForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "     لیست ورود و خروج ها";
            this.Load += new System.EventHandler(this.UserTimesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navik_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbName;
        private Navik_DBDataSet1 navik_DBDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Navik_DBDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}