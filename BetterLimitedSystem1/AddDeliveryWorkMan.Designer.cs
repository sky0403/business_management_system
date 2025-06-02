namespace BetterLimitedSystem1
{
    partial class AddDeliveryWorkMan
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtWorkManName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkManID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.DeliveryWorkManView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryWorkManView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(364, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 56);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnAdd.Location = new System.Drawing.Point(192, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 56);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtWorkManName
            // 
            this.txtWorkManName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtWorkManName.Location = new System.Drawing.Point(322, 276);
            this.txtWorkManName.Name = "txtWorkManName";
            this.txtWorkManName.Size = new System.Drawing.Size(156, 27);
            this.txtWorkManName.TabIndex = 9;
            this.txtWorkManName.TextChanged += new System.EventHandler(this.txtWorkManName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(117, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Work Man Name";
            // 
            // txtWorkManID
            // 
            this.txtWorkManID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtWorkManID.Location = new System.Drawing.Point(322, 163);
            this.txtWorkManID.Name = "txtWorkManID";
            this.txtWorkManID.ReadOnly = true;
            this.txtWorkManID.Size = new System.Drawing.Size(156, 33);
            this.txtWorkManID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label1.Location = new System.Drawing.Point(153, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Work Man ID";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Delete.Location = new System.Drawing.Point(789, 359);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 52);
            this.Delete.TabIndex = 80;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // DeliveryWorkManView
            // 
            this.DeliveryWorkManView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeliveryWorkManView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeliveryWorkManView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryWorkManView.Location = new System.Drawing.Point(552, 111);
            this.DeliveryWorkManView.Name = "DeliveryWorkManView";
            this.DeliveryWorkManView.ReadOnly = true;
            this.DeliveryWorkManView.RowHeadersWidth = 51;
            this.DeliveryWorkManView.RowTemplate.Height = 27;
            this.DeliveryWorkManView.Size = new System.Drawing.Size(370, 228);
            this.DeliveryWorkManView.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label3.Location = new System.Drawing.Point(388, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 35);
            this.label3.TabIndex = 81;
            this.label3.Text = "Delivery Work Man";
            // 
            // AddDeliveryWorkMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.DeliveryWorkManView);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWorkManName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWorkManID);
            this.Controls.Add(this.label1);
            this.Name = "AddDeliveryWorkMan";
            this.Text = "AddDeliveryWorkMan";
            this.Load += new System.EventHandler(this.AddDeliveryWorkMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryWorkManView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtWorkManName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkManID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView DeliveryWorkManView;
        private System.Windows.Forms.Label label3;
    }
}