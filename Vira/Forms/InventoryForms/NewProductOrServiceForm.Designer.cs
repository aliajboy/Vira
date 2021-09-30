namespace Vira.Forms.InventoryForms
{
    partial class NewProductOrServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProductOrServiceForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.cbInventory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPlace1 = new System.Windows.Forms.TextBox();
            this.txtPlace2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDesciption = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinNumber = new System.Windows.Forms.NumericUpDown();
            this.txtOrderNumber = new System.Windows.Forms.NumericUpDown();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.NumericUpDown();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator5 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator6 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator7 = new ValidationComponents.RequiredFieldValidator(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(741, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(481, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام کالا یا خدمات :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(181, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 26);
            this.txtName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "تعداد :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(12, 26);
            this.txtNumber.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(77, 26);
            this.txtNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "قیمت کالا یا خدمات :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(502, 251);
            this.txtPrice.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(149, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // cbInventory
            // 
            this.cbInventory.FormattingEnabled = true;
            this.cbInventory.Items.AddRange(new object[] {
            "dfgdfgdfg"});
            this.cbInventory.Location = new System.Drawing.Point(543, 84);
            this.cbInventory.Name = "cbInventory";
            this.cbInventory.Size = new System.Drawing.Size(186, 27);
            this.cbInventory.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(735, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "انبار :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(481, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "مکان 1 :";
            // 
            // txtPlace1
            // 
            this.txtPlace1.Location = new System.Drawing.Point(353, 85);
            this.txtPlace1.Name = "txtPlace1";
            this.txtPlace1.Size = new System.Drawing.Size(122, 26);
            this.txtPlace1.TabIndex = 11;
            // 
            // txtPlace2
            // 
            this.txtPlace2.Location = new System.Drawing.Point(181, 85);
            this.txtPlace2.Name = "txtPlace2";
            this.txtPlace2.Size = new System.Drawing.Size(110, 26);
            this.txtPlace2.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "مکان 2 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "نقطه سفارش :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(92, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "تعداد سفارش :";
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(179, 143);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(513, 26);
            this.txtLink.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "لینک سایت :";
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(12, 197);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(680, 26);
            this.txtDesciption.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(707, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "توضیحات :";
            // 
            // txtMinNumber
            // 
            this.txtMinNumber.Location = new System.Drawing.Point(12, 85);
            this.txtMinNumber.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtMinNumber.Name = "txtMinNumber";
            this.txtMinNumber.Size = new System.Drawing.Size(77, 26);
            this.txtMinNumber.TabIndex = 22;
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.Location = new System.Drawing.Point(12, 144);
            this.txtOrderNumber.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(77, 26);
            this.txtOrderNumber.TabIndex = 23;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Green;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSubmit.Location = new System.Drawing.Point(131, 276);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 34);
            this.btnSubmit.TabIndex = 24;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancell.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCancell.Location = new System.Drawing.Point(12, 276);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(93, 34);
            this.btnCancell.TabIndex = 25;
            this.btnCancell.Text = "انصراف";
            this.btnCancell.UseVisualStyleBackColor = false;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(609, 27);
            this.txtCode.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 26);
            this.txtCode.TabIndex = 26;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtCode;
            this.requiredFieldValidator1.ErrorMessage = "کد محصول را وارد کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtName;
            this.requiredFieldValidator2.ErrorMessage = "نام کالا یا خدمات را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.txtNumber;
            this.requiredFieldValidator3.ErrorMessage = "تعداد موجودی را وارد کنید";
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtPrice;
            this.requiredFieldValidator4.ErrorMessage = "قیمت کالا یا خدمات را وارد کنید";
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator5.ControlToValidate = this.txtPlace1;
            this.requiredFieldValidator5.ErrorMessage = "مکان را وارد نمایید";
            this.requiredFieldValidator5.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator5.Icon")));
            // 
            // requiredFieldValidator6
            // 
            this.requiredFieldValidator6.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator6.ControlToValidate = this.txtMinNumber;
            this.requiredFieldValidator6.ErrorMessage = "نقطه سفارش را وارد نمایید";
            this.requiredFieldValidator6.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator6.Icon")));
            // 
            // requiredFieldValidator7
            // 
            this.requiredFieldValidator7.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator7.ControlToValidate = this.txtOrderNumber;
            this.requiredFieldValidator7.ErrorMessage = "تعداد سفارش را وارد نمایید";
            this.requiredFieldValidator7.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator7.Icon")));
            // 
            // NewProductOrServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(781, 319);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtOrderNumber);
            this.Controls.Add(this.txtMinNumber);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPlace2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPlace1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbInventory);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewProductOrServiceForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "     کالا جدید";
            this.Load += new System.EventHandler(this.NewProductOrServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.ComboBox cbInventory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPlace1;
        private System.Windows.Forms.TextBox txtPlace2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDesciption;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown txtMinNumber;
        private System.Windows.Forms.NumericUpDown txtOrderNumber;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.NumericUpDown txtCode;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator5;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator6;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator7;
    }
}