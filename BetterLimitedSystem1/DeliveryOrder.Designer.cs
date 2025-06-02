namespace BetterLimitedSystem1
{
    partial class DeliveryOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierID = new System.Windows.Forms.TextBox();
            this.cbDeliveryOrderID = new System.Windows.Forms.ComboBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtSession = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.txtWorkMan = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.btnFinishDelivery = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(48, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 74;
            this.label2.Text = "Delivery Order ID";
            // 
            // txtSupplierID
            // 
            this.txtSupplierID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSupplierID.Location = new System.Drawing.Point(53, 203);
            this.txtSupplierID.Margin = new System.Windows.Forms.Padding(5);
            this.txtSupplierID.Name = "txtSupplierID";
            this.txtSupplierID.ReadOnly = true;
            this.txtSupplierID.Size = new System.Drawing.Size(186, 33);
            this.txtSupplierID.TabIndex = 73;
            this.txtSupplierID.Text = "Order ID";
            this.txtSupplierID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbDeliveryOrderID
            // 
            this.cbDeliveryOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbDeliveryOrderID.FormattingEnabled = true;
            this.cbDeliveryOrderID.Location = new System.Drawing.Point(225, 102);
            this.cbDeliveryOrderID.Name = "cbDeliveryOrderID";
            this.cbDeliveryOrderID.Size = new System.Drawing.Size(395, 33);
            this.cbDeliveryOrderID.TabIndex = 75;
            this.cbDeliveryOrderID.SelectedValueChanged += new System.EventHandler(this.cbDeliveryOrderID_SelectedValueChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtOrderID.Location = new System.Drawing.Point(237, 203);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(512, 33);
            this.txtOrderID.TabIndex = 77;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtAddress.Location = new System.Drawing.Point(237, 235);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(512, 33);
            this.txtAddress.TabIndex = 79;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox2.Location = new System.Drawing.Point(53, 235);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(186, 33);
            this.textBox2.TabIndex = 78;
            this.textBox2.Text = "Address";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtDeliveryDate.Location = new System.Drawing.Point(237, 268);
            this.txtDeliveryDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(512, 33);
            this.txtDeliveryDate.TabIndex = 81;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox4.Location = new System.Drawing.Point(53, 268);
            this.textBox4.Margin = new System.Windows.Forms.Padding(5);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(186, 33);
            this.textBox4.TabIndex = 80;
            this.textBox4.Text = "Delivery Date";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSession
            // 
            this.txtSession.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtSession.Location = new System.Drawing.Point(237, 302);
            this.txtSession.Margin = new System.Windows.Forms.Padding(5);
            this.txtSession.Name = "txtSession";
            this.txtSession.ReadOnly = true;
            this.txtSession.Size = new System.Drawing.Size(512, 33);
            this.txtSession.TabIndex = 83;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox5.Location = new System.Drawing.Point(53, 302);
            this.textBox5.Margin = new System.Windows.Forms.Padding(5);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(186, 33);
            this.textBox5.TabIndex = 82;
            this.textBox5.Text = "Delivery Session";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtStatus.Location = new System.Drawing.Point(237, 334);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(512, 33);
            this.txtStatus.TabIndex = 85;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox3.Location = new System.Drawing.Point(53, 334);
            this.textBox3.Margin = new System.Windows.Forms.Padding(5);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(186, 33);
            this.textBox3.TabIndex = 84;
            this.textBox3.Text = "Status";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProductView
            // 
            this.ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(53, 404);
            this.ProductView.Name = "ProductView";
            this.ProductView.ReadOnly = true;
            this.ProductView.RowHeadersWidth = 51;
            this.ProductView.RowTemplate.Height = 27;
            this.ProductView.Size = new System.Drawing.Size(696, 249);
            this.ProductView.TabIndex = 86;
            // 
            // txtWorkMan
            // 
            this.txtWorkMan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.txtWorkMan.Location = new System.Drawing.Point(237, 171);
            this.txtWorkMan.Margin = new System.Windows.Forms.Padding(5);
            this.txtWorkMan.Name = "txtWorkMan";
            this.txtWorkMan.ReadOnly = true;
            this.txtWorkMan.Size = new System.Drawing.Size(512, 33);
            this.txtWorkMan.TabIndex = 88;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.textBox7.Location = new System.Drawing.Point(53, 171);
            this.textBox7.Margin = new System.Windows.Forms.Padding(5);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(186, 33);
            this.textBox7.TabIndex = 87;
            this.textBox7.Text = "Work Man ID";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFinishDelivery
            // 
            this.btnFinishDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnFinishDelivery.Location = new System.Drawing.Point(568, 685);
            this.btnFinishDelivery.Name = "btnFinishDelivery";
            this.btnFinishDelivery.Size = new System.Drawing.Size(181, 61);
            this.btnFinishDelivery.TabIndex = 89;
            this.btnFinishDelivery.Text = "Finish Delivery";
            this.btnFinishDelivery.UseVisualStyleBackColor = true;
            this.btnFinishDelivery.Click += new System.EventHandler(this.btnFinishDelivery_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(367, 685);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(171, 61);
            this.btnCancel.TabIndex = 90;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(626, 102);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(123, 37);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // DeliveryOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 779);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFinishDelivery);
            this.Controls.Add(this.txtWorkMan);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSession);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.cbDeliveryOrderID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSupplierID);
            this.Name = "DeliveryOrder";
            this.Text = "DeliveryOrder";
            this.Load += new System.EventHandler(this.DeliveryOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSupplierID;
        private System.Windows.Forms.ComboBox cbDeliveryOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtDeliveryDate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtSession;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.TextBox txtWorkMan;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btnFinishDelivery;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSearch;
    }
}