namespace Vira.Forms
{
    partial class NewTimeSubmitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTimeSubmitForm));
            this.cbName = new System.Windows.Forms.ComboBox();
            this.btnCancell = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInTime = new System.Windows.Forms.MaskedTextBox();
            this.txtExitTime = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.navik_DBDataSet1 = new Vira.Navik_DBDataSet1();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Vira.Navik_DBDataSet1TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.navik_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbName
            // 
            this.cbName.DataSource = this.loginBindingSource;
            this.cbName.DisplayMember = "UserName";
            this.cbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(12, 12);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(200, 27);
            this.cbName.TabIndex = 8;
            // 
            // btnCancell
            // 
            this.btnCancell.Location = new System.Drawing.Point(108, 152);
            this.btnCancell.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(88, 28);
            this.btnCancell.TabIndex = 7;
            this.btnCancell.Text = "انصراف";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کاربر :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 152);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 28);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(12, 56);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(200, 26);
            this.txtDate.TabIndex = 9;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "تاریخ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "ساعت ورود :";
            // 
            // txtInTime
            // 
            this.txtInTime.Location = new System.Drawing.Point(154, 98);
            this.txtInTime.Mask = "00:00";
            this.txtInTime.Name = "txtInTime";
            this.txtInTime.Size = new System.Drawing.Size(58, 26);
            this.txtInTime.TabIndex = 12;
            this.txtInTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtExitTime
            // 
            this.txtExitTime.Location = new System.Drawing.Point(12, 98);
            this.txtExitTime.Mask = "00:00";
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.Size = new System.Drawing.Size(58, 26);
            this.txtExitTime.TabIndex = 14;
            this.txtExitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExitTime.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "ساعت ورود :";
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
            // NewTimeSubmitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 195);
            this.Controls.Add(this.txtExitTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.cbName);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NewTimeSubmitForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "     ثبت تایم جدید برای کاربر";
            this.Load += new System.EventHandler(this.NewTimeSubmitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navik_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtInTime;
        private System.Windows.Forms.MaskedTextBox txtExitTime;
        private System.Windows.Forms.Label label4;
        private Navik_DBDataSet1 navik_DBDataSet1;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private Navik_DBDataSet1TableAdapters.LoginTableAdapter loginTableAdapter;
    }
}