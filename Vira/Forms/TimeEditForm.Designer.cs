namespace Vira.Forms
{
    partial class TimeEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInTime = new System.Windows.Forms.MaskedTextBox();
            this.txtExitTime = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربر :";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 103);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(86, 28);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ساعت ورود :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "ساعت خروج :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(190, 26);
            this.txtName.TabIndex = 7;
            // 
            // txtInTime
            // 
            this.txtInTime.Location = new System.Drawing.Point(152, 56);
            this.txtInTime.Mask = "00:00";
            this.txtInTime.Name = "txtInTime";
            this.txtInTime.Size = new System.Drawing.Size(50, 26);
            this.txtInTime.TabIndex = 10;
            this.txtInTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInTime.ValidatingType = typeof(System.DateTime);
            // 
            // txtExitTime
            // 
            this.txtExitTime.Location = new System.Drawing.Point(12, 56);
            this.txtExitTime.Mask = "00:00";
            this.txtExitTime.Name = "txtExitTime";
            this.txtExitTime.Size = new System.Drawing.Size(51, 26);
            this.txtExitTime.TabIndex = 11;
            this.txtExitTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExitTime.ValidatingType = typeof(System.DateTime);
            // 
            // TimeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 148);
            this.Controls.Add(this.txtExitTime);
            this.Controls.Add(this.txtInTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TimeEditForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "     ویرایس ساعت ورود و خروج";
            this.Load += new System.EventHandler(this.TimeEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtInTime;
        private System.Windows.Forms.MaskedTextBox txtExitTime;
    }
}