namespace BetterLimitedSystem1
{
    partial class Inventory
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
            this.btnBack = new System.Windows.Forms.Button();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btn_SupplierList = new System.Windows.Forms.Button();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenumenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btn_GoodsReturn = new System.Windows.Forms.Button();
            this.btnInwardsRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(13, 56);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 38);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ProductView
            // 
            this.ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(13, 146);
            this.ProductView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductView.Name = "ProductView";
            this.ProductView.ReadOnly = true;
            this.ProductView.RowHeadersWidth = 51;
            this.ProductView.RowTemplate.Height = 24;
            this.ProductView.Size = new System.Drawing.Size(1253, 359);
            this.ProductView.TabIndex = 43;
            this.ProductView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductView_CellContentClick);
            this.ProductView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductView_CellDoubleClick);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnAddProduct.Location = new System.Drawing.Point(1045, 529);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(219, 68);
            this.btnAddProduct.TabIndex = 44;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(1122, 103);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 32);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btn_SupplierList
            // 
            this.btn_SupplierList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_SupplierList.Location = new System.Drawing.Point(13, 529);
            this.btn_SupplierList.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SupplierList.Name = "btn_SupplierList";
            this.btn_SupplierList.Size = new System.Drawing.Size(166, 68);
            this.btn_SupplierList.TabIndex = 46;
            this.btn_SupplierList.Text = "Supplier List";
            this.btn_SupplierList.UseVisualStyleBackColor = true;
            this.btn_SupplierList.Click += new System.EventHandler(this.btn_SupplierList_Click);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "All",
            "Product ID",
            "Product Name",
            "Supplier"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(16, 104);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(274, 33);
            this.comboBoxSearchBy.TabIndex = 49;
            this.comboBoxSearchBy.Text = "All";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(969, 104);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 33);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(299, 104);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(640, 33);
            this.txtSearch.TabIndex = 47;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenumenuItem,
            this.orderToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.deliveryAndInstallationManagementToolStripMenuItem,
            this.purchaseOrderListToolStripMenuItem,
            this.staffListToolStripMenuItem,
            this.createMemoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1278, 27);
            this.menuStrip1.TabIndex = 64;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenumenuItem
            // 
            this.MenumenuItem.Name = "MenumenuItem";
            this.MenumenuItem.Size = new System.Drawing.Size(63, 23);
            this.MenumenuItem.Text = "Menu";
            this.MenumenuItem.Click += new System.EventHandler(this.MenumenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(65, 23);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // deliveryAndInstallationManagementToolStripMenuItem
            // 
            this.deliveryAndInstallationManagementToolStripMenuItem.Name = "deliveryAndInstallationManagementToolStripMenuItem";
            this.deliveryAndInstallationManagementToolStripMenuItem.Size = new System.Drawing.Size(191, 23);
            this.deliveryAndInstallationManagementToolStripMenuItem.Text = "Delivery and Installation";
            this.deliveryAndInstallationManagementToolStripMenuItem.Click += new System.EventHandler(this.deliveryAndInstallationManagementToolStripMenuItem_Click);
            // 
            // purchaseOrderListToolStripMenuItem
            // 
            this.purchaseOrderListToolStripMenuItem.Name = "purchaseOrderListToolStripMenuItem";
            this.purchaseOrderListToolStripMenuItem.Size = new System.Drawing.Size(160, 23);
            this.purchaseOrderListToolStripMenuItem.Text = "Purchase Order List";
            this.purchaseOrderListToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderListToolStripMenuItem_Click);
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(83, 23);
            this.staffListToolStripMenuItem.Text = "Staff List";
            this.staffListToolStripMenuItem.Click += new System.EventHandler(this.staffListToolStripMenuItem_Click);
            // 
            // createMemoToolStripMenuItem
            // 
            this.createMemoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createMemoToolStripMenuItem.Name = "createMemoToolStripMenuItem";
            this.createMemoToolStripMenuItem.Size = new System.Drawing.Size(117, 23);
            this.createMemoToolStripMenuItem.Text = "Create Memo";
            this.createMemoToolStripMenuItem.Click += new System.EventHandler(this.createMemoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(80, 23);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnPurchase.Location = new System.Drawing.Point(438, 529);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(219, 68);
            this.btnPurchase.TabIndex = 65;
            this.btnPurchase.Text = "Purchase Goods";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btn_GoodsReturn
            // 
            this.btn_GoodsReturn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_GoodsReturn.Location = new System.Drawing.Point(202, 529);
            this.btn_GoodsReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GoodsReturn.Name = "btn_GoodsReturn";
            this.btn_GoodsReturn.Size = new System.Drawing.Size(219, 68);
            this.btn_GoodsReturn.TabIndex = 66;
            this.btn_GoodsReturn.Text = "Goods Return";
            this.btn_GoodsReturn.UseVisualStyleBackColor = true;
            this.btn_GoodsReturn.Click += new System.EventHandler(this.btn_GoodsReturn_Click);
            // 
            // btnInwardsRecord
            // 
            this.btnInwardsRecord.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnInwardsRecord.Location = new System.Drawing.Point(809, 529);
            this.btnInwardsRecord.Margin = new System.Windows.Forms.Padding(4);
            this.btnInwardsRecord.Name = "btnInwardsRecord";
            this.btnInwardsRecord.Size = new System.Drawing.Size(219, 68);
            this.btnInwardsRecord.TabIndex = 71;
            this.btnInwardsRecord.Text = "Inwards Record";
            this.btnInwardsRecord.UseVisualStyleBackColor = true;
            this.btnInwardsRecord.Click += new System.EventHandler(this.btnInwardsRecord_Click);
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 610);
            this.Controls.Add(this.btnInwardsRecord);
            this.Controls.Add(this.btn_GoodsReturn);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btn_SupplierList);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.btnBack);
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Inventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddProduct;
        public System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btn_SupplierList;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenumenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btn_GoodsReturn;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderListToolStripMenuItem;
        private System.Windows.Forms.Button btnInwardsRecord;
    }
}