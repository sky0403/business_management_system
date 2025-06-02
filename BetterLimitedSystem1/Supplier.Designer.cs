namespace BetterLimitedSystem1
{
    partial class Supplier
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
            this.Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierView = new System.Windows.Forms.DataGridView();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SupplierView)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Delete.Location = new System.Drawing.Point(806, 438);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 52);
            this.Delete.TabIndex = 78;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(565, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 77;
            this.label4.Text = "Supplier List";
            // 
            // SupplierView
            // 
            this.SupplierView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SupplierView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.SupplierView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SupplierView.Location = new System.Drawing.Point(570, 182);
            this.SupplierView.Name = "SupplierView";
            this.SupplierView.ReadOnly = true;
            this.SupplierView.RowHeadersWidth = 51;
            this.SupplierView.RowTemplate.Height = 27;
            this.SupplierView.Size = new System.Drawing.Size(370, 228);
            this.SupplierView.TabIndex = 76;
            this.SupplierView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierView_CellClick);
            this.SupplierView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierView_CellEnter);
            this.SupplierView.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.SupplierView_CellLeave);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_Cancel.Location = new System.Drawing.Point(390, 428);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 52);
            this.btn_Cancel.TabIndex = 75;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_Create.Location = new System.Drawing.Point(82, 428);
            this.btn_Create.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(126, 52);
            this.btn_Create.TabIndex = 74;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(77, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Supplier Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(77, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 72;
            this.label2.Text = "Supplier ID";
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSupplierName.Location = new System.Drawing.Point(242, 202);
            this.txtSupplierName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(175, 33);
            this.txtSupplierName.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F);
            this.label1.Location = new System.Drawing.Point(386, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 50);
            this.label1.TabIndex = 70;
            this.label1.Text = "Supplier";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDescription.Location = new System.Drawing.Point(82, 255);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(450, 133);
            this.txtDescription.TabIndex = 69;
            this.txtDescription.Text = "Description...";
            this.txtDescription.WordWrap = false;
            this.txtDescription.Enter += new System.EventHandler(this.txtDescription_Enter);
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSupplierID.Location = new System.Drawing.Point(242, 139);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(175, 33);
            this.txtSupplierID.TabIndex = 68;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(242, 428);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 52);
            this.btnUpdate.TabIndex = 79;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btn_Add.Location = new System.Drawing.Point(426, 139);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(82, 35);
            this.btn_Add.TabIndex = 80;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 549);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SupplierView);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Create);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtSupplierID);
            this.Name = "Supplier";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SupplierView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView SupplierView;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btn_Add;
    }
}