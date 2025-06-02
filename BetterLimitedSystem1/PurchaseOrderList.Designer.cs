namespace BetterLimitedSystem1
{
    partial class PurchaseOrderList
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.PurchaseOrderView = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(918, 111);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 33);
            this.btnRefresh.TabIndex = 67;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Purchase Order ID",
            "Supplier ID",
            "Status"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(25, 112);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(224, 33);
            this.comboBoxSearchBy.TabIndex = 66;
            this.comboBoxSearchBy.Text = "Purchase Order ID";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(808, 111);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search Order";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // PurchaseOrderView
            // 
            this.PurchaseOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchaseOrderView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PurchaseOrderView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.PurchaseOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseOrderView.Location = new System.Drawing.Point(25, 153);
            this.PurchaseOrderView.Margin = new System.Windows.Forms.Padding(4);
            this.PurchaseOrderView.Name = "PurchaseOrderView";
            this.PurchaseOrderView.RowHeadersWidth = 51;
            this.PurchaseOrderView.RowTemplate.Height = 24;
            this.PurchaseOrderView.Size = new System.Drawing.Size(1004, 466);
            this.PurchaseOrderView.TabIndex = 64;
            this.PurchaseOrderView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PurchaseOrderView_CellDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(258, 111);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(540, 33);
            this.txtSearch.TabIndex = 63;
            this.txtSearch.Text = "Search...";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(25, 61);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 38);
            this.btnBack.TabIndex = 62;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.deliveryAndInstallationManagementToolStripMenuItem,
            this.purchaseOrderListToolStripMenuItem,
            this.staffListToolStripMenuItem,
            this.createMemoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1059, 27);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
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
            // PurchaseOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 645);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.PurchaseOrderView);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Name = "PurchaseOrderList";
            this.Text = "PurchaseOrderList";
            this.Load += new System.EventHandler(this.PurchaseOrderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseOrderView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView PurchaseOrderView;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}