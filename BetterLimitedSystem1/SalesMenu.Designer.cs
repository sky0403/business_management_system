namespace BetterLimitedSystem1
{
    partial class SalesMenu
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
            this.components = new System.ComponentModel.Container();
            this.btnSalesOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.btnDeliveryInstallation = new System.Windows.Forms.Button();
            this.btnStaffList = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.RTB_Memo = new System.Windows.Forms.RichTextBox();
            this.lb_Time = new System.Windows.Forms.Label();
            this.TodayTimer = new System.Windows.Forms.Timer(this.components);
            this.lb_Date = new System.Windows.Forms.Label();
            this.btn_Memo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPurchaseList = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.RTB_Alert = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalesOrder
            // 
            this.btnSalesOrder.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSalesOrder.Location = new System.Drawing.Point(40, 80);
            this.btnSalesOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalesOrder.Name = "btnSalesOrder";
            this.btnSalesOrder.Size = new System.Drawing.Size(258, 56);
            this.btnSalesOrder.TabIndex = 11;
            this.btnSalesOrder.Text = "Order";
            this.btnSalesOrder.UseVisualStyleBackColor = true;
            this.btnSalesOrder.Click += new System.EventHandler(this.btnSalesOrder_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnInventory.Location = new System.Drawing.Point(40, 144);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(258, 50);
            this.btnInventory.TabIndex = 12;
            this.btnInventory.Text = "Inventory Management";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Logout.Location = new System.Drawing.Point(40, 555);
            this.Logout.Margin = new System.Windows.Forms.Padding(4);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(258, 52);
            this.Logout.TabIndex = 13;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnDeliveryInstallation
            // 
            this.btnDeliveryInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnDeliveryInstallation.Location = new System.Drawing.Point(40, 202);
            this.btnDeliveryInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeliveryInstallation.Name = "btnDeliveryInstallation";
            this.btnDeliveryInstallation.Size = new System.Drawing.Size(258, 79);
            this.btnDeliveryInstallation.TabIndex = 17;
            this.btnDeliveryInstallation.Text = "Delivery and Installation Management";
            this.btnDeliveryInstallation.UseVisualStyleBackColor = true;
            this.btnDeliveryInstallation.Click += new System.EventHandler(this.btnDeliveryInstallation_Click);
            // 
            // btnStaffList
            // 
            this.btnStaffList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnStaffList.Location = new System.Drawing.Point(40, 421);
            this.btnStaffList.Margin = new System.Windows.Forms.Padding(4);
            this.btnStaffList.Name = "btnStaffList";
            this.btnStaffList.Size = new System.Drawing.Size(258, 58);
            this.btnStaffList.TabIndex = 18;
            this.btnStaffList.Text = "StaffList";
            this.btnStaffList.UseVisualStyleBackColor = true;
            this.btnStaffList.Click += new System.EventHandler(this.btnStaffList_Click);
            // 
            // RTB_Memo
            // 
            this.RTB_Memo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RTB_Memo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Memo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.RTB_Memo.Location = new System.Drawing.Point(315, 289);
            this.RTB_Memo.Name = "RTB_Memo";
            this.RTB_Memo.ReadOnly = true;
            this.RTB_Memo.Size = new System.Drawing.Size(706, 318);
            this.RTB_Memo.TabIndex = 21;
            this.RTB_Memo.Text = "";
            // 
            // lb_Time
            // 
            this.lb_Time.AutoSize = true;
            this.lb_Time.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.lb_Time.Location = new System.Drawing.Point(885, 53);
            this.lb_Time.Name = "lb_Time";
            this.lb_Time.Size = new System.Drawing.Size(0, 25);
            this.lb_Time.TabIndex = 22;
            // 
            // TodayTimer
            // 
            this.TodayTimer.Enabled = true;
            this.TodayTimer.Interval = 1000;
            this.TodayTimer.Tick += new System.EventHandler(this.TodayTimer_Tick);
            // 
            // lb_Date
            // 
            this.lb_Date.AutoSize = true;
            this.lb_Date.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.lb_Date.Location = new System.Drawing.Point(732, 53);
            this.lb_Date.Name = "lb_Date";
            this.lb_Date.Size = new System.Drawing.Size(0, 25);
            this.lb_Date.TabIndex = 23;
            // 
            // btn_Memo
            // 
            this.btn_Memo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_Memo.Location = new System.Drawing.Point(40, 495);
            this.btn_Memo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Memo.Name = "btn_Memo";
            this.btn_Memo.Size = new System.Drawing.Size(258, 52);
            this.btn_Memo.TabIndex = 24;
            this.btn_Memo.Text = "Create Memo";
            this.btn_Memo.UseVisualStyleBackColor = true;
            this.btn_Memo.Click += new System.EventHandler(this.btn_Memo_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1093, 27);
            this.menuStrip1.TabIndex = 25;
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
            // btnPurchaseList
            // 
            this.btnPurchaseList.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnPurchaseList.Location = new System.Drawing.Point(40, 289);
            this.btnPurchaseList.Margin = new System.Windows.Forms.Padding(4);
            this.btnPurchaseList.Name = "btnPurchaseList";
            this.btnPurchaseList.Size = new System.Drawing.Size(258, 58);
            this.btnPurchaseList.TabIndex = 26;
            this.btnPurchaseList.Text = "Purchase Order List";
            this.btnPurchaseList.UseVisualStyleBackColor = true;
            this.btnPurchaseList.Click += new System.EventHandler(this.btnPurchaseList_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnStatistics.Location = new System.Drawing.Point(40, 355);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(258, 58);
            this.btnStatistics.TabIndex = 27;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // RTB_Alert
            // 
            this.RTB_Alert.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RTB_Alert.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Alert.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.RTB_Alert.Location = new System.Drawing.Point(315, 80);
            this.RTB_Alert.Name = "RTB_Alert";
            this.RTB_Alert.ReadOnly = true;
            this.RTB_Alert.Size = new System.Drawing.Size(706, 203);
            this.RTB_Alert.TabIndex = 28;
            this.RTB_Alert.Text = "";
            // 
            // SalesMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 620);
            this.Controls.Add(this.RTB_Alert);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnPurchaseList);
            this.Controls.Add(this.btn_Memo);
            this.Controls.Add(this.lb_Date);
            this.Controls.Add(this.lb_Time);
            this.Controls.Add(this.RTB_Memo);
            this.Controls.Add(this.btnStaffList);
            this.Controls.Add(this.btnDeliveryInstallation);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.btnSalesOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SalesMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.SalesMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSalesOrder;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button btnDeliveryInstallation;
        private System.Windows.Forms.Button btnStaffList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox RTB_Memo;
        private System.Windows.Forms.Label lb_Time;
        private System.Windows.Forms.Timer TodayTimer;
        private System.Windows.Forms.Label lb_Date;
        private System.Windows.Forms.Button btn_Memo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderListToolStripMenuItem;
        private System.Windows.Forms.Button btnPurchaseList;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.RichTextBox RTB_Alert;
    }
}