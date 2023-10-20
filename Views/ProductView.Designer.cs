namespace Supermarket_mvp.Views
{
    partial class ProductView
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
            PanelProduct = new Panel();
            pictureBox1 = new PictureBox();
            LblProduct = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            LblSearch = new Label();
            tabPageProductDetail = new TabPage();
            LblCategoryId = new Label();
            TxtProductStock = new TextBox();
            TxtProductPrice = new TextBox();
            LblProductPrice = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            LblProductStock = new Label();
            TxtProductName = new TextBox();
            LblProductName = new Label();
            TxtProductId = new TextBox();
            LblProductId = new Label();
            TxtCategoryId = new TextBox();
            PanelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // PanelProduct
            // 
            PanelProduct.Controls.Add(pictureBox1);
            PanelProduct.Controls.Add(LblProduct);
            PanelProduct.Dock = DockStyle.Top;
            PanelProduct.Location = new Point(0, 0);
            PanelProduct.Name = "PanelProduct";
            PanelProduct.Size = new Size(800, 100);
            PanelProduct.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LblProduct
            // 
            LblProduct.AutoSize = true;
            LblProduct.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LblProduct.Location = new Point(114, 30);
            LblProduct.Name = "LblProduct";
            LblProduct.Size = new Size(145, 37);
            LblProduct.TabIndex = 0;
            LblProduct.Text = "PRODUCT";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 2;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnSearch);
            tabPageProductList.Controls.Add(TxtSearch);
            tabPageProductList.Controls.Add(LblSearch);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 322);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(582, 247);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(199, 62);
            BtnClose.TabIndex = 15;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(582, 179);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(199, 62);
            BtnDelete.TabIndex = 14;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(582, 111);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(199, 62);
            BtnEdit.TabIndex = 13;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(582, 43);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(199, 62);
            BtnNew.TabIndex = 12;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.AllowUserToAddRows = false;
            DgProduct.AllowUserToDeleteRows = false;
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(11, 71);
            DgProduct.Name = "DgProduct";
            DgProduct.ReadOnly = true;
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(542, 240);
            DgProduct.TabIndex = 11;
            // 
            // BtnSearch
            // 
            BtnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(508, 28);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(47, 37);
            BtnSearch.TabIndex = 10;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearch.Location = new Point(13, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(478, 23);
            TxtSearch.TabIndex = 9;
            // 
            // LblSearch
            // 
            LblSearch.AutoSize = true;
            LblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblSearch.Location = new Point(11, 11);
            LblSearch.Name = "LblSearch";
            LblSearch.Size = new Size(92, 15);
            LblSearch.TabIndex = 8;
            LblSearch.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtCategoryId);
            tabPageProductDetail.Controls.Add(LblCategoryId);
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(LblProductPrice);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(LblProductStock);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(LblProductName);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(LblProductId);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 322);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // LblCategoryId
            // 
            LblCategoryId.AutoSize = true;
            LblCategoryId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblCategoryId.Location = new Point(380, 128);
            LblCategoryId.Name = "LblCategoryId";
            LblCategoryId.Size = new Size(71, 15);
            LblCategoryId.TabIndex = 19;
            LblCategoryId.Text = "Category Id";
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(6, 146);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.PlaceholderText = "Product Stock";
            TxtProductStock.Size = new Size(354, 23);
            TxtProductStock.TabIndex = 18;
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(380, 86);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.PlaceholderText = "Product Price";
            TxtProductPrice.Size = new Size(354, 23);
            TxtProductPrice.TabIndex = 17;
            // 
            // LblProductPrice
            // 
            LblProductPrice.AutoSize = true;
            LblProductPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblProductPrice.Location = new Point(380, 68);
            LblProductPrice.Name = "LblProductPrice";
            LblProductPrice.Size = new Size(82, 15);
            LblProductPrice.TabIndex = 16;
            LblProductPrice.Text = "Product Price";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(380, 206);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(161, 74);
            BtnCancel.TabIndex = 15;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(199, 206);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(161, 74);
            BtnSave.TabIndex = 14;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // LblProductStock
            // 
            LblProductStock.AutoSize = true;
            LblProductStock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblProductStock.Location = new Point(6, 128);
            LblProductStock.Name = "LblProductStock";
            LblProductStock.Size = new Size(86, 15);
            LblProductStock.TabIndex = 12;
            LblProductStock.Text = "Product Stock";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(6, 86);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.PlaceholderText = "Product Name";
            TxtProductName.Size = new Size(354, 23);
            TxtProductName.TabIndex = 11;
            // 
            // LblProductName
            // 
            LblProductName.AutoSize = true;
            LblProductName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblProductName.Location = new Point(6, 68);
            LblProductName.Name = "LblProductName";
            LblProductName.Size = new Size(87, 15);
            LblProductName.TabIndex = 10;
            LblProductName.Text = "Product Name";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(6, 30);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.ReadOnly = true;
            TxtProductId.Size = new Size(183, 23);
            TxtProductId.TabIndex = 9;
            TxtProductId.Text = "0";
            TxtProductId.TextAlign = HorizontalAlignment.Right;
            // 
            // LblProductId
            // 
            LblProductId.AutoSize = true;
            LblProductId.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblProductId.Location = new Point(6, 12);
            LblProductId.Name = "LblProductId";
            LblProductId.Size = new Size(65, 15);
            LblProductId.TabIndex = 8;
            LblProductId.Text = "Product Id";
            // 
            // TxtCategoryId
            // 
            TxtCategoryId.Location = new Point(380, 146);
            TxtCategoryId.Name = "TxtCategoryId";
            TxtCategoryId.PlaceholderText = "Category Id";
            TxtCategoryId.Size = new Size(354, 23);
            TxtCategoryId.TabIndex = 21;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(PanelProduct);
            Name = "ProductView";
            Text = "ProductView";
            PanelProduct.ResumeLayout(false);
            PanelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelProduct;
        private PictureBox pictureBox1;
        private Label LblProduct;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label LblSearch;
        private Label LblCategoryId;
        private TextBox TxtProductStock;
        private TextBox TxtProductPrice;
        private Label LblProductPrice;
        private Button BtnCancel;
        private Button BtnSave;
        private Label LblProductStock;
        private TextBox TxtProductName;
        private Label LblProductName;
        private TextBox TxtProductId;
        private Label LblProductId;
        private TextBox TxtCategoryId;
    }
}