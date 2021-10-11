namespace Vira.Forms.Sales
{
    partial class NewSaleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSaleForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFactorNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFactorKind = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancell = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTransport = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTransportPrice = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnShowFactor = new System.Windows.Forms.Button();
            this.dgFactor = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTransportPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OfferPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FactorKind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtFactorNumber
            // 
            this.txtFactorNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.txtFactorNumber, "txtFactorNumber");
            this.txtFactorNumber.Name = "txtFactorNumber";
            this.txtFactorNumber.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDate
            // 
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Name = "txtDate";
            this.txtDate.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbFactorKind
            // 
            this.cbFactorKind.BackColor = System.Drawing.SystemColors.Window;
            this.cbFactorKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFactorKind.FormattingEnabled = true;
            this.cbFactorKind.Items.AddRange(new object[] {
            resources.GetString("cbFactorKind.Items"),
            resources.GetString("cbFactorKind.Items1")});
            resources.ApplyResources(this.cbFactorKind, "cbFactorKind");
            this.cbFactorKind.Name = "cbFactorKind";
            // 
            // btnSubmit
            // 
            resources.ApplyResources(this.btnSubmit, "btnSubmit");
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnCancell
            // 
            resources.ApplyResources(this.btnCancell, "btnCancell");
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.UseVisualStyleBackColor = true;
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Name = "txtDescription";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txtTransport
            // 
            resources.ApplyResources(this.txtTransport, "txtTransport");
            this.txtTransport.Name = "txtTransport";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtTransportPrice
            // 
            resources.ApplyResources(this.txtTransportPrice, "txtTransportPrice");
            this.txtTransportPrice.Name = "txtTransportPrice";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // btnShowFactor
            // 
            resources.ApplyResources(this.btnShowFactor, "btnShowFactor");
            this.btnShowFactor.Name = "btnShowFactor";
            this.btnShowFactor.UseVisualStyleBackColor = true;
            // 
            // dgFactor
            // 
            this.dgFactor.AllowUserToAddRows = false;
            this.dgFactor.AllowUserToDeleteRows = false;
            this.dgFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FactorID,
            this.ProductID,
            this.PName,
            this.Number,
            this.UnitPrice,
            this.OfferPrice,
            this.TotalPrice,
            this.FactorKind});
            resources.ApplyResources(this.dgFactor, "dgFactor");
            this.dgFactor.Name = "dgFactor";
            this.dgFactor.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblOff);
            this.groupBox1.Controls.Add(this.lblTax);
            this.groupBox1.Controls.Add(this.lblTransportPrice);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblTotal
            // 
            resources.ApplyResources(this.lblTotal, "lblTotal");
            this.lblTotal.Name = "lblTotal";
            // 
            // lblOff
            // 
            resources.ApplyResources(this.lblOff, "lblOff");
            this.lblOff.Name = "lblOff";
            // 
            // lblTax
            // 
            resources.ApplyResources(this.lblTax, "lblTax");
            this.lblTax.Name = "lblTax";
            // 
            // lblTransportPrice
            // 
            resources.ApplyResources(this.lblTransportPrice, "lblTransportPrice");
            this.lblTransportPrice.Name = "lblTransportPrice";
            // 
            // lblPrice
            // 
            resources.ApplyResources(this.lblPrice, "lblPrice");
            this.lblPrice.Name = "lblPrice";
            // 
            // btnAddProduct
            // 
            resources.ApplyResources(this.btnAddProduct, "btnAddProduct");
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FactorID
            // 
            this.FactorID.DataPropertyName = "FactorID";
            resources.ApplyResources(this.FactorID, "FactorID");
            this.FactorID.Name = "FactorID";
            this.FactorID.ReadOnly = true;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            resources.ApplyResources(this.ProductID, "ProductID");
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // PName
            // 
            this.PName.DataPropertyName = "ProductName";
            resources.ApplyResources(this.PName, "PName");
            this.PName.Name = "PName";
            this.PName.ReadOnly = true;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            resources.ApplyResources(this.Number, "Number");
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            resources.ApplyResources(this.UnitPrice, "UnitPrice");
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // OfferPrice
            // 
            this.OfferPrice.DataPropertyName = "OfferPrice";
            resources.ApplyResources(this.OfferPrice, "OfferPrice");
            this.OfferPrice.Name = "OfferPrice";
            this.OfferPrice.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            resources.ApplyResources(this.TotalPrice, "TotalPrice");
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // FactorKind
            // 
            this.FactorKind.DataPropertyName = "FactorKind";
            resources.ApplyResources(this.FactorKind, "FactorKind");
            this.FactorKind.Name = "FactorKind";
            this.FactorKind.ReadOnly = true;
            // 
            // NewSaleForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgFactor);
            this.Controls.Add(this.btnShowFactor);
            this.Controls.Add(this.txtTransportPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTransport);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbFactorKind);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFactorNumber);
            this.Controls.Add(this.label1);
            this.Name = "NewSaleForm";
            this.Load += new System.EventHandler(this.NewSaleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTransportPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFactor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFactorNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFactorKind;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtTransportPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnShowFactor;
        private System.Windows.Forms.DataGridView dgFactor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTransportPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OfferPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn FactorKind;
    }
}