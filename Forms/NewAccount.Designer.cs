
namespace BIT706_A2_Campen_5047211
{
    partial class NewAccount
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
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.labelInterestRate = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.labelOverdraft = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bReset = new System.Windows.Forms.Button();
            this.tbInterestRate = new System.Windows.Forms.TextBox();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.tbOverdraft = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Everyday",
            "Investment",
            "Omni"});
            this.cbAccountType.Location = new System.Drawing.Point(181, 124);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(121, 21);
            this.cbAccountType.TabIndex = 2;
            this.cbAccountType.SelectedIndexChanged += new System.EventHandler(this.cbAccountType_SelectedIndexChanged);
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Location = new System.Drawing.Point(52, 124);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(74, 13);
            this.labelAccountType.TabIndex = 3;
            this.labelAccountType.Text = "Account Type";
            // 
            // labelInterestRate
            // 
            this.labelInterestRate.AutoSize = true;
            this.labelInterestRate.Location = new System.Drawing.Point(52, 182);
            this.labelInterestRate.Name = "labelInterestRate";
            this.labelInterestRate.Size = new System.Drawing.Size(68, 13);
            this.labelInterestRate.TabIndex = 5;
            this.labelInterestRate.Text = "Interest Rate";
            this.labelInterestRate.Visible = false;
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(52, 240);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(25, 13);
            this.labelFee.TabIndex = 7;
            this.labelFee.Text = "Fee";
            this.labelFee.Visible = false;
            // 
            // labelOverdraft
            // 
            this.labelOverdraft.AutoSize = true;
            this.labelOverdraft.Location = new System.Drawing.Point(52, 298);
            this.labelOverdraft.Name = "labelOverdraft";
            this.labelOverdraft.Size = new System.Drawing.Size(51, 13);
            this.labelOverdraft.TabIndex = 9;
            this.labelOverdraft.Text = "Overdraft";
            this.labelOverdraft.Visible = false;
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Location = new System.Drawing.Point(52, 356);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(46, 13);
            this.labelBalance.TabIndex = 11;
            this.labelBalance.Text = "Balance";
            this.labelBalance.Visible = false;
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(181, 356);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(121, 20);
            this.tbBalance.TabIndex = 12;
            this.tbBalance.Visible = false;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(181, 413);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 13;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Visible = false;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bReset
            // 
            this.bReset.Location = new System.Drawing.Point(333, 413);
            this.bReset.Name = "bReset";
            this.bReset.Size = new System.Drawing.Size(75, 23);
            this.bReset.TabIndex = 14;
            this.bReset.Text = "Reset";
            this.bReset.UseVisualStyleBackColor = true;
            this.bReset.Visible = false;
            this.bReset.Click += new System.EventHandler(this.bReset_Click);
            // 
            // tbInterestRate
            // 
            this.tbInterestRate.Location = new System.Drawing.Point(181, 182);
            this.tbInterestRate.Name = "tbInterestRate";
            this.tbInterestRate.Size = new System.Drawing.Size(121, 20);
            this.tbInterestRate.TabIndex = 15;
            this.tbInterestRate.Visible = false;
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(181, 240);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(121, 20);
            this.tbFee.TabIndex = 16;
            this.tbFee.Visible = false;
            // 
            // tbOverdraft
            // 
            this.tbOverdraft.Location = new System.Drawing.Point(181, 298);
            this.tbOverdraft.Name = "tbOverdraft";
            this.tbOverdraft.Size = new System.Drawing.Size(121, 20);
            this.tbOverdraft.TabIndex = 17;
            this.tbOverdraft.Visible = false;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbOverdraft);
            this.Controls.Add(this.tbFee);
            this.Controls.Add(this.tbInterestRate);
            this.Controls.Add(this.bReset);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.labelOverdraft);
            this.Controls.Add(this.labelFee);
            this.Controls.Add(this.labelInterestRate);
            this.Controls.Add(this.labelAccountType);
            this.Controls.Add(this.cbAccountType);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.Controls.SetChildIndex(this.cbAccountType, 0);
            this.Controls.SetChildIndex(this.labelAccountType, 0);
            this.Controls.SetChildIndex(this.labelInterestRate, 0);
            this.Controls.SetChildIndex(this.labelFee, 0);
            this.Controls.SetChildIndex(this.labelOverdraft, 0);
            this.Controls.SetChildIndex(this.labelBalance, 0);
            this.Controls.SetChildIndex(this.tbBalance, 0);
            this.Controls.SetChildIndex(this.bSubmit, 0);
            this.Controls.SetChildIndex(this.bReset, 0);
            this.Controls.SetChildIndex(this.tbInterestRate, 0);
            this.Controls.SetChildIndex(this.tbFee, 0);
            this.Controls.SetChildIndex(this.tbOverdraft, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.Label labelAccountType;
        private System.Windows.Forms.Label labelInterestRate;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelOverdraft;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bReset;
        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.TextBox tbOverdraft;
    }
}