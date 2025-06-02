namespace BetterLimitedSystem1
{
    partial class WorkManMenu
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
            this.RTB_Memo = new System.Windows.Forms.RichTextBox();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnInstallation = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RTB_Memo
            // 
            this.RTB_Memo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.RTB_Memo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTB_Memo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.RTB_Memo.Location = new System.Drawing.Point(411, 147);
            this.RTB_Memo.Name = "RTB_Memo";
            this.RTB_Memo.ReadOnly = true;
            this.RTB_Memo.Size = new System.Drawing.Size(706, 527);
            this.RTB_Memo.TabIndex = 29;
            this.RTB_Memo.Text = "";
            // 
            // btnDelivery
            // 
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnDelivery.Location = new System.Drawing.Point(107, 147);
            this.btnDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(258, 50);
            this.btnDelivery.TabIndex = 31;
            this.btnDelivery.Text = "Delivery Order";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnInstallation
            // 
            this.btnInstallation.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnInstallation.Location = new System.Drawing.Point(107, 253);
            this.btnInstallation.Margin = new System.Windows.Forms.Padding(4);
            this.btnInstallation.Name = "btnInstallation";
            this.btnInstallation.Size = new System.Drawing.Size(258, 50);
            this.btnInstallation.TabIndex = 32;
            this.btnInstallation.Text = "Installation  Order";
            this.btnInstallation.UseVisualStyleBackColor = true;
            this.btnInstallation.Click += new System.EventHandler(this.btnInstallation_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F);
            this.btnLogOut.Location = new System.Drawing.Point(107, 624);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(258, 50);
            this.btnLogOut.TabIndex = 33;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // WorkManMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 735);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnInstallation);
            this.Controls.Add(this.btnDelivery);
            this.Controls.Add(this.RTB_Memo);
            this.Name = "WorkManMenu";
            this.Text = "WorkManMenu";
            this.Load += new System.EventHandler(this.WorkManMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RTB_Memo;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnInstallation;
        private System.Windows.Forms.Button btnLogOut;
    }
}