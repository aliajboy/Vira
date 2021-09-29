namespace Vira.Forms.ReceiptsForms
{
    partial class ReceiptListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptListForm));
            this.dgReceipts = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNewReciept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgReceipts
            // 
            this.dgReceipts.AllowUserToAddRows = false;
            this.dgReceipts.AllowUserToDeleteRows = false;
            this.dgReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReceipts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Payer,
            this.Description,
            this.Date,
            this.Price});
            this.dgReceipts.Location = new System.Drawing.Point(12, 86);
            this.dgReceipts.Name = "dgReceipts";
            this.dgReceipts.ReadOnly = true;
            this.dgReceipts.Size = new System.Drawing.Size(949, 498);
            this.dgReceipts.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 46;
            // 
            // Payer
            // 
            this.Payer.DataPropertyName = "Name";
            this.Payer.HeaderText = "نام شخص";
            this.Payer.Name = "Payer";
            this.Payer.ReadOnly = true;
            this.Payer.Width = 84;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "شرح";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 57;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 59;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "مبلغ کل";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(909, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(667, 33);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(236, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 68);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNewReciept
            // 
            this.btnNewReciept.Location = new System.Drawing.Point(106, 12);
            this.btnNewReciept.Name = "btnNewReciept";
            this.btnNewReciept.Size = new System.Drawing.Size(88, 68);
            this.btnNewReciept.TabIndex = 4;
            this.btnNewReciept.Text = "دریافت جدید";
            this.btnNewReciept.UseVisualStyleBackColor = true;
            this.btnNewReciept.Click += new System.EventHandler(this.btnNewReciept_Click);
            // 
            // ReceiptListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(973, 596);
            this.Controls.Add(this.btnNewReciept);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgReceipts);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiptListForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "     لیست دریافت ها";
            this.Load += new System.EventHandler(this.ReceiptListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgReceipts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnNewReciept;
    }
}