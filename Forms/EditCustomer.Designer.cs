
namespace BIT706_A2_Campen_5047211
{
    partial class EditCustomer
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
            this.bReset = new System.Windows.Forms.Button();
            this.bSubmit = new System.Windows.Forms.Button();
            this.cbStaffDiscount = new System.Windows.Forms.CheckBox();
            this.lPhoneNumber = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(165, 379);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 20;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(38, 379);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 19;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // cbStaffDiscount
            // 
            this.cbStaffDiscount.AutoSize = true;
            this.cbStaffDiscount.Location = new System.Drawing.Point(153, 323);
            this.cbStaffDiscount.Name = "cbStaffDiscount";
            this.cbStaffDiscount.Size = new System.Drawing.Size(93, 17);
            this.cbStaffDiscount.TabIndex = 18;
            this.cbStaffDiscount.Text = "Staff Dicsount";
            this.cbStaffDiscount.UseVisualStyleBackColor = true;
            // 
            // lPhoneNumber
            // 
            this.lPhoneNumber.AutoSize = true;
            this.lPhoneNumber.Location = new System.Drawing.Point(35, 260);
            this.lPhoneNumber.Name = "lPhoneNumber";
            this.lPhoneNumber.Size = new System.Drawing.Size(78, 13);
            this.lPhoneNumber.TabIndex = 17;
            this.lPhoneNumber.Text = "Phone Number";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(35, 203);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(58, 13);
            this.lLastName.TabIndex = 16;
            this.lLastName.Text = "Last Name";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(35, 142);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(57, 13);
            this.lFirstName.TabIndex = 15;
            this.lFirstName.Text = "First Name";
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Location = new System.Drawing.Point(153, 260);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.tbPhoneNo.TabIndex = 14;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(153, 203);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 13;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(153, 142);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 12;
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(39, 73);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(151, 23);
            this.bBack.TabIndex = 21;
            this.bBack.Text = "< Back to Customer Menu";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // EditCustomer
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
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
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

        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.CheckBox cbStaffDiscount;
        private System.Windows.Forms.Label lPhoneNumber;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Button bBack;
    }
}