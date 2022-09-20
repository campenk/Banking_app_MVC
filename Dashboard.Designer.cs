
namespace BIT706_A2_Campen_5047211
{
    partial class Dashboard
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
            this.bManageCustomers = new System.Windows.Forms.Button();
            this.bManageAccounts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bManageCustomers
            // 
            this.bManageCustomers.Location = new System.Drawing.Point(39, 112);
            this.bManageCustomers.Name = "bManageCustomers";
            this.bManageCustomers.Size = new System.Drawing.Size(151, 39);
            this.bManageCustomers.TabIndex = 1;
            this.bManageCustomers.Text = "Add and Edit Customers";
            this.bManageCustomers.UseVisualStyleBackColor = true;
            this.bManageCustomers.Click += new System.EventHandler(this.button1_Click);
            // 
            // bManageAccounts
            // 
            this.bManageAccounts.Location = new System.Drawing.Point(39, 197);
            this.bManageAccounts.Name = "bManageAccounts";
            this.bManageAccounts.Size = new System.Drawing.Size(151, 39);
            this.bManageAccounts.TabIndex = 2;
            this.bManageAccounts.Text = "Manage Customer Accounts";
            this.bManageAccounts.UseVisualStyleBackColor = true;
            this.bManageAccounts.Click += new System.EventHandler(this.bManageAccounts_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bManageAccounts);
            this.Controls.Add(this.bManageCustomers);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Controls.SetChildIndex(this.bManageCustomers, 0);
            this.Controls.SetChildIndex(this.bManageAccounts, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bManageCustomers;
        private System.Windows.Forms.Button bManageAccounts;
    }
}