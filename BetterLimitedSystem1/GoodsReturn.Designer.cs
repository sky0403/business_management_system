namespace BetterLimitedSystem1
{
    partial class GoodsReturn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.gpProduct = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.rbDead = new System.Windows.Forms.RadioButton();
            this.gpReturnReason = new System.Windows.Forms.GroupBox();
            this.rbFaulty = new System.Windows.Forms.RadioButton();
            this.rbReceivedWrongItem = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.gpProductOpen = new System.Windows.Forms.GroupBox();
            this.rbOpenNo = new System.Windows.Forms.RadioButton();
            this.rbOpenYes = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbItemID = new System.Windows.Forms.ComboBox();
            this.cbOrderID = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.gpProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            this.gpReturnReason.SuspendLayout();
            this.gpProductOpen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Returns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(577, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please complete the form below to request an RMA number.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOrderID);
            this.groupBox1.Controls.Add(this.dtpOrderDate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(19, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 366);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(253, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(720, 33);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(253, 85);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(720, 33);
            this.txtCustomerName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(253, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(720, 33);
            this.txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label3.Location = new System.Drawing.Point(67, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label4.Location = new System.Drawing.Point(61, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label5.Location = new System.Drawing.Point(115, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telephone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(40, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(34, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(88, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label9.Location = new System.Drawing.Point(134, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Order ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(117, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label11.Location = new System.Drawing.Point(110, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Order Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.CustomFormat = "yyyy-MM-dd";
            this.dtpOrderDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOrderDate.Location = new System.Drawing.Point(253, 264);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(162, 33);
            this.dtpOrderDate.TabIndex = 60;
            // 
            // gpProduct
            // 
            this.gpProduct.Controls.Add(this.cbItemID);
            this.gpProduct.Controls.Add(this.txtDetails);
            this.gpProduct.Controls.Add(this.label21);
            this.gpProduct.Controls.Add(this.gpProductOpen);
            this.gpProduct.Controls.Add(this.gpReturnReason);
            this.gpProduct.Controls.Add(this.numQty);
            this.gpProduct.Controls.Add(this.label12);
            this.gpProduct.Controls.Add(this.label13);
            this.gpProduct.Controls.Add(this.label14);
            this.gpProduct.Controls.Add(this.label15);
            this.gpProduct.Controls.Add(this.label16);
            this.gpProduct.Controls.Add(this.label17);
            this.gpProduct.Controls.Add(this.label18);
            this.gpProduct.Controls.Add(this.label19);
            this.gpProduct.Controls.Add(this.label20);
            this.gpProduct.Controls.Add(this.txtItemName);
            this.gpProduct.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.gpProduct.Location = new System.Drawing.Point(19, 503);
            this.gpProduct.Name = "gpProduct";
            this.gpProduct.Size = new System.Drawing.Size(979, 553);
            this.gpProduct.TabIndex = 61;
            this.gpProduct.TabStop = false;
            this.gpProduct.Text = "Product Information and Reason for Return";
            this.gpProduct.Enter += new System.EventHandler(this.gpProduct_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label12.Location = new System.Drawing.Point(43, 379);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(183, 25);
            this.label12.TabIndex = 14;
            this.label12.Text = "Product is opened";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(16, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 25);
            this.label13.TabIndex = 13;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label14.Location = new System.Drawing.Point(43, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(180, 25);
            this.label14.TabIndex = 12;
            this.label14.Text = "Reason for Return";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(16, 379);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 25);
            this.label15.TabIndex = 11;
            this.label15.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(43, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 25);
            this.label16.TabIndex = 10;
            this.label16.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(85, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 25);
            this.label17.TabIndex = 9;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label18.Location = new System.Drawing.Point(130, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 25);
            this.label18.TabIndex = 8;
            this.label18.Text = "Quantity";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label19.Location = new System.Drawing.Point(107, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(112, 25);
            this.label19.TabIndex = 7;
            this.label19.Text = "Product ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label20.Location = new System.Drawing.Point(75, 84);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(148, 25);
            this.label20.TabIndex = 4;
            this.label20.Text = "Product Name";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(253, 85);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.ReadOnly = true;
            this.txtItemName.Size = new System.Drawing.Size(720, 33);
            this.txtItemName.TabIndex = 0;
            // 
            // numQty
            // 
            this.numQty.Location = new System.Drawing.Point(253, 145);
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(120, 33);
            this.numQty.TabIndex = 61;
            // 
            // rbDead
            // 
            this.rbDead.AutoSize = true;
            this.rbDead.Location = new System.Drawing.Point(6, 15);
            this.rbDead.Name = "rbDead";
            this.rbDead.Size = new System.Drawing.Size(180, 29);
            this.rbDead.TabIndex = 62;
            this.rbDead.TabStop = true;
            this.rbDead.Text = "Dead On Arrival";
            this.rbDead.UseVisualStyleBackColor = true;
            // 
            // gpReturnReason
            // 
            this.gpReturnReason.Controls.Add(this.rbOther);
            this.gpReturnReason.Controls.Add(this.rbReceivedWrongItem);
            this.gpReturnReason.Controls.Add(this.rbFaulty);
            this.gpReturnReason.Controls.Add(this.rbDead);
            this.gpReturnReason.Location = new System.Drawing.Point(253, 197);
            this.gpReturnReason.Name = "gpReturnReason";
            this.gpReturnReason.Size = new System.Drawing.Size(299, 157);
            this.gpReturnReason.TabIndex = 63;
            this.gpReturnReason.TabStop = false;
            // 
            // rbFaulty
            // 
            this.rbFaulty.AutoSize = true;
            this.rbFaulty.Location = new System.Drawing.Point(6, 50);
            this.rbFaulty.Name = "rbFaulty";
            this.rbFaulty.Size = new System.Drawing.Size(291, 29);
            this.rbFaulty.TabIndex = 63;
            this.rbFaulty.TabStop = true;
            this.rbFaulty.Text = "Faulty. Please supply details";
            this.rbFaulty.UseVisualStyleBackColor = true;
            // 
            // rbReceivedWrongItem
            // 
            this.rbReceivedWrongItem.AutoSize = true;
            this.rbReceivedWrongItem.Location = new System.Drawing.Point(6, 85);
            this.rbReceivedWrongItem.Name = "rbReceivedWrongItem";
            this.rbReceivedWrongItem.Size = new System.Drawing.Size(234, 29);
            this.rbReceivedWrongItem.TabIndex = 64;
            this.rbReceivedWrongItem.TabStop = true;
            this.rbReceivedWrongItem.Text = "Received Wrong item";
            this.rbReceivedWrongItem.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(6, 120);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(289, 29);
            this.rbOther.TabIndex = 65;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other, please supply details";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // gpProductOpen
            // 
            this.gpProductOpen.Controls.Add(this.rbOpenNo);
            this.gpProductOpen.Controls.Add(this.rbOpenYes);
            this.gpProductOpen.Cursor = System.Windows.Forms.Cursors.Default;
            this.gpProductOpen.Location = new System.Drawing.Point(253, 360);
            this.gpProductOpen.Name = "gpProductOpen";
            this.gpProductOpen.Size = new System.Drawing.Size(155, 52);
            this.gpProductOpen.TabIndex = 66;
            this.gpProductOpen.TabStop = false;
            this.gpProductOpen.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // rbOpenNo
            // 
            this.rbOpenNo.AutoSize = true;
            this.rbOpenNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbOpenNo.Location = new System.Drawing.Point(87, 15);
            this.rbOpenNo.Name = "rbOpenNo";
            this.rbOpenNo.Size = new System.Drawing.Size(62, 29);
            this.rbOpenNo.TabIndex = 63;
            this.rbOpenNo.TabStop = true;
            this.rbOpenNo.Text = "No";
            this.rbOpenNo.UseVisualStyleBackColor = true;
            // 
            // rbOpenYes
            // 
            this.rbOpenYes.AutoSize = true;
            this.rbOpenYes.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbOpenYes.Location = new System.Drawing.Point(6, 15);
            this.rbOpenYes.Name = "rbOpenYes";
            this.rbOpenYes.Size = new System.Drawing.Size(65, 29);
            this.rbOpenYes.TabIndex = 62;
            this.rbOpenYes.TabStop = true;
            this.rbOpenYes.Text = "Yes";
            this.rbOpenYes.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.label21.Location = new System.Drawing.Point(8, 436);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(214, 25);
            this.label21.TabIndex = 67;
            this.label21.Text = "Faulty or other details";
            // 
            // txtDetails
            // 
            this.txtDetails.ForeColor = System.Drawing.Color.Gray;
            this.txtDetails.Location = new System.Drawing.Point(253, 437);
            this.txtDetails.Margin = new System.Windows.Forms.Padding(5);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(504, 102);
            this.txtDetails.TabIndex = 68;
            this.txtDetails.Text = "Faulty or other details";
            this.txtDetails.WordWrap = false;
            this.txtDetails.Enter += new System.EventHandler(this.txtOther_Enter);
            this.txtDetails.Leave += new System.EventHandler(this.txtOther_Leave);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(878, 1071);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 47);
            this.btnSubmit.TabIndex = 69;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(19, 1071);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 47);
            this.btnBack.TabIndex = 70;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbItemID
            // 
            this.cbItemID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbItemID.FormattingEnabled = true;
            this.cbItemID.Location = new System.Drawing.Point(249, 35);
            this.cbItemID.Name = "cbItemID";
            this.cbItemID.Size = new System.Drawing.Size(724, 33);
            this.cbItemID.TabIndex = 61;
            this.cbItemID.SelectedValueChanged += new System.EventHandler(this.cbItemID_SelectedValueChanged);
            // 
            // cbOrderID
            // 
            this.cbOrderID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbOrderID.FormattingEnabled = true;
            this.cbOrderID.Location = new System.Drawing.Point(249, 209);
            this.cbOrderID.Name = "cbOrderID";
            this.cbOrderID.Size = new System.Drawing.Size(724, 33);
            this.cbOrderID.TabIndex = 69;
            // 
            // GoodsReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 1130);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gpProduct);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GoodsReturn";
            this.Text = "Goods Returns";
            this.Load += new System.EventHandler(this.GoodsReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpProduct.ResumeLayout(false);
            this.gpProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            this.gpReturnReason.ResumeLayout(false);
            this.gpReturnReason.PerformLayout();
            this.gpProductOpen.ResumeLayout(false);
            this.gpProductOpen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.GroupBox gpProduct;
        private System.Windows.Forms.GroupBox gpProductOpen;
        private System.Windows.Forms.RadioButton rbOpenNo;
        private System.Windows.Forms.RadioButton rbOpenYes;
        private System.Windows.Forms.GroupBox gpReturnReason;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbReceivedWrongItem;
        private System.Windows.Forms.RadioButton rbFaulty;
        private System.Windows.Forms.RadioButton rbDead;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbItemID;
        private System.Windows.Forms.ComboBox cbOrderID;
    }
}