namespace BetterLimitedSystem1
{
    partial class StaffList
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
            this.StaffView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenumenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnLock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StaffView
            // 
            this.StaffView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StaffView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StaffView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffView.Location = new System.Drawing.Point(16, 80);
            this.StaffView.Margin = new System.Windows.Forms.Padding(4);
            this.StaffView.Name = "StaffView";
            this.StaffView.ReadOnly = true;
            this.StaffView.RowHeadersWidth = 51;
            this.StaffView.RowTemplate.Height = 24;
            this.StaffView.Size = new System.Drawing.Size(1235, 514);
            this.StaffView.TabIndex = 0;
            this.StaffView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StaffView_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(16, 31);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 38);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(865, 609);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1267, 27);
            this.menuStrip1.TabIndex = 63;
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
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnDelete.Location = new System.Drawing.Point(1072, 609);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(179, 38);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnLock.Location = new System.Drawing.Point(16, 609);
            this.btnLock.Margin = new System.Windows.Forms.Padding(4);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(179, 38);
            this.btnLock.TabIndex = 65;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnLock
            // 
            this.btnUnLock.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnUnLock.Location = new System.Drawing.Point(222, 609);
            this.btnUnLock.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnLock.Name = "btnUnLock";
            this.btnUnLock.Size = new System.Drawing.Size(179, 38);
            this.btnUnLock.TabIndex = 66;
            this.btnUnLock.Text = "UnLock";
            this.btnUnLock.UseVisualStyleBackColor = true;
            this.btnUnLock.Click += new System.EventHandler(this.btnUnLock_Click);
            // 
            // StaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 660);
            this.Controls.Add(this.btnUnLock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.StaffView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffList";
            this.Text = "StaffList";
            this.Load += new System.EventHandler(this.StaffList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StaffView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StaffView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenumenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnLock;
    }
}