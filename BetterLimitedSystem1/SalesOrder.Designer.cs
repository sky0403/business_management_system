namespace BetterLimitedSystem1
{
    partial class SalesOrder
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SalesOrderView = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchByDate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenumenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(25, 30);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 38);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnCreate.Location = new System.Drawing.Point(28, 598);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(233, 49);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create Order";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtSearch.Location = new System.Drawing.Point(184, 80);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(614, 33);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.Text = "Search...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // SalesOrderView
            // 
            this.SalesOrderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesOrderView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SalesOrderView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalesOrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesOrderView.Location = new System.Drawing.Point(25, 122);
            this.SalesOrderView.Margin = new System.Windows.Forms.Padding(4);
            this.SalesOrderView.Name = "SalesOrderView";
            this.SalesOrderView.RowHeadersWidth = 51;
            this.SalesOrderView.RowTemplate.Height = 24;
            this.SalesOrderView.Size = new System.Drawing.Size(1004, 466);
            this.SalesOrderView.TabIndex = 18;
            this.SalesOrderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesOrderView_CellContentClick);
            this.SalesOrderView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesOrderView_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(808, 80);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search Order";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "Order ID",
            "Customer Email"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(28, 80);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(147, 33);
            this.comboBoxSearchBy.TabIndex = 21;
            this.comboBoxSearchBy.Text = "Order ID";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(918, 80);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 33);
            this.btnRefresh.TabIndex = 57;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(511, 45);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(113, 27);
            this.dtpFromDate.TabIndex = 58;
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(677, 45);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(121, 27);
            this.dtpToDate.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(632, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "To";
            // 
            // btnSearchByDate
            // 
            this.btnSearchByDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearchByDate.Location = new System.Drawing.Point(808, 40);
            this.btnSearchByDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchByDate.Name = "btnSearchByDate";
            this.btnSearchByDate.Size = new System.Drawing.Size(100, 33);
            this.btnSearchByDate.TabIndex = 61;
            this.btnSearchByDate.Text = "Search Order";
            this.btnSearchByDate.UseVisualStyleBackColor = true;
            this.btnSearchByDate.Click += new System.EventHandler(this.btnSearchByDate_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenumenuItem
            // 
            this.MenumenuItem.Name = "MenumenuItem";
            this.MenumenuItem.Size = new System.Drawing.Size(63, 24);
            this.MenumenuItem.Text = "Menu";
            this.MenumenuItem.Click += new System.EventHandler(this.MenumenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            this.inventoryToolStripMenuItem.Click += new System.EventHandler(this.inventoryToolStripMenuItem_Click);
            // 
            // deliveryAndInstallationManagementToolStripMenuItem
            // 
            this.deliveryAndInstallationManagementToolStripMenuItem.Name = "deliveryAndInstallationManagementToolStripMenuItem";
            this.deliveryAndInstallationManagementToolStripMenuItem.Size = new System.Drawing.Size(191, 24);
            this.deliveryAndInstallationManagementToolStripMenuItem.Text = "Delivery and Installation";
            this.deliveryAndInstallationManagementToolStripMenuItem.Click += new System.EventHandler(this.deliveryAndInstallationManagementToolStripMenuItem_Click);
            // 
            // purchaseOrderListToolStripMenuItem
            // 
            this.purchaseOrderListToolStripMenuItem.Name = "purchaseOrderListToolStripMenuItem";
            this.purchaseOrderListToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.purchaseOrderListToolStripMenuItem.Text = "Purchase Order List";
            this.purchaseOrderListToolStripMenuItem.Click += new System.EventHandler(this.purchaseOrderListToolStripMenuItem_Click);
            // 
            // staffListToolStripMenuItem
            // 
            this.staffListToolStripMenuItem.Name = "staffListToolStripMenuItem";
            this.staffListToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.staffListToolStripMenuItem.Text = "Staff List";
            this.staffListToolStripMenuItem.Click += new System.EventHandler(this.staffListToolStripMenuItem_Click);
            // 
            // createMemoToolStripMenuItem
            // 
            this.createMemoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.createMemoToolStripMenuItem.Name = "createMemoToolStripMenuItem";
            this.createMemoToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.createMemoToolStripMenuItem.Text = "Create Memo";
            this.createMemoToolStripMenuItem.Click += new System.EventHandler(this.createMemoToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 668);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSearchByDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.SalesOrderView);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesOrder";
            this.Text = "Sales Order";
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            this.Enter += new System.EventHandler(this.txtSearch_Leave);
            this.Leave += new System.EventHandler(this.txtSearch_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.SalesOrderView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView SalesOrderView;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchByDate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenumenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderListToolStripMenuItem;
    }
}