namespace BetterLimitedSystem1
{
    partial class CreateMemo
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
            this.txtMemoID = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCreateBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Create = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenumenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliveryAndInstallationManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MemoView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMemoID
            // 
            this.txtMemoID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtMemoID.Location = new System.Drawing.Point(158, 103);
            this.txtMemoID.Margin = new System.Windows.Forms.Padding(5);
            this.txtMemoID.Name = "txtMemoID";
            this.txtMemoID.ReadOnly = true;
            this.txtMemoID.Size = new System.Drawing.Size(175, 33);
            this.txtMemoID.TabIndex = 33;
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtContent.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtContent.Location = new System.Drawing.Point(48, 153);
            this.txtContent.Margin = new System.Windows.Forms.Padding(5);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(450, 133);
            this.txtContent.TabIndex = 45;
            this.txtContent.Text = "Content....";
            this.txtContent.WordWrap = false;
            this.txtContent.Enter += new System.EventHandler(this.txtContent_Enter);
            this.txtContent.Leave += new System.EventHandler(this.txtContent_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F);
            this.label1.Location = new System.Drawing.Point(352, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 50);
            this.label1.TabIndex = 46;
            this.label1.Text = "Memo";
            // 
            // txtCreateBy
            // 
            this.txtCreateBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtCreateBy.Location = new System.Drawing.Point(92, 315);
            this.txtCreateBy.Margin = new System.Windows.Forms.Padding(5);
            this.txtCreateBy.Name = "txtCreateBy";
            this.txtCreateBy.ReadOnly = true;
            this.txtCreateBy.Size = new System.Drawing.Size(175, 33);
            this.txtCreateBy.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(50, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "Memo ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(50, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "By";
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_Create.Location = new System.Drawing.Point(48, 399);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(196, 52);
            this.btn_Create.TabIndex = 50;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(302, 399);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(196, 52);
            this.btn_Cancel.TabIndex = 51;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(849, 27);
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
            // MemoView
            // 
            this.MemoView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.MemoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoView.Location = new System.Drawing.Point(536, 153);
            this.MemoView.Name = "MemoView";
            this.MemoView.ReadOnly = true;
            this.MemoView.RowHeadersWidth = 51;
            this.MemoView.RowTemplate.Height = 27;
            this.MemoView.Size = new System.Drawing.Size(301, 228);
            this.MemoView.TabIndex = 65;
            this.MemoView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MemoView_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(531, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "Memo List";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Delete.Location = new System.Drawing.Point(704, 399);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 52);
            this.Delete.TabIndex = 67;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CreateMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 480);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MemoView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCreateBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtMemoID);
            this.Name = "CreateMemo";
            this.Text = "CreateMemo";
            this.Load += new System.EventHandler(this.CreateMemo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemoID;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCreateBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenumenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliveryAndInstallationManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DataGridView MemoView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Delete;
    }
}