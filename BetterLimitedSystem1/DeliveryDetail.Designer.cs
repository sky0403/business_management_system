namespace BetterLimitedSystem1
{
    partial class DeliveryDetail
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
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lbDelivery = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpDeliverySession = new System.Windows.Forms.GroupBox();
            this.rbEvening = new System.Windows.Forms.RadioButton();
            this.rbAfternoon = new System.Windows.Forms.RadioButton();
            this.rbMorning = new System.Windows.Forms.RadioButton();
            this.cbDeliveryWorkMan = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtWorkMan = new System.Windows.Forms.TextBox();
            this.gpDeliverySession.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(183, 207);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 102);
            this.txtAddress.TabIndex = 73;
            this.txtAddress.WordWrap = false;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lbAddress.Location = new System.Drawing.Point(46, 207);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(127, 24);
            this.lbAddress.TabIndex = 72;
            this.lbAddress.Text = "Delivery Address";
            this.lbAddress.UseCompatibleTextRendering = true;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpDeliveryDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDeliveryDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(614, 49);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDeliveryDate.MinDate = new System.DateTime(2022, 5, 1, 0, 0, 0, 0);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(125, 27);
            this.dtpDeliveryDate.TabIndex = 75;
            this.dtpDeliveryDate.Value = new System.DateTime(2022, 6, 24, 23, 59, 59, 0);
            // 
            // lbDelivery
            // 
            this.lbDelivery.AutoSize = true;
            this.lbDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lbDelivery.Location = new System.Drawing.Point(471, 55);
            this.lbDelivery.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDelivery.Name = "lbDelivery";
            this.lbDelivery.Size = new System.Drawing.Size(102, 19);
            this.lbDelivery.TabIndex = 74;
            this.lbDelivery.Text = "Delivery Date";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(183, 49);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(227, 25);
            this.txtOrderID.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(42, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "Order ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnCancel.Location = new System.Drawing.Point(456, 490);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 38);
            this.btnCancel.TabIndex = 79;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(248, 490);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 38);
            this.btnUpdate.TabIndex = 78;
            this.btnUpdate.Text = "Arrange";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(183, 94);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(227, 25);
            this.txtCustomerName.TabIndex = 83;
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(183, 136);
            this.txtCustomerMobile.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerMobile.MaxLength = 8;
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.ReadOnly = true;
            this.txtCustomerMobile.Size = new System.Drawing.Size(227, 25);
            this.txtCustomerMobile.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(42, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 81;
            this.label2.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(42, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Mobile";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label4.Location = new System.Drawing.Point(42, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 19);
            this.label4.TabIndex = 84;
            this.label4.Text = "Work Man";
            // 
            // gpDeliverySession
            // 
            this.gpDeliverySession.Controls.Add(this.rbEvening);
            this.gpDeliverySession.Controls.Add(this.rbAfternoon);
            this.gpDeliverySession.Controls.Add(this.rbMorning);
            this.gpDeliverySession.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.gpDeliverySession.Location = new System.Drawing.Point(476, 94);
            this.gpDeliverySession.Name = "gpDeliverySession";
            this.gpDeliverySession.Size = new System.Drawing.Size(263, 110);
            this.gpDeliverySession.TabIndex = 86;
            this.gpDeliverySession.TabStop = false;
            this.gpDeliverySession.Text = "Delivery Session";
            // 
            // rbEvening
            // 
            this.rbEvening.AutoSize = true;
            this.rbEvening.Location = new System.Drawing.Point(6, 77);
            this.rbEvening.Name = "rbEvening";
            this.rbEvening.Size = new System.Drawing.Size(231, 23);
            this.rbEvening.TabIndex = 89;
            this.rbEvening.TabStop = true;
            this.rbEvening.Text = "Evening (6:00pm – 10:00pm)";
            this.rbEvening.UseVisualStyleBackColor = true;
            // 
            // rbAfternoon
            // 
            this.rbAfternoon.AutoSize = true;
            this.rbAfternoon.Location = new System.Drawing.Point(6, 50);
            this.rbAfternoon.Name = "rbAfternoon";
            this.rbAfternoon.Size = new System.Drawing.Size(236, 23);
            this.rbAfternoon.TabIndex = 88;
            this.rbAfternoon.TabStop = true;
            this.rbAfternoon.Text = "Afternoon (1:00pm – 5:00pm)";
            this.rbAfternoon.UseVisualStyleBackColor = true;
            // 
            // rbMorning
            // 
            this.rbMorning.AutoSize = true;
            this.rbMorning.Location = new System.Drawing.Point(6, 26);
            this.rbMorning.Name = "rbMorning";
            this.rbMorning.Size = new System.Drawing.Size(232, 23);
            this.rbMorning.TabIndex = 87;
            this.rbMorning.TabStop = true;
            this.rbMorning.Text = "Morning (9:00am - 12:00am)";
            this.rbMorning.UseVisualStyleBackColor = true;
            // 
            // cbDeliveryWorkMan
            // 
            this.cbDeliveryWorkMan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbDeliveryWorkMan.FormattingEnabled = true;
            this.cbDeliveryWorkMan.Location = new System.Drawing.Point(183, 335);
            this.cbDeliveryWorkMan.Name = "cbDeliveryWorkMan";
            this.cbDeliveryWorkMan.Size = new System.Drawing.Size(227, 27);
            this.cbDeliveryWorkMan.TabIndex = 87;
            this.cbDeliveryWorkMan.SelectedIndexChanged += new System.EventHandler(this.cbDeliveryWorkMan_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(334, 438);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(5);
            this.txtStatus.MaxLength = 8;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(227, 25);
            this.txtStatus.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label5.Location = new System.Drawing.Point(244, 444);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 88;
            this.label5.Text = "Status";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtDate.Location = new System.Drawing.Point(596, 49);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(158, 27);
            this.txtDate.TabIndex = 90;
            this.txtDate.Visible = false;
            // 
            // txtWorkMan
            // 
            this.txtWorkMan.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtWorkMan.Location = new System.Drawing.Point(183, 335);
            this.txtWorkMan.Name = "txtWorkMan";
            this.txtWorkMan.ReadOnly = true;
            this.txtWorkMan.Size = new System.Drawing.Size(227, 27);
            this.txtWorkMan.TabIndex = 91;
            this.txtWorkMan.Visible = false;
            // 
            // DeliveryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 622);
            this.Controls.Add(this.txtWorkMan);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDeliveryWorkMan);
            this.Controls.Add(this.gpDeliverySession);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.lbDelivery);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbAddress);
            this.Name = "DeliveryDetail";
            this.Text = "DeliveryDetail";
            this.Load += new System.EventHandler(this.DeliveryDetail_Load);
            this.gpDeliverySession.ResumeLayout(false);
            this.gpDeliverySession.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Label lbDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpDeliverySession;
        private System.Windows.Forms.RadioButton rbEvening;
        private System.Windows.Forms.RadioButton rbAfternoon;
        private System.Windows.Forms.RadioButton rbMorning;
        private System.Windows.Forms.ComboBox cbDeliveryWorkMan;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtWorkMan;
    }
}