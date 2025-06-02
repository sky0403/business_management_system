namespace BetterLimitedSystem1
{
    partial class Order_Detail
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHandler = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPaidPrice = new System.Windows.Forms.TextBox();
            this.cbDeposit = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.cbFullPaid = new System.Windows.Forms.CheckBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.Payment = new System.Windows.Forms.Label();
            this.txtDeliveryDate = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(472, 64);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(175, 25);
            this.txtCustomerName.TabIndex = 56;
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(472, 118);
            this.txtCustomerMobile.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerMobile.MaxLength = 8;
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(175, 25);
            this.txtCustomerMobile.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(372, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(372, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Mobile";
            // 
            // txtHandler
            // 
            this.txtHandler.Location = new System.Drawing.Point(174, 118);
            this.txtHandler.Margin = new System.Windows.Forms.Padding(5);
            this.txtHandler.Name = "txtHandler";
            this.txtHandler.ReadOnly = true;
            this.txtHandler.Size = new System.Drawing.Size(175, 25);
            this.txtHandler.TabIndex = 52;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(174, 64);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(175, 25);
            this.txtOrderID.TabIndex = 51;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label5.Location = new System.Drawing.Point(45, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 50;
            this.label5.Text = "Handler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(45, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Order ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label4.Location = new System.Drawing.Point(692, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "Customer Email";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnDelete.Location = new System.Drawing.Point(1234, 717);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 36);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnUpdate.Location = new System.Drawing.Point(1072, 717);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 36);
            this.btnUpdate.TabIndex = 59;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ProductView
            // 
            this.ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(48, 305);
            this.ProductView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductView.Name = "ProductView";
            this.ProductView.RowHeadersWidth = 4;
            this.ProductView.RowTemplate.Height = 24;
            this.ProductView.Size = new System.Drawing.Size(1310, 246);
            this.ProductView.TabIndex = 60;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(851, 70);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.ReadOnly = true;
            this.txtCustomerEmail.Size = new System.Drawing.Size(175, 25);
            this.txtCustomerEmail.TabIndex = 61;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lb_address.Location = new System.Drawing.Point(692, 124);
            this.lb_address.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(128, 19);
            this.lb_address.TabIndex = 62;
            this.lb_address.Text = "Delivery Address";
            this.lb_address.Visible = false;
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lb_date.Location = new System.Drawing.Point(1047, 120);
            this.lb_date.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(102, 19);
            this.lb_date.TabIndex = 63;
            this.lb_date.Text = "Delivery Date";
            this.lb_date.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(851, 118);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(175, 126);
            this.txtAddress.TabIndex = 64;
            this.txtAddress.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label8.Location = new System.Drawing.Point(1047, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 19);
            this.label8.TabIndex = 66;
            this.label8.Text = "Order Date";
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRemarks.Location = new System.Drawing.Point(49, 173);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(5);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(365, 114);
            this.txtRemarks.TabIndex = 68;
            this.txtRemarks.Text = "";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 38);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label9.Location = new System.Drawing.Point(1068, 598);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 73;
            this.label9.Text = "Discount(%):";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(1174, 595);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(184, 27);
            this.txtDiscount.TabIndex = 72;
            this.txtDiscount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label10.Location = new System.Drawing.Point(1099, 561);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 71;
            this.label10.Text = "Total($):";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtTotal.Location = new System.Drawing.Point(1174, 558);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(184, 27);
            this.txtTotal.TabIndex = 70;
            this.txtTotal.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label13.Location = new System.Drawing.Point(1083, 672);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 19);
            this.label13.TabIndex = 77;
            this.label13.Text = "Deposit($)";
            this.label13.Visible = false;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtDeposit.Location = new System.Drawing.Point(1174, 669);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.Size = new System.Drawing.Size(184, 27);
            this.txtDeposit.TabIndex = 76;
            this.txtDeposit.Text = "0";
            this.txtDeposit.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label11.Location = new System.Drawing.Point(1064, 635);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 19);
            this.label11.TabIndex = 75;
            this.label11.Text = "Paid_Price($)";
            // 
            // txtPaidPrice
            // 
            this.txtPaidPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtPaidPrice.Location = new System.Drawing.Point(1174, 632);
            this.txtPaidPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPaidPrice.Name = "txtPaidPrice";
            this.txtPaidPrice.ReadOnly = true;
            this.txtPaidPrice.Size = new System.Drawing.Size(184, 27);
            this.txtPaidPrice.TabIndex = 74;
            this.txtPaidPrice.Text = "0";
            // 
            // cbDeposit
            // 
            this.cbDeposit.AutoSize = true;
            this.cbDeposit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbDeposit.Location = new System.Drawing.Point(1057, 674);
            this.cbDeposit.Name = "cbDeposit";
            this.cbDeposit.Size = new System.Drawing.Size(18, 17);
            this.cbDeposit.TabIndex = 78;
            this.cbDeposit.UseVisualStyleBackColor = true;
            this.cbDeposit.Visible = false;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnPrint.Location = new System.Drawing.Point(916, 717);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(133, 36);
            this.btnPrint.TabIndex = 79;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(1167, 70);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(200, 25);
            this.txtOrderDate.TabIndex = 80;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label12.Location = new System.Drawing.Point(372, 578);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 19);
            this.label12.TabIndex = 81;
            this.label12.Text = "Status";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(472, 572);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtStatus.MaxLength = 8;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(175, 25);
            this.txtStatus.TabIndex = 82;
            // 
            // cbFullPaid
            // 
            this.cbFullPaid.AutoSize = true;
            this.cbFullPaid.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbFullPaid.Location = new System.Drawing.Point(958, 671);
            this.cbFullPaid.Name = "cbFullPaid";
            this.cbFullPaid.Size = new System.Drawing.Size(91, 23);
            this.cbFullPaid.TabIndex = 83;
            this.cbFullPaid.Text = "Full Paid";
            this.cbFullPaid.UseVisualStyleBackColor = true;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(164, 572);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(5);
            this.txtPayment.MaxLength = 8;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.ReadOnly = true;
            this.txtPayment.Size = new System.Drawing.Size(175, 25);
            this.txtPayment.TabIndex = 85;
            // 
            // Payment
            // 
            this.Payment.AutoSize = true;
            this.Payment.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.Payment.Location = new System.Drawing.Point(64, 578);
            this.Payment.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(70, 19);
            this.Payment.TabIndex = 84;
            this.Payment.Text = "Payment";
            // 
            // txtDeliveryDate
            // 
            this.txtDeliveryDate.Location = new System.Drawing.Point(1167, 120);
            this.txtDeliveryDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeliveryDate.Name = "txtDeliveryDate";
            this.txtDeliveryDate.ReadOnly = true;
            this.txtDeliveryDate.Size = new System.Drawing.Size(200, 25);
            this.txtDeliveryDate.TabIndex = 86;
            // 
            // Order_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 778);
            this.Controls.Add(this.txtDeliveryDate);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.cbFullPaid);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOrderDate);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cbDeposit);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPaidPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHandler);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Name = "Order_Detail";
            this.Text = "Order_Detail";
            this.Load += new System.EventHandler(this.Order_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHandler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPaidPrice;
        private System.Windows.Forms.CheckBox cbDeposit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.CheckBox cbFullPaid;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label Payment;
        private System.Windows.Forms.TextBox txtDeliveryDate;
    }
}