namespace BetterLimitedSystem1
{
    partial class CreateSalesOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbItemID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numQty = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbPrint = new System.Windows.Forms.CheckBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtHandler = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtRemarks = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerMobile = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDelivery = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPaidPrice = new System.Windows.Forms.TextBox();
            this.cbDeposit = new System.Windows.Forms.CheckBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.cbInstallation = new System.Windows.Forms.CheckBox();
            this.PaymentGroup = new System.Windows.Forms.GroupBox();
            this.rbOctopus = new System.Windows.Forms.RadioButton();
            this.rbFPS = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.rbCash = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.PaymentGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbItemID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numQty);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(715, 190);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(684, 115);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // cbItemID
            // 
            this.cbItemID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbItemID.FormattingEnabled = true;
            this.cbItemID.Location = new System.Drawing.Point(80, 51);
            this.cbItemID.Name = "cbItemID";
            this.cbItemID.Size = new System.Drawing.Size(250, 27);
            this.cbItemID.TabIndex = 69;
            this.cbItemID.SelectedIndexChanged += new System.EventHandler(this.cbItemID_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label12.Location = new System.Drawing.Point(13, 55);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 19);
            this.label12.TabIndex = 16;
            this.label12.Text = "Item ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label11.Location = new System.Drawing.Point(359, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 14;
            this.label11.Text = "QTY";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // numQty
            // 
            this.numQty.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.numQty.Location = new System.Drawing.Point(407, 53);
            this.numQty.Margin = new System.Windows.Forms.Padding(5);
            this.numQty.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numQty.Name = "numQty";
            this.numQty.Size = new System.Drawing.Size(100, 27);
            this.numQty.TabIndex = 13;
            this.numQty.ValueChanged += new System.EventHandler(this.numQty_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnAdd.Location = new System.Drawing.Point(526, 42);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbPrint
            // 
            this.cbPrint.AutoSize = true;
            this.cbPrint.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbPrint.Location = new System.Drawing.Point(888, 745);
            this.cbPrint.Margin = new System.Windows.Forms.Padding(5);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.Size = new System.Drawing.Size(201, 23);
            this.cbPrint.TabIndex = 39;
            this.cbPrint.Text = "Print after confirm order";
            this.cbPrint.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtTotal.Location = new System.Drawing.Point(1215, 584);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(184, 27);
            this.txtTotal.TabIndex = 38;
            this.txtTotal.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(1113, 732);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 36);
            this.btnCancel.TabIndex = 37;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnOK.Location = new System.Drawing.Point(1266, 732);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(133, 36);
            this.btnOK.TabIndex = 36;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnDelete.Location = new System.Drawing.Point(23, 584);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(167, 36);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete item";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtHandler
            // 
            this.txtHandler.Location = new System.Drawing.Point(173, 78);
            this.txtHandler.Margin = new System.Windows.Forms.Padding(5);
            this.txtHandler.Name = "txtHandler";
            this.txtHandler.ReadOnly = true;
            this.txtHandler.Size = new System.Drawing.Size(175, 25);
            this.txtHandler.TabIndex = 32;
            this.txtHandler.TextChanged += new System.EventHandler(this.txtOrderBy_TextChanged);
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(173, 24);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(175, 25);
            this.txtOrderID.TabIndex = 31;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRemarks.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtRemarks.Location = new System.Drawing.Point(23, 190);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(5);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(365, 114);
            this.txtRemarks.TabIndex = 29;
            this.txtRemarks.Text = "Remarks...";
            this.txtRemarks.Enter += new System.EventHandler(this.txtRemarks_Enter);
            this.txtRemarks.Leave += new System.EventHandler(this.txtRemarks_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label5.Location = new System.Drawing.Point(49, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 27;
            this.label5.Text = "Handler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label3.Location = new System.Drawing.Point(44, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Order ID";
            // 
            // ProductView
            // 
            this.ProductView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(23, 327);
            this.ProductView.Margin = new System.Windows.Forms.Padding(4);
            this.ProductView.Name = "ProductView";
            this.ProductView.RowHeadersWidth = 51;
            this.ProductView.RowTemplate.Height = 24;
            this.ProductView.Size = new System.Drawing.Size(1376, 246);
            this.ProductView.TabIndex = 42;
            this.ProductView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductView_CellContentClick);
            this.ProductView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductView_CellDoubleClick);
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lbAddress.Location = new System.Drawing.Point(668, 84);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(128, 19);
            this.lbAddress.TabIndex = 43;
            this.lbAddress.Text = "Delivery Address";
            this.lbAddress.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(806, 78);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(227, 102);
            this.txtAddress.TabIndex = 44;
            this.txtAddress.Visible = false;
            this.txtAddress.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(371, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 45;
            this.label1.Text = "Mobile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(371, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Customer";
            // 
            // txtCustomerMobile
            // 
            this.txtCustomerMobile.Location = new System.Drawing.Point(471, 78);
            this.txtCustomerMobile.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerMobile.MaxLength = 20;
            this.txtCustomerMobile.Name = "txtCustomerMobile";
            this.txtCustomerMobile.Size = new System.Drawing.Size(175, 25);
            this.txtCustomerMobile.TabIndex = 47;
            this.txtCustomerMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerMobile_KeyPress);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(471, 24);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(175, 25);
            this.txtCustomerName.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label6.Location = new System.Drawing.Point(677, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 49;
            this.label6.Text = "Customer Email";
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(806, 24);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(5);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(175, 25);
            this.txtCustomerEmail.TabIndex = 50;
            this.txtCustomerEmail.TextChanged += new System.EventHandler(this.txtCustomerEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label7.Location = new System.Drawing.Point(1140, 587);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Total($):";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(1215, 621);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(184, 27);
            this.txtDiscount.TabIndex = 52;
            this.txtDiscount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label8.Location = new System.Drawing.Point(1109, 624);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Discount(%):";
            // 
            // lbDelivery
            // 
            this.lbDelivery.AutoSize = true;
            this.lbDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.lbDelivery.Location = new System.Drawing.Point(1052, 84);
            this.lbDelivery.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDelivery.Name = "lbDelivery";
            this.lbDelivery.Size = new System.Drawing.Size(102, 19);
            this.lbDelivery.TabIndex = 54;
            this.lbDelivery.Text = "Delivery Date";
            this.lbDelivery.Visible = false;
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtpDeliveryDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDeliveryDate.Location = new System.Drawing.Point(1190, 80);
            this.dtpDeliveryDate.Margin = new System.Windows.Forms.Padding(5);
            this.dtpDeliveryDate.MinDate = new System.DateTime(2022, 6, 1, 0, 0, 0, 0);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(199, 25);
            this.dtpDeliveryDate.TabIndex = 55;
            this.dtpDeliveryDate.Value = new System.DateTime(2022, 6, 24, 23, 59, 59, 0);
            this.dtpDeliveryDate.Visible = false;
            this.dtpDeliveryDate.ValueChanged += new System.EventHandler(this.dtpDeliveryDate_ValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(200, 582);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(167, 36);
            this.btnRefresh.TabIndex = 56;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFill
            // 
            this.btnFill.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnFill.Location = new System.Drawing.Point(377, 582);
            this.btnFill.Margin = new System.Windows.Forms.Padding(5);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(216, 36);
            this.btnFill.TabIndex = 57;
            this.btnFill.Text = "Fill Customer Information";
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label10.Location = new System.Drawing.Point(1105, 661);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 19);
            this.label10.TabIndex = 59;
            this.label10.Text = "Paid_Price($)";
            // 
            // txtPaidPrice
            // 
            this.txtPaidPrice.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtPaidPrice.Location = new System.Drawing.Point(1215, 658);
            this.txtPaidPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPaidPrice.Name = "txtPaidPrice";
            this.txtPaidPrice.ReadOnly = true;
            this.txtPaidPrice.Size = new System.Drawing.Size(184, 27);
            this.txtPaidPrice.TabIndex = 58;
            this.txtPaidPrice.Text = "0";
            // 
            // cbDeposit
            // 
            this.cbDeposit.AutoSize = true;
            this.cbDeposit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbDeposit.Location = new System.Drawing.Point(1102, 699);
            this.cbDeposit.Name = "cbDeposit";
            this.cbDeposit.Size = new System.Drawing.Size(103, 23);
            this.cbDeposit.TabIndex = 60;
            this.cbDeposit.Text = "Deposit($)";
            this.cbDeposit.UseVisualStyleBackColor = true;
            this.cbDeposit.Visible = false;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtDeposit.Location = new System.Drawing.Point(1215, 695);
            this.txtDeposit.Margin = new System.Windows.Forms.Padding(5);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.ReadOnly = true;
            this.txtDeposit.Size = new System.Drawing.Size(185, 27);
            this.txtDeposit.TabIndex = 61;
            this.txtDeposit.Text = "0";
            this.txtDeposit.Visible = false;
            // 
            // cbDelivery
            // 
            this.cbDelivery.AutoSize = true;
            this.cbDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbDelivery.Location = new System.Drawing.Point(663, 745);
            this.cbDelivery.Margin = new System.Windows.Forms.Padding(5);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(88, 23);
            this.cbDelivery.TabIndex = 63;
            this.cbDelivery.Text = "Delivery";
            this.cbDelivery.UseVisualStyleBackColor = true;
            this.cbDelivery.CheckedChanged += new System.EventHandler(this.cbDelivery_CheckedChanged);
            // 
            // cbInstallation
            // 
            this.cbInstallation.AutoSize = true;
            this.cbInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.cbInstallation.Location = new System.Drawing.Point(771, 745);
            this.cbInstallation.Margin = new System.Windows.Forms.Padding(5);
            this.cbInstallation.Name = "cbInstallation";
            this.cbInstallation.Size = new System.Drawing.Size(107, 23);
            this.cbInstallation.TabIndex = 68;
            this.cbInstallation.Text = "Installation";
            this.cbInstallation.UseVisualStyleBackColor = true;
            // 
            // PaymentGroup
            // 
            this.PaymentGroup.Controls.Add(this.rbOctopus);
            this.PaymentGroup.Controls.Add(this.rbFPS);
            this.PaymentGroup.Controls.Add(this.rbCreditCard);
            this.PaymentGroup.Controls.Add(this.rbCash);
            this.PaymentGroup.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.PaymentGroup.Location = new System.Drawing.Point(888, 587);
            this.PaymentGroup.Name = "PaymentGroup";
            this.PaymentGroup.Size = new System.Drawing.Size(200, 137);
            this.PaymentGroup.TabIndex = 70;
            this.PaymentGroup.TabStop = false;
            this.PaymentGroup.Text = "Payment";
            // 
            // rbOctopus
            // 
            this.rbOctopus.AutoSize = true;
            this.rbOctopus.Location = new System.Drawing.Point(0, 96);
            this.rbOctopus.Name = "rbOctopus";
            this.rbOctopus.Size = new System.Drawing.Size(88, 23);
            this.rbOctopus.TabIndex = 3;
            this.rbOctopus.TabStop = true;
            this.rbOctopus.Text = "Octopus";
            this.rbOctopus.UseVisualStyleBackColor = true;
            // 
            // rbFPS
            // 
            this.rbFPS.AutoSize = true;
            this.rbFPS.Location = new System.Drawing.Point(0, 71);
            this.rbFPS.Name = "rbFPS";
            this.rbFPS.Size = new System.Drawing.Size(56, 23);
            this.rbFPS.TabIndex = 2;
            this.rbFPS.TabStop = true;
            this.rbFPS.Text = "FPS";
            this.rbFPS.UseVisualStyleBackColor = true;
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(0, 49);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.Size = new System.Drawing.Size(204, 23);
            this.rbCreditCard.TabIndex = 1;
            this.rbCreditCard.TabStop = true;
            this.rbCreditCard.Text = "Credit Card(Master/Visa)";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            // 
            // rbCash
            // 
            this.rbCash.AutoSize = true;
            this.rbCash.Checked = true;
            this.rbCash.Location = new System.Drawing.Point(0, 24);
            this.rbCash.Name = "rbCash";
            this.rbCash.Size = new System.Drawing.Size(64, 23);
            this.rbCash.TabIndex = 0;
            this.rbCash.TabStop = true;
            this.rbCash.Text = "Cash";
            this.rbCash.UseVisualStyleBackColor = true;
            // 
            // CreateSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 789);
            this.Controls.Add(this.PaymentGroup);
            this.Controls.Add(this.cbInstallation);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.cbDeposit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPaidPrice);
            this.Controls.Add(this.btnFill);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.lbDelivery);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtCustomerMobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lbAddress);
            this.Controls.Add(this.ProductView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbPrint);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtHandler);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateSalesOrder";
            this.Text = "Create Sales Order";
            this.Load += new System.EventHandler(this.CreateSalesOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.PaymentGroup.ResumeLayout(false);
            this.PaymentGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cbPrint;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtHandler;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.RichTextBox txtRemarks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ProductView;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerMobile;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDelivery;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPaidPrice;
        private System.Windows.Forms.CheckBox cbDeposit;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.CheckBox cbDelivery;
        private System.Windows.Forms.CheckBox cbInstallation;
        private System.Windows.Forms.ComboBox cbItemID;
        private System.Windows.Forms.GroupBox PaymentGroup;
        private System.Windows.Forms.RadioButton rbOctopus;
        private System.Windows.Forms.RadioButton rbFPS;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.RadioButton rbCash;
    }
}