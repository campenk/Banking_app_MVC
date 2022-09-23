
namespace BIT706_A2_Campen_5047211
{
    partial class SelectCustomer
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
            this.bBack = new System.Windows.Forms.Button();
            this.lbCustomerList = new System.Windows.Forms.ListBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(39, 73);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(138, 23);
            this.bBack.TabIndex = 15;
            this.bBack.Text = "< Back to Dashboard";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // lbCustomerList
            // 
            this.lbCustomerList.FormattingEnabled = true;
            this.lbCustomerList.Location = new System.Drawing.Point(257, 119);
            this.lbCustomerList.Name = "lbCustomerList";
            this.lbCustomerList.Size = new System.Drawing.Size(195, 290);
            this.lbCustomerList.TabIndex = 14;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(309, 415);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 16;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // SelectCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.lbCustomerList);
            this.Name = "SelectCustomer";
            this.Text = "SelectCustomer";
            this.Controls.SetChildIndex(this.lbCustomerList, 0);
            this.Controls.SetChildIndex(this.bBack, 0);
            this.Controls.SetChildIndex(this.bSubmit, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ListBox lbCustomerList;
        private System.Windows.Forms.Button bSubmit;
    }
}