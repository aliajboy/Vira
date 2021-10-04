namespace Vira.Forms
{
    partial class AddOrEditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrEditUserForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.InsuranceCost = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.OverTime = new System.Windows.Forms.NumericUpDown();
            this.MonthlyHours = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DelayCost = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.Dailyhours = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Vacation = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dailyhours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vacation)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(533, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 66);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "رمز عبور :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(307, 22);
            this.txtUsername.MaxLength = 100;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(219, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(307, 63);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(219, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "افزودن";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancell
            // 
            this.btnCancell.Location = new System.Drawing.Point(130, 218);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(100, 28);
            this.btnCancell.TabIndex = 5;
            this.btnCancell.Text = "انصراف";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "حقوق :";
            // 
            // Salary
            // 
            this.Salary.Location = new System.Drawing.Point(12, 22);
            this.Salary.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(191, 26);
            this.Salary.TabIndex = 7;
            this.Salary.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "هزینه بیمه :";
            // 
            // InsuranceCost
            // 
            this.InsuranceCost.Location = new System.Drawing.Point(12, 64);
            this.InsuranceCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.InsuranceCost.Name = "InsuranceCost";
            this.InsuranceCost.Size = new System.Drawing.Size(191, 26);
            this.InsuranceCost.TabIndex = 9;
            this.InsuranceCost.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "اضافه کاری :";
            // 
            // OverTime
            // 
            this.OverTime.Location = new System.Drawing.Point(350, 109);
            this.OverTime.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.OverTime.Name = "OverTime";
            this.OverTime.Size = new System.Drawing.Size(176, 26);
            this.OverTime.TabIndex = 11;
            this.OverTime.ThousandsSeparator = true;
            // 
            // MonthlyHours
            // 
            this.MonthlyHours.Location = new System.Drawing.Point(350, 160);
            this.MonthlyHours.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.MonthlyHours.Name = "MonthlyHours";
            this.MonthlyHours.Size = new System.Drawing.Size(136, 26);
            this.MonthlyHours.TabIndex = 12;
            this.MonthlyHours.ThousandsSeparator = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(492, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "ساعت مجاز ماهیانه :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "کسر از حقوق بابت دیرکرد :";
            // 
            // DelayCost
            // 
            this.DelayCost.Location = new System.Drawing.Point(12, 109);
            this.DelayCost.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.DelayCost.Name = "DelayCost";
            this.DelayCost.Size = new System.Drawing.Size(191, 26);
            this.DelayCost.TabIndex = 15;
            this.DelayCost.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "ساعت مجاز روزانه :";
            // 
            // Dailyhours
            // 
            this.Dailyhours.Location = new System.Drawing.Point(12, 160);
            this.Dailyhours.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Dailyhours.Name = "Dailyhours";
            this.Dailyhours.Size = new System.Drawing.Size(191, 26);
            this.Dailyhours.TabIndex = 17;
            this.Dailyhours.ThousandsSeparator = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(494, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "مقدار مرخصی مجاز :";
            // 
            // Vacation
            // 
            this.Vacation.Location = new System.Drawing.Point(350, 207);
            this.Vacation.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.Vacation.Name = "Vacation";
            this.Vacation.Size = new System.Drawing.Size(136, 26);
            this.Vacation.TabIndex = 19;
            this.Vacation.ThousandsSeparator = true;
            // 
            // AddOrEditUserForm
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 265);
            this.Controls.Add(this.Vacation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Dailyhours);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DelayCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.MonthlyHours);
            this.Controls.Add(this.OverTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.InsuranceCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddOrEditUserForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "     افزودن کاربر";
            this.Load += new System.EventHandler(this.AddOrEditUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OverTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelayCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dailyhours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vacation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Salary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown InsuranceCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown OverTime;
        private System.Windows.Forms.NumericUpDown MonthlyHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown DelayCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown Dailyhours;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown Vacation;
    }
}