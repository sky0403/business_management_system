namespace BetterLimitedSystem1
{
    partial class InwardsRecord
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
            this.btnSearchDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.InwardsView = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.InwardsView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDate
            // 
            this.btnSearchDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearchDate.Location = new System.Drawing.Point(1140, 26);
            this.btnSearchDate.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchDate.Name = "btnSearchDate";
            this.btnSearchDate.Size = new System.Drawing.Size(144, 33);
            this.btnSearchDate.TabIndex = 80;
            this.btnSearchDate.Text = "Search";
            this.btnSearchDate.UseVisualStyleBackColor = true;
            this.btnSearchDate.Click += new System.EventHandler(this.btnSearchDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(967, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 79;
            this.label1.Text = "To";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "yyyy-MM-dd";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(1012, 29);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(121, 27);
            this.dtpToDate.TabIndex = 78;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "yyyy-MM-dd";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(846, 29);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(113, 27);
            this.dtpFromDate.TabIndex = 77;
            // 
            // comboBoxSearchBy
            // 
            this.comboBoxSearchBy.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.comboBoxSearchBy.FormattingEnabled = true;
            this.comboBoxSearchBy.Items.AddRange(new object[] {
            "All",
            "Product ID",
            "Product Name"});
            this.comboBoxSearchBy.Location = new System.Drawing.Point(36, 66);
            this.comboBoxSearchBy.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSearchBy.Name = "comboBoxSearchBy";
            this.comboBoxSearchBy.Size = new System.Drawing.Size(274, 33);
            this.comboBoxSearchBy.TabIndex = 76;
            this.comboBoxSearchBy.Text = "All";
            this.comboBoxSearchBy.SelectionChangeCommitted += new System.EventHandler(this.comboBoxSearchBy_SelectedValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnSearch.Location = new System.Drawing.Point(989, 66);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 33);
            this.btnSearch.TabIndex = 75;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnRefresh.Location = new System.Drawing.Point(1142, 65);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(144, 32);
            this.btnRefresh.TabIndex = 73;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // InwardsView
            // 
            this.InwardsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InwardsView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.InwardsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InwardsView.Location = new System.Drawing.Point(33, 108);
            this.InwardsView.Margin = new System.Windows.Forms.Padding(4);
            this.InwardsView.Name = "InwardsView";
            this.InwardsView.ReadOnly = true;
            this.InwardsView.RowHeadersWidth = 51;
            this.InwardsView.RowTemplate.Height = 24;
            this.InwardsView.Size = new System.Drawing.Size(1253, 359);
            this.InwardsView.TabIndex = 72;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnBack.Location = new System.Drawing.Point(33, 18);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(89, 38);
            this.btnBack.TabIndex = 71;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.cbSearch.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(318, 67);
            this.cbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(641, 33);
            this.cbSearch.TabIndex = 81;
            this.cbSearch.Text = "- SELECT - ";
            // 
            // InwardsRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 536);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.btnSearchDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.comboBoxSearchBy);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.InwardsView);
            this.Controls.Add(this.btnBack);
            this.Name = "InwardsRecord";
            this.Text = "InwardsRecord";
            this.Load += new System.EventHandler(this.InwardsRecord_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InwardsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.ComboBox comboBoxSearchBy;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.DataGridView InwardsView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbSearch;
    }
}