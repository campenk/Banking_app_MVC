
namespace BIT706_A2_Campen_5047211
{
    partial class AddCustomer
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.cbStaffDiscount = new System.Windows.Forms.CheckBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(157, 165);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 1;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(157, 226);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 2;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Location = new System.Drawing.Point(157, 283);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNo.TabIndex = 3;
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(39, 165);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(57, 13);
            this.lFirstName.TabIndex = 5;
            this.lFirstName.Text = "First Name";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(39, 226);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(58, 13);
            this.lLastName.TabIndex = 6;
            this.lLastName.Text = "Last Name";
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Location = new System.Drawing.Point(39, 283);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lPhoneNumber.TabIndex = 7;
            this.lPhoneNumber.Text = "Phone Number";
            // 
            // cbStaffDiscount
            // 
            this.cbStaffDiscount.AutoSize = true;
            this.cbStaffDiscount.Location = new System.Drawing.Point(157, 346);
            this.cbStaffDiscount.Name = "cbStaffDiscount";
            this.cbStaffDiscount.Size = new System.Drawing.Size(93, 17);
            this.cbStaffDiscount.TabIndex = 9;
            this.cbStaffDiscount.Text = "Staff Dicsount";
            this.cbStaffDiscount.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(42, 402);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 10;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(169, 402);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 11;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(42, 95);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(156, 23);
            this.bBack.TabIndex = 12;
            this.bBack.Text = "< Back to Customer Menu";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.cbStaffDiscount);
            this.Controls.Add(this.lPhoneNumber);
            this.Controls.Add(this.lLastName);
            this.Controls.Add(this.lFirstName);
            this.Controls.Add(this.tbPhoneNo);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Controls.SetChildIndex(this.tbFirstName, 0);
            this.Controls.SetChildIndex(this.tbLastName, 0);
            this.Controls.SetChildIndex(this.tbPhoneNo, 0);
            this.Controls.SetChildIndex(this.lFirstName, 0);
            this.Controls.SetChildIndex(this.lLastName, 0);
            this.Controls.SetChildIndex(this.lPhoneNumber, 0);
            this.Controls.SetChildIndex(this.cbStaffDiscount, 0);
            this.Controls.SetChildIndex(this.bSubmit, 0);
            this.Controls.SetChildIndex(this.bReset, 0);
            this.Controls.SetChildIndex(this.bBack, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.CheckBox cbStaffDiscount;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bBack;
    }
}