namespace BetterLimitedSystem1
{
    partial class InstallationOrder
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinishInstallation = new System.Windows.Forms.Button();
            this.txtWorkMan = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtInstallationDate = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.cbInstallationOrderID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(664, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 37);
            this.btnSearch.TabIndex = 109;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(405, 624);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 61);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinishInstallation
            // 
            this.btnFinishInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnFinishInstallation.Location = new System.Drawing.Point(606, 624);
            this.btnFinishInstallation.Name = "btnFinishInstallation";
            this.btnFinishInstallation.Size = new System.Drawing.Size(181, 61);
            this.btnFinishInstallation.TabIndex = 107;
            this.btnFinishInstallation.Text = "Finish Installation";
            this.btnFinishInstallation.UseVisualStyleBackColor = true;
            this.btnFinishInstallation.Click += new System.EventHandler(this.btnFinishInstallation_Click);
            // 
            // txtWorkMan
            // 
            this.txtWorkMan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtWorkMan.Location = new System.Drawing.Point(275, 110);
            this.txtWorkMan.Margin = new System.Windows.Forms.Padding(5);
            this.txtWorkMan.Name = "txtWorkMan";
            this.txtWorkMan.ReadOnly = true;
            this.txtWorkMan.Size = new System.Drawing.Size(512, 33);
            this.txtWorkMan.TabIndex = 106;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox7.Location = new System.Drawing.Point(91, 110);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(186, 33);
            this.textBox7.TabIndex = 105;
            this.textBox7.Text = "Work Man ID";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductView
            // 
            this.ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(91, 343);
            this.ProductView.Name = "ProductView";
            this.ProductView.ReadOnly = true;
            this.ProductView.RowHeadersWidth = 51;
            this.ProductView.RowTemplate.Height = 27;
            this.ProductView.Size = new System.Drawing.Size(696, 249);
            this.ProductView.TabIndex = 104;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtStatus.Location = new System.Drawing.Point(275, 273);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(512, 33);
            this.txtStatus.TabIndex = 103;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox3.Location = new System.Drawing.Point(91, 273);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(186, 33);
            this.textBox3.TabIndex = 102;
            this.textBox3.Text = "Status";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtTime.Location = new System.Drawing.Point(275, 241);
            this.txtTime.Margin = new System.Windows.Forms.Padding(5);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(512, 33);
            this.txtTime.TabIndex = 101;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox5.Location = new System.Drawing.Point(91, 241);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(186, 33);
            this.textBox5.TabIndex = 100;
            this.textBox5.Text = "Installation Time";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInstallationDate
            // 
            this.txtInstallationDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtInstallationDate.Location = new System.Drawing.Point(275, 207);
            this.txtInstallationDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtInstallationDate.Name = "txtInstallationDate";
            this.txtInstallationDate.ReadOnly = true;
            this.txtInstallationDate.Size = new System.Drawing.Size(512, 33);
            this.txtInstallationDate.TabIndex = 99;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox4.Location = new System.Drawing.Point(91, 207);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(186, 33);
            this.textBox4.TabIndex = 98;
            this.textBox4.Text = "Installation Date";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtAddress.Location = new System.Drawing.Point(275, 174);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(512, 33);
            this.txtAddress.TabIndex = 97;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(91, 174);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 33);
            this.textBox2.TabIndex = 96;
            this.textBox2.Text = "Address";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtOrderID.Location = new System.Drawing.Point(275, 142);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(512, 33);
            this.txtOrderID.TabIndex = 95;
            // 
            // cbInstallationOrderID
            // 
            this.cbInstallationOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbInstallationOrderID.FormattingEnabled = true;
            this.cbInstallationOrderID.Location = new System.Drawing.Point(263, 41);
            this.cbInstallationOrderID.Name = "cbInstallationOrderID";
            this.cbInstallationOrderID.Size = new System.Drawing.Size(395, 33);
            this.cbInstallationOrderID.TabIndex = 94;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(57, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Installation Order ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSupplierID.Location = new System.Drawing.Point(91, 142);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(186, 33);
            this.txtSupplierID.TabIndex = 92;
            this.txtSupplierID.Text = "Order ID";
            this.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InstallationOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 725);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinishInstallation);
            this.Controls.Add(this.txtWorkMan);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtInstallationDate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.cbInstallationOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierID);
            this.Name = "InstallationOrder";
            this.Text = "InstallationOrder";
            this.Load += new System.EventHandler(this.InstallationOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinishInstallation;
        private System.Windows.Forms.TextBox txtWorkMan;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtInstallationDate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.ComboBox cbInstallationOrderID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierID;
    }
}