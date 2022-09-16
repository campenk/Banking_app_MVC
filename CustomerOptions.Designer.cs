
namespace BIT706_A2_Campen_5047211
{
    partial class CustomerOptions
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
            this.lbCustomerList = new System.Windows.Forms.ListBox();
            this.bAddNewCustomer = new System.Windows.Forms.Button();
            this.bEditCustomer = new System.Windows.Forms.Button();
            this.bDeleteCustomer = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCustomerList
            // 
            this.lbCustomerList.FormattingEnabled = true;
            this.lbCustomerList.Location = new System.Drawing.Point(44, 147);
            this.lbCustomerList.Name = "lbCustomerList";
            this.lbCustomerList.Size = new System.Drawing.Size(195, 290);
            this.lbCustomerList.TabIndex = 1;
            // 
            // bAddNewCustomer
            // 
            this.bAddNewCustomer.Location = new System.Drawing.Point(373, 147);
            this.bAddNewCustomer.Name = "bAddNewCustomer";
            this.bAddNewCustomer.Size = new System.Drawing.Size(151, 39);
            this.bAddNewCustomer.TabIndex = 2;
            this.bAddNewCustomer.Text = "Add Customer";
            this.bAddNewCustomer.UseVisualStyleBackColor = true;
            this.bAddNewCustomer.Click += new System.EventHandler(this.bAddNewCustomer_Click);
            // 
            // bEditCustomer
            // 
            this.bEditCustomer.Location = new System.Drawing.Point(373, 257);
            this.bEditCustomer.Name = "bEditCustomer";
            this.bEditCustomer.Size = new System.Drawing.Size(151, 39);
            this.bEditCustomer.TabIndex = 3;
            this.bEditCustomer.Text = "Edit Selected Customer";
            this.bEditCustomer.UseVisualStyleBackColor = true;
            this.bEditCustomer.Click += new System.EventHandler(this.bEditCustomer_Click);
            // 
            // bDeleteCustomer
            // 
            this.bDeleteCustomer.Location = new System.Drawing.Point(373, 380);
            this.bDeleteCustomer.Name = "bDeleteCustomer";
            this.bDeleteCustomer.Size = new System.Drawing.Size(151, 39);
            this.bDeleteCustomer.TabIndex = 4;
            this.bDeleteCustomer.Text = "Delete Selected Customer";
            this.bDeleteCustomer.UseVisualStyleBackColor = true;
            this.bDeleteCustomer.Click += new System.EventHandler(this.bDeleteCustomer_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(42, 95);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(138, 23);
            this.bBack.TabIndex = 13;
            this.bBack.Text = "< Back to Dashboard";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // CustomerOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bDeleteCustomer);
            this.Controls.Add(this.bEditCustomer);
            this.Controls.Add(this.bAddNewCustomer);
            this.Controls.Add(this.lbCustomerList);
            this.Name = "CustomerOptions";
            this.Text = "CustomerOptions";
            this.Load += new System.EventHandler(this.CustomerOptions_Load);
            this.Controls.SetChildIndex(this.lbCustomerList, 0);
            this.Controls.SetChildIndex(this.bAddNewCustomer, 0);
            this.Controls.SetChildIndex(this.bEditCustomer, 0);
            this.Controls.SetChildIndex(this.bDeleteCustomer, 0);
            this.Controls.SetChildIndex(this.bBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbCustomerList;
        private System.Windows.Forms.Button bAddNewCustomer;
        private System.Windows.Forms.Button bEditCustomer;
        private System.Windows.Forms.Button bDeleteCustomer;
        private System.Windows.Forms.Button bBack;
    }
}