namespace Vira.Forms.Sales
{
    partial class AddPoroductForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgCardex = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOffer = new System.Windows.Forms.NumericUpDown();
            this.txtTotalPrice = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtTax = new System.Windows.Forms.NumericUpDown();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgCardex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(696, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "جستجو :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(503, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(185, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgCardex
            // 
            this.dgCardex.AllowUserToAddRows = false;
            this.dgCardex.AllowUserToDeleteRows = false;
            this.dgCardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductID,
            this.PName,
            this.Number,
            this.Price,
            this.Inventory,
            this.Place1,
            this.Place2,
            this.MinNumber,
            this.Link,
            this.Description,
            this.OrderNumber});
            this.dgCardex.Location = new System.Drawing.Point(12, 56);
            this.dgCardex.Name = "dgCardex";
            this.dgCardex.ReadOnly = true;
            this.dgCardex.Size = new System.Drawing.Size(737, 288);
            this.dgCardex.TabIndex = 2;
            this.dgCardex.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCardex_CellClick);
            this.dgCardex.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCardex_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 438);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(96, 33);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "افزودن";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "تعداد :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "مبلغ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "مبلغ کل :";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(613, 361);
            this.txtNumber.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(77, 26);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtNumber.ValueChanged += new System.EventHandler(this.txtNumber_ValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(425, 361);
            this.txtPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 26);
            this.txtPrice.TabIndex = 8;
            this.txtPrice.ValueChanged += new System.EventHandler(this.txtPrice_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "مالیات :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "تخفیف :";
            // 
            // txtOffer
            // 
            this.txtOffer.Location = new System.Drawing.Point(137, 361);
            this.txtOffer.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtOffer.Name = "txtOffer";
            this.txtOffer.Size = new System.Drawing.Size(120, 26);
            this.txtOffer.TabIndex = 13;
            this.txtOffer.ValueChanged += new System.EventHandler(this.txtOffer_ValueChanged);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtTotalPrice.Location = new System.Drawing.Point(542, 400);
            this.txtTotalPrice.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.ReadOnly = true;
            this.txtTotalPrice.Size = new System.Drawing.Size(149, 26);
            this.txtTotalPrice.TabIndex = 14;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 31);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(318, 361);
            this.txtTax.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(49, 26);
            this.txtTax.TabIndex = 16;
            this.txtTax.ValueChanged += new System.EventHandler(this.txtTax_ValueChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "کد";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "کد محصول";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "Name";
            this.PName.HeaderText = "نام کالا";
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "تعداد";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Inventory
            // 
            this.Inventory.DataPropertyName = "Inventory";
            this.Inventory.HeaderText = "انبار";
            this.Inventory.Name = "Inventory";
            this.Inventory.ReadOnly = true;
            // 
            // Place1
            // 
            this.Place1.DataPropertyName = "Place1";
            this.Place1.HeaderText = "مکان 1";
            this.Place1.Name = "Place1";
            this.Place1.ReadOnly = true;
            // 
            // Place2
            // 
            this.Place2.DataPropertyName = "Place2";
            this.Place2.HeaderText = "مکان 2";
            this.Place2.Name = "Place2";
            this.Place2.ReadOnly = true;
            // 
            // MinNumber
            // 
            this.MinNumber.DataPropertyName = "MinNumber";
            this.MinNumber.HeaderText = "حداقل تعداد";
            this.MinNumber.Name = "MinNumber";
            this.MinNumber.ReadOnly = true;
            this.MinNumber.Visible = false;
            // 
            // Link
            // 
            this.Link.DataPropertyName = "Link";
            this.Link.HeaderText = " لینک";
            this.Link.Name = "Link";
            this.Link.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderNumber
            // 
            this.OrderNumber.DataPropertyName = "OrderNumber";
            this.OrderNumber.HeaderText = "تعداد سفارش";
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.ReadOnly = true;
            this.OrderNumber.Visible = false;
            // 
            // AddPoroductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 483);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtOffer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgCardex);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPoroductForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     افزودن محصول";
            this.Load += new System.EventHandler(this.AddPoroductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCardex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOffer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgCardex;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtNumber;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtOffer;
        private System.Windows.Forms.NumericUpDown txtTotalPrice;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.NumericUpDown txtTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinNumber;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNumber;
    }
}