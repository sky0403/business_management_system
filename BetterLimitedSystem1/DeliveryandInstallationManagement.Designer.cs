namespace BetterLimitedSystem1
{
    partial class DeliveryandInstallationManagement
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
            this.DeliveryView = new System.Windows.Forms.DataGridView();
            this.InstallationView = new System.Windows.Forms.DataGridView();
            this.btnSearchDelivery = new System.Windows.Forms.Button();
            this.btnSearchInstallation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateDailyInstallation = new System.Windows.Forms.Button();
            this.btnGenerateDailyDelivery = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenumenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbDeliverySearch = new System.Windows.Forms.ComboBox();
            this.txtSearchDelivery = new System.Windows.Forms.TextBox();
            this.cbInstallationSearch = new System.Windows.Forms.ComboBox();
            this.txtSearchInstallation = new System.Windows.Forms.TextBox();
            this.btnFinishDelivery = new System.Windows.Forms.Button();
            this.btnFinishInstallation = new System.Windows.Forms.Button();
            this.btnRefreshDelivery = new System.Windows.Forms.Button();
            this.btnRefreshInstallation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryView
            // 
            this.DeliveryView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeliveryView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DeliveryView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeliveryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryView.Location = new System.Drawing.Point(13, 172);
            this.DeliveryView.Name = "DeliveryView";
            this.DeliveryView.ReadOnly = true;
            this.DeliveryView.RowHeadersWidth = 51;
            this.DeliveryView.RowTemplate.Height = 27;
            this.DeliveryView.Size = new System.Drawing.Size(1412, 300);
            this.DeliveryView.TabIndex = 0;
            this.DeliveryView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryView_CellDoubleClick);
            // 
            // InstallationView
            // 
            this.InstallationView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InstallationView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.InstallationView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.InstallationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstallationView.Location = new System.Drawing.Point(17, 642);
            this.InstallationView.Name = "InstallationView";
            this.InstallationView.ReadOnly = true;
            this.InstallationView.RowHeadersWidth = 51;
            this.InstallationView.RowTemplate.Height = 27;
            this.InstallationView.Size = new System.Drawing.Size(1409, 326);
            this.InstallationView.TabIndex = 1;
            this.InstallationView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstallationView_CellContentClick);
            this.InstallationView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InstallationView_CellDoubleClick);
            // 
            // btnSearchDelivery
            // 
            this.btnSearchDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearchDelivery.Location = new System.Drawing.Point(1094, 119);
            this.btnSearchDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchDelivery.Name = "btnSearchDelivery";
            this.btnSearchDelivery.Size = new System.Drawing.Size(154, 38);
            this.btnSearchDelivery.TabIndex = 44;
            this.btnSearchDelivery.Text = "Search";
            this.btnSearchDelivery.UseVisualStyleBackColor = true;
            this.btnSearchDelivery.Click += new System.EventHandler(this.btnSearchDelivery_Click);
            // 
            // btnSearchInstallation
            // 
            this.btnSearchInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearchInstallation.Location = new System.Drawing.Point(1110, 594);
            this.btnSearchInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchInstallation.Name = "btnSearchInstallation";
            this.btnSearchInstallation.Size = new System.Drawing.Size(138, 38);
            this.btnSearchInstallation.TabIndex = 45;
            this.btnSearchInstallation.Text = "Search";
            this.btnSearchInstallation.UseVisualStyleBackColor = true;
            this.btnSearchInstallation.Click += new System.EventHandler(this.btnSearchInstallation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Delivery Order List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 541);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Installation Order List";
            // 
            // btnGenerateDailyInstallation
            // 
            this.btnGenerateDailyInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnGenerateDailyInstallation.Location = new System.Drawing.Point(17, 978);
            this.btnGenerateDailyInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateDailyInstallation.Name = "btnGenerateDailyInstallation";
            this.btnGenerateDailyInstallation.Size = new System.Drawing.Size(386, 38);
            this.btnGenerateDailyInstallation.TabIndex = 50;
            this.btnGenerateDailyInstallation.Text = "Generate Daily Installation List";
            this.btnGenerateDailyInstallation.UseVisualStyleBackColor = true;
            this.btnGenerateDailyInstallation.Click += new System.EventHandler(this.btnGenerateDailyInstallation_Click);
            // 
            // btnGenerateDailyDelivery
            // 
            this.btnGenerateDailyDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnGenerateDailyDelivery.Location = new System.Drawing.Point(14, 489);
            this.btnGenerateDailyDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerateDailyDelivery.Name = "btnGenerateDailyDelivery";
            this.btnGenerateDailyDelivery.Size = new System.Drawing.Size(380, 38);
            this.btnGenerateDailyDelivery.TabIndex = 51;
            this.btnGenerateDailyDelivery.Text = "Generate Daily Delivery List";
            this.btnGenerateDailyDelivery.UseVisualStyleBackColor = true;
            this.btnGenerateDailyDelivery.Click += new System.EventHandler(this.btnGenerateDailyDeveliery_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenumenuItem,
            this.orderToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.deliveryAndInstallationManagementToolStripMenuItem,
            this.staffListToolStripMenuItem,
            this.createMemoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1438, 27);
            this.menuStrip1.TabIndex = 65;
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
            // cbDeliverySearch
            // 
            this.cbDeliverySearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbDeliverySearch.FormattingEnabled = true;
            this.cbDeliverySearch.Items.AddRange(new object[] {
            "Order ID",
            "Delivery ID",
            "Delivery Work Man",
            "Status"});
            this.cbDeliverySearch.Location = new System.Drawing.Point(14, 123);
            this.cbDeliverySearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeliverySearch.Name = "cbDeliverySearch";
            this.cbDeliverySearch.Size = new System.Drawing.Size(309, 33);
            this.cbDeliverySearch.TabIndex = 67;
            this.cbDeliverySearch.Text = "Order ID";
            // 
            // txtSearchDelivery
            // 
            this.txtSearchDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSearchDelivery.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchDelivery.Location = new System.Drawing.Point(332, 123);
            this.txtSearchDelivery.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchDelivery.Name = "txtSearchDelivery";
            this.txtSearchDelivery.Size = new System.Drawing.Size(753, 33);
            this.txtSearchDelivery.TabIndex = 66;
            this.txtSearchDelivery.Text = "Search...";
            this.txtSearchDelivery.Enter += new System.EventHandler(this.txtSearchDelivery_Enter);
            this.txtSearchDelivery.Leave += new System.EventHandler(this.txtSearchDelivery_Leave);
            // 
            // cbInstallationSearch
            // 
            this.cbInstallationSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbInstallationSearch.FormattingEnabled = true;
            this.cbInstallationSearch.Items.AddRange(new object[] {
            "Order ID",
            "Installation ID",
            "Installation Work Man",
            "Status"});
            this.cbInstallationSearch.Location = new System.Drawing.Point(17, 599);
            this.cbInstallationSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbInstallationSearch.Name = "cbInstallationSearch";
            this.cbInstallationSearch.Size = new System.Drawing.Size(306, 33);
            this.cbInstallationSearch.TabIndex = 69;
            this.cbInstallationSearch.Text = "Order ID";
            // 
            // txtSearchInstallation
            // 
            this.txtSearchInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSearchInstallation.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearchInstallation.Location = new System.Drawing.Point(332, 598);
            this.txtSearchInstallation.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchInstallation.Name = "txtSearchInstallation";
            this.txtSearchInstallation.Size = new System.Drawing.Size(753, 33);
            this.txtSearchInstallation.TabIndex = 68;
            this.txtSearchInstallation.Text = "Search...";
            this.txtSearchInstallation.Enter += new System.EventHandler(this.txtSearchInstallation_Enter);
            this.txtSearchInstallation.Leave += new System.EventHandler(this.txtSearchInstallation_Leave);
            // 
            // btnFinishDelivery
            // 
            this.btnFinishDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnFinishDelivery.Location = new System.Drawing.Point(1180, 489);
            this.btnFinishDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishDelivery.Name = "btnFinishDelivery";
            this.btnFinishDelivery.Size = new System.Drawing.Size(245, 38);
            this.btnFinishDelivery.TabIndex = 70;
            this.btnFinishDelivery.Text = "Finish Delivery";
            this.btnFinishDelivery.UseVisualStyleBackColor = true;
            this.btnFinishDelivery.Click += new System.EventHandler(this.btnFinishDelivery_Click);
            // 
            // btnFinishInstallation
            // 
            this.btnFinishInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnFinishInstallation.Location = new System.Drawing.Point(1180, 978);
            this.btnFinishInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.btnFinishInstallation.Name = "btnFinishInstallation";
            this.btnFinishInstallation.Size = new System.Drawing.Size(245, 38);
            this.btnFinishInstallation.TabIndex = 71;
            this.btnFinishInstallation.Text = "Finish Installation";
            this.btnFinishInstallation.UseVisualStyleBackColor = true;
            this.btnFinishInstallation.Click += new System.EventHandler(this.btnFinishInstallation_Click);
            // 
            // btnRefreshDelivery
            // 
            this.btnRefreshDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnRefreshDelivery.Location = new System.Drawing.Point(1271, 118);
            this.btnRefreshDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshDelivery.Name = "btnRefreshDelivery";
            this.btnRefreshDelivery.Size = new System.Drawing.Size(154, 38);
            this.btnRefreshDelivery.TabIndex = 72;
            this.btnRefreshDelivery.Text = "Refresh";
            this.btnRefreshDelivery.UseVisualStyleBackColor = true;
            this.btnRefreshDelivery.Click += new System.EventHandler(this.btnRefreshDelivery_Click);
            // 
            // btnRefreshInstallation
            // 
            this.btnRefreshInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnRefreshInstallation.Location = new System.Drawing.Point(1271, 593);
            this.btnRefreshInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshInstallation.Name = "btnRefreshInstallation";
            this.btnRefreshInstallation.Size = new System.Drawing.Size(154, 38);
            this.btnRefreshInstallation.TabIndex = 73;
            this.btnRefreshInstallation.Text = "Refresh";
            this.btnRefreshInstallation.UseVisualStyleBackColor = true;
            this.btnRefreshInstallation.Click += new System.EventHandler(this.btnRefreshInstallation_Click);
            // 
            // DeliveryandInstallationManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 1029);
            this.Controls.Add(this.btnRefreshInstallation);
            this.Controls.Add(this.btnRefreshDelivery);
            this.Controls.Add(this.btnFinishInstallation);
            this.Controls.Add(this.btnFinishDelivery);
            this.Controls.Add(this.cbInstallationSearch);
            this.Controls.Add(this.txtSearchInstallation);
            this.Controls.Add(this.cbDeliverySearch);
            this.Controls.Add(this.txtSearchDelivery);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnGenerateDailyDelivery);
            this.Controls.Add(this.btnGenerateDailyInstallation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchInstallation);
            this.Controls.Add(this.btnSearchDelivery);
            this.Controls.Add(this.InstallationView);
            this.Controls.Add(this.DeliveryView);
            this.Name = "DeliveryandInstallationManagement";
            this.Text = "DeliveryandInstallationManagement";
            this.Load += new System.EventHandler(this.DeliveryandInstallationManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveryView;
        private System.Windows.Forms.DataGridView InstallationView;
        private System.Windows.Forms.Button btnSearchDelivery;
        private System.Windows.Forms.Button btnSearchInstallation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateDailyInstallation;
        private System.Windows.Forms.Button btnGenerateDailyDelivery;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenumenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbDeliverySearch;
        private System.Windows.Forms.TextBox txtSearchDelivery;
        private System.Windows.Forms.ComboBox cbInstallationSearch;
        private System.Windows.Forms.TextBox txtSearchInstallation;
        private System.Windows.Forms.Button btnFinishDelivery;
        private System.Windows.Forms.Button btnFinishInstallation;
        private System.Windows.Forms.Button btnRefreshDelivery;
        private System.Windows.Forms.Button btnRefreshInstallation;
    }
}