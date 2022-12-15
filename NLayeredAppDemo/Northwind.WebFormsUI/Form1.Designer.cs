namespace Northwind.WebFormsUI
{
    partial class Form1
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnit = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.cbxAddProductCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxAddProductUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductUnitInPrice = new System.Windows.Forms.TextBox();
            this.tbxAddProductQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.gbxUpdateProduct = new System.Windows.Forms.GroupBox();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.tbxUpdateProductQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductUnitPrice = new System.Windows.Forms.TextBox();
            this.cbxUpdateProductCategoryName = new System.Windows.Forms.ComboBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateProductQuantityPerUnit = new System.Windows.Forms.Label();
            this.lblUpdateProductUnitInStock = new System.Windows.Forms.Label();
            this.lblUpdateProductUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductCategoryName = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 245);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(776, 150);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(776, 100);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Filter by category";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(84, 41);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(322, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 41);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(29, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Filter";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Location = new System.Drawing.Point(12, 134);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(427, 100);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Search by name";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(84, 44);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(322, 20);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 47);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.btnAddProduct);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductUnitInPrice);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductUnitPrice);
            this.gbxAddProduct.Controls.Add(this.cbxAddProductCategoryName);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductName);
            this.gbxAddProduct.Controls.Add(this.lblQuantityPerUnit);
            this.gbxAddProduct.Controls.Add(this.lblStock);
            this.gbxAddProduct.Controls.Add(this.lblUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblCategoryId);
            this.gbxAddProduct.Controls.Add(this.lblAddName);
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 424);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(352, 259);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Add a Product";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(18, 36);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(35, 13);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Name";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(18, 75);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(49, 13);
            this.lblCategoryId.TabIndex = 1;
            this.lblCategoryId.Text = "Category";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(18, 109);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(18, 149);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(73, 13);
            this.lblStock.TabIndex = 3;
            this.lblStock.Text = "Units in Stock";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.AutoSize = true;
            this.lblQuantityPerUnit.Location = new System.Drawing.Point(18, 188);
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Size = new System.Drawing.Size(87, 13);
            this.lblQuantityPerUnit.TabIndex = 4;
            this.lblQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Location = new System.Drawing.Point(143, 36);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(192, 20);
            this.tbxAddProductName.TabIndex = 5;
            // 
            // cbxAddProductCategoryName
            // 
            this.cbxAddProductCategoryName.FormattingEnabled = true;
            this.cbxAddProductCategoryName.Location = new System.Drawing.Point(143, 75);
            this.cbxAddProductCategoryName.Name = "cbxAddProductCategoryName";
            this.cbxAddProductCategoryName.Size = new System.Drawing.Size(192, 21);
            this.cbxAddProductCategoryName.TabIndex = 6;
            // 
            // tbxAddProductUnitPrice
            // 
            this.tbxAddProductUnitPrice.Location = new System.Drawing.Point(143, 109);
            this.tbxAddProductUnitPrice.Name = "tbxAddProductUnitPrice";
            this.tbxAddProductUnitPrice.Size = new System.Drawing.Size(192, 20);
            this.tbxAddProductUnitPrice.TabIndex = 7;
            // 
            // tbxAddProductUnitInPrice
            // 
            this.tbxAddProductUnitInPrice.Location = new System.Drawing.Point(143, 149);
            this.tbxAddProductUnitInPrice.Name = "tbxAddProductUnitInPrice";
            this.tbxAddProductUnitInPrice.Size = new System.Drawing.Size(192, 20);
            this.tbxAddProductUnitInPrice.TabIndex = 8;
            // 
            // tbxAddProductQuantityPerUnit
            // 
            this.tbxAddProductQuantityPerUnit.Location = new System.Drawing.Point(143, 188);
            this.tbxAddProductQuantityPerUnit.Name = "tbxAddProductQuantityPerUnit";
            this.tbxAddProductQuantityPerUnit.Size = new System.Drawing.Size(192, 20);
            this.tbxAddProductQuantityPerUnit.TabIndex = 9;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAddProduct.Location = new System.Drawing.Point(143, 224);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(191, 24);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // gbxUpdateProduct
            // 
            this.gbxUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductUnitsInStock);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.cbxUpdateProductCategoryName);
            this.gbxUpdateProduct.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductQuantityPerUnit);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductUnitInStock);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductUnitPrice);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductCategoryName);
            this.gbxUpdateProduct.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdateProduct.Location = new System.Drawing.Point(436, 424);
            this.gbxUpdateProduct.Name = "gbxUpdateProduct";
            this.gbxUpdateProduct.Size = new System.Drawing.Size(352, 259);
            this.gbxUpdateProduct.TabIndex = 4;
            this.gbxUpdateProduct.TabStop = false;
            this.gbxUpdateProduct.Text = "Update a Product";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateProduct.Location = new System.Drawing.Point(143, 224);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(191, 24);
            this.btnUpdateProduct.TabIndex = 10;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // tbxUpdateProductQuantityPerUnit
            // 
            this.tbxUpdateProductQuantityPerUnit.Location = new System.Drawing.Point(143, 188);
            this.tbxUpdateProductQuantityPerUnit.Name = "tbxUpdateProductQuantityPerUnit";
            this.tbxUpdateProductQuantityPerUnit.Size = new System.Drawing.Size(192, 20);
            this.tbxUpdateProductQuantityPerUnit.TabIndex = 9;
            // 
            // tbxUpdateProductUnitsInStock
            // 
            this.tbxUpdateProductUnitsInStock.Location = new System.Drawing.Point(143, 149);
            this.tbxUpdateProductUnitsInStock.Name = "tbxUpdateProductUnitsInStock";
            this.tbxUpdateProductUnitsInStock.Size = new System.Drawing.Size(192, 20);
            this.tbxUpdateProductUnitsInStock.TabIndex = 8;
            // 
            // tbxUpdateProductUnitPrice
            // 
            this.tbxUpdateProductUnitPrice.Location = new System.Drawing.Point(143, 109);
            this.tbxUpdateProductUnitPrice.Name = "tbxUpdateProductUnitPrice";
            this.tbxUpdateProductUnitPrice.Size = new System.Drawing.Size(192, 20);
            this.tbxUpdateProductUnitPrice.TabIndex = 7;
            // 
            // cbxUpdateProductCategoryName
            // 
            this.cbxUpdateProductCategoryName.FormattingEnabled = true;
            this.cbxUpdateProductCategoryName.Location = new System.Drawing.Point(143, 75);
            this.cbxUpdateProductCategoryName.Name = "cbxUpdateProductCategoryName";
            this.cbxUpdateProductCategoryName.Size = new System.Drawing.Size(192, 21);
            this.cbxUpdateProductCategoryName.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Location = new System.Drawing.Point(143, 36);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(192, 20);
            this.tbxUpdateProductName.TabIndex = 5;
            // 
            // lblUpdateProductQuantityPerUnit
            // 
            this.lblUpdateProductQuantityPerUnit.AutoSize = true;
            this.lblUpdateProductQuantityPerUnit.Location = new System.Drawing.Point(18, 188);
            this.lblUpdateProductQuantityPerUnit.Name = "lblUpdateProductQuantityPerUnit";
            this.lblUpdateProductQuantityPerUnit.Size = new System.Drawing.Size(87, 13);
            this.lblUpdateProductQuantityPerUnit.TabIndex = 4;
            this.lblUpdateProductQuantityPerUnit.Text = "Quantity Per Unit";
            // 
            // lblUpdateProductUnitInStock
            // 
            this.lblUpdateProductUnitInStock.AutoSize = true;
            this.lblUpdateProductUnitInStock.Location = new System.Drawing.Point(18, 149);
            this.lblUpdateProductUnitInStock.Name = "lblUpdateProductUnitInStock";
            this.lblUpdateProductUnitInStock.Size = new System.Drawing.Size(73, 13);
            this.lblUpdateProductUnitInStock.TabIndex = 3;
            this.lblUpdateProductUnitInStock.Text = "Units in Stock";
            // 
            // lblUpdateProductUnitPrice
            // 
            this.lblUpdateProductUnitPrice.AutoSize = true;
            this.lblUpdateProductUnitPrice.Location = new System.Drawing.Point(18, 109);
            this.lblUpdateProductUnitPrice.Name = "lblUpdateProductUnitPrice";
            this.lblUpdateProductUnitPrice.Size = new System.Drawing.Size(53, 13);
            this.lblUpdateProductUnitPrice.TabIndex = 2;
            this.lblUpdateProductUnitPrice.Text = "Unit Price";
            // 
            // lblUpdateProductCategoryName
            // 
            this.lblUpdateProductCategoryName.AutoSize = true;
            this.lblUpdateProductCategoryName.Location = new System.Drawing.Point(18, 75);
            this.lblUpdateProductCategoryName.Name = "lblUpdateProductCategoryName";
            this.lblUpdateProductCategoryName.Size = new System.Drawing.Size(49, 13);
            this.lblUpdateProductCategoryName.TabIndex = 1;
            this.lblUpdateProductCategoryName.Text = "Category";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Location = new System.Drawing.Point(18, 36);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(35, 13);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Location = new System.Drawing.Point(579, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 714);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdateProduct);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdateProduct.ResumeLayout(false);
            this.gbxUpdateProduct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Label lblQuantityPerUnit;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tbxAddProductQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxAddProductUnitInPrice;
        private System.Windows.Forms.TextBox tbxAddProductUnitPrice;
        private System.Windows.Forms.ComboBox cbxAddProductCategoryName;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.GroupBox gbxUpdateProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TextBox tbxUpdateProductQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxUpdateProductUnitsInStock;
        private System.Windows.Forms.TextBox tbxUpdateProductUnitPrice;
        private System.Windows.Forms.ComboBox cbxUpdateProductCategoryName;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateProductQuantityPerUnit;
        private System.Windows.Forms.Label lblUpdateProductUnitInStock;
        private System.Windows.Forms.Label lblUpdateProductUnitPrice;
        private System.Windows.Forms.Label lblUpdateProductCategoryName;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Button btnDelete;
    }
}

