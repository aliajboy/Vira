namespace Vira.Forms.ReceiptsForms
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType1 = new System.Windows.Forms.ComboBox();
            this.btnToday = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.cbType2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbType3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbType4 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.NumericUpDown();
            this.Price1 = new System.Windows.Forms.NumericUpDown();
            this.Price2 = new System.Windows.Forms.NumericUpDown();
            this.Price3 = new System.Windows.Forms.NumericUpDown();
            this.Price4 = new System.Windows.Forms.NumericUpDown();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator5 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(732, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "تاریخ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "شرح :";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 24);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(345, 26);
            this.txtDescription.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(707, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام شخص :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(469, 79);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 26);
            this.txtName.TabIndex = 5;
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "مبلغ کل :";
            // 
            // cbType1
            // 
            this.cbType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType1.FormattingEnabled = true;
            this.cbType1.Items.AddRange(new object[] {
            "بانک",
            "نقدی",
            "تنخواه گردان"});
            this.cbType1.Location = new System.Drawing.Point(469, 136);
            this.cbType1.Name = "cbType1";
            this.cbType1.Size = new System.Drawing.Size(207, 27);
            this.cbType1.TabIndex = 8;
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(422, 24);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(40, 27);
            this.btnToday.TabIndex = 9;
            this.btnToday.Text = "امروز";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "دریافت از طریق :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "مبلغ :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 365);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(99, 27);
            this.btnSubmit.TabIndex = 25;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.Location = new System.Drawing.Point(121, 365);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(99, 27);
            this.btnCancell.TabIndex = 26;
            this.btnCancell.Text = "انصراف";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // cbType2
            // 
            this.cbType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType2.FormattingEnabled = true;
            this.cbType2.Items.AddRange(new object[] {
            "بانک",
            "نقدی",
            "تنخواه گردان"});
            this.cbType2.Location = new System.Drawing.Point(469, 196);
            this.cbType2.Name = "cbType2";
            this.cbType2.Size = new System.Drawing.Size(207, 27);
            this.cbType2.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(682, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "دریافت از طریق :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "مبلغ :";
            // 
            // cbType3
            // 
            this.cbType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType3.FormattingEnabled = true;
            this.cbType3.Location = new System.Drawing.Point(469, 254);
            this.cbType3.Name = "cbType3";
            this.cbType3.Size = new System.Drawing.Size(207, 27);
            this.cbType3.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(682, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "دریافت از طریق :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(380, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "مبلغ :";
            // 
            // cbType4
            // 
            this.cbType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType4.FormattingEnabled = true;
            this.cbType4.Location = new System.Drawing.Point(469, 309);
            this.cbType4.Name = "cbType4";
            this.cbType4.Size = new System.Drawing.Size(207, 27);
            this.cbType4.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(682, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 19);
            this.label12.TabIndex = 22;
            this.label12.Text = "دریافت از طریق :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(380, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "مبلغ :";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(469, 24);
            this.txtDate.Name = "txtDate";
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(207, 26);
            this.txtDate.TabIndex = 0;
            // 
            // TotalPrice
            // 
            this.TotalPrice.InterceptArrowKeys = false;
            this.TotalPrice.Location = new System.Drawing.Point(183, 79);
            this.TotalPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(174, 26);
            this.TotalPrice.TabIndex = 27;
            this.TotalPrice.ThousandsSeparator = true;
            // 
            // Price1
            // 
            this.Price1.InterceptArrowKeys = false;
            this.Price1.Location = new System.Drawing.Point(183, 137);
            this.Price1.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(174, 26);
            this.Price1.TabIndex = 28;
            this.Price1.ThousandsSeparator = true;
            // 
            // Price2
            // 
            this.Price2.InterceptArrowKeys = false;
            this.Price2.Location = new System.Drawing.Point(183, 196);
            this.Price2.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Price2.Name = "Price2";
            this.Price2.Size = new System.Drawing.Size(174, 26);
            this.Price2.TabIndex = 29;
            this.Price2.ThousandsSeparator = true;
            // 
            // Price3
            // 
            this.Price3.InterceptArrowKeys = false;
            this.Price3.Location = new System.Drawing.Point(183, 254);
            this.Price3.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Price3.Name = "Price3";
            this.Price3.Size = new System.Drawing.Size(174, 26);
            this.Price3.TabIndex = 30;
            this.Price3.ThousandsSeparator = true;
            // 
            // Price4
            // 
            this.Price4.InterceptArrowKeys = false;
            this.Price4.Location = new System.Drawing.Point(183, 309);
            this.Price4.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Price4.Name = "Price4";
            this.Price4.Size = new System.Drawing.Size(174, 26);
            this.Price4.TabIndex = 31;
            this.Price4.ThousandsSeparator = true;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.cbType1;
            this.requiredFieldValidator1.ErrorMessage = "یک نوع دریافت را انتخاب نمایید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtDescription;
            this.requiredFieldValidator2.ErrorMessage = "شرح دریافت را یادداشت فرمایید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtName;
            this.requiredFieldValidator3.ErrorMessage = "نام شخص را انتخاب نمایید";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.TotalPrice;
            this.requiredFieldValidator4.ErrorMessage = "مبلغ کل را وارد نمایید";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator5.ControlToValidate = this.Price1;
            this.requiredFieldValidator5.ErrorMessage = "مبلغ را وارد نمایید";
            this.requiredFieldValidator5.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator5.Icon")));
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(785, 408);
            this.Controls.Add(this.Price4);
            this.Controls.Add(this.Price3);
            this.Controls.Add(this.Price2);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbType4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbType3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbType2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.cbType1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReceiptForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "     دریافت جدید";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Price4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbType1;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.ComboBox cbType2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbType3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbType4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.NumericUpDown TotalPrice;
        private System.Windows.Forms.NumericUpDown Price1;
        private System.Windows.Forms.NumericUpDown Price2;
        private System.Windows.Forms.NumericUpDown Price3;
        private System.Windows.Forms.NumericUpDown Price4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator5;
    }
}