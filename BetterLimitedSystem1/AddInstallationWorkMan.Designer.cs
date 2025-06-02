namespace BetterLimitedSystem1
{
    partial class AddInstallationWorkMan
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
            this.txtWorkManID = new System.Windows.Forms.TextBox();
            this.txtWorkManName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.InstallationWorkManView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InstallationWorkManView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label1.Location = new System.Drawing.Point(68, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Installation Work Man ID";
            // 
            // txtWorkManID
            // 
            this.txtWorkManID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtWorkManID.Location = new System.Drawing.Point(311, 164);
            this.txtWorkManID.Name = "txtWorkManID";
            this.txtWorkManID.ReadOnly = true;
            this.txtWorkManID.Size = new System.Drawing.Size(156, 27);
            this.txtWorkManID.TabIndex = 1;
            // 
            // txtWorkManName
            // 
            this.txtWorkManName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtWorkManName.Location = new System.Drawing.Point(311, 218);
            this.txtWorkManName.Name = "txtWorkManName";
            this.txtWorkManName.Size = new System.Drawing.Size(156, 27);
            this.txtWorkManName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.label2.Location = new System.Drawing.Point(68, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Installation Work Man Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnAdd.Location = new System.Drawing.Point(106, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 56);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.btnCancel.Location = new System.Drawing.Point(311, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(143, 56);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16F);
            this.label3.Location = new System.Drawing.Point(319, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(294, 35);
            this.label3.TabIndex = 82;
            this.label3.Text = "Installation Work Man";
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.Delete.Location = new System.Drawing.Point(752, 344);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 52);
            this.Delete.TabIndex = 84;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // InstallationWorkManView
            // 
            this.InstallationWorkManView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InstallationWorkManView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.InstallationWorkManView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InstallationWorkManView.Location = new System.Drawing.Point(515, 96);
            this.InstallationWorkManView.Name = "InstallationWorkManView";
            this.InstallationWorkManView.ReadOnly = true;
            this.InstallationWorkManView.RowHeadersWidth = 51;
            this.InstallationWorkManView.RowTemplate.Height = 27;
            this.InstallationWorkManView.Size = new System.Drawing.Size(370, 228);
            this.InstallationWorkManView.TabIndex = 83;
            // 
            // AddInstallationWorkMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 443);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.InstallationWorkManView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtWorkManName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtWorkManID);
            this.Controls.Add(this.label1);
            this.Name = "AddInstallationWorkMan";
            this.Text = "AddInstallationWorkMan";
            this.Load += new System.EventHandler(this.AddInstallationWorkMan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InstallationWorkManView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkManID;
        private System.Windows.Forms.TextBox txtWorkManName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView InstallationWorkManView;
    }
}