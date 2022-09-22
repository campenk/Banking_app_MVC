
namespace BIT706_A2_Campen_5047211
{
    partial class ManageAccounts
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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonGo = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAmount = new System.Windows.Forms.Label();
            this.buttonInterest = new System.Windows.Forms.Button();
            this.buttonWithdrawal = new System.Windows.Forms.Button();
            this.buttonDeposit = new System.Windows.Forms.Button();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.listBoxRecentTransactions = new System.Windows.Forms.ListBox();
            this.labelAccountInfo = new System.Windows.Forms.Label();
            this.buttonAccountInfo = new System.Windows.Forms.Button();
            this.labelAccountTitle = new System.Windows.Forms.Label();
            this.labelAccounts = new System.Windows.Forms.Label();
            this.listBoxAccounts = new System.Windows.Forms.ListBox();
            this.gbTransactionInfo = new System.Windows.Forms.GroupBox();
            this.cbRecipientAccount = new System.Windows.Forms.ComboBox();
            this.labelRecipientAccount = new System.Windows.Forms.Label();
            this.gbRecentTransactions = new System.Windows.Forms.GroupBox();
            this.buttonTransfer = new System.Windows.Forms.Button();
            this.bNewAccount = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.gbTransactionInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 300);
            this.label1.TabIndex = 34;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(277, 283);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(295, 15);
            this.labelError.TabIndex = 31;
            this.labelError.Text = "Please check the amount is correct and try again";
            this.labelError.Visible = false;
            // 
            // buttonGo
            // 
            this.buttonGo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGo.Location = new System.Drawing.Point(36, 395);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(120, 23);
            this.buttonGo.TabIndex = 30;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click_1);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(277, 253);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 29;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Visible = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmount.Location = new System.Drawing.Point(277, 204);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(85, 15);
            this.labelAmount.TabIndex = 28;
            this.labelAmount.Text = "Enter amount";
            this.labelAmount.Visible = false;
            // 
            // buttonInterest
            // 
            this.buttonInterest.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInterest.Location = new System.Drawing.Point(528, 127);
            this.buttonInterest.Name = "buttonInterest";
            this.buttonInterest.Size = new System.Drawing.Size(129, 23);
            this.buttonInterest.TabIndex = 27;
            this.buttonInterest.Text = "Add Interest";
            this.buttonInterest.UseVisualStyleBackColor = true;
            this.buttonInterest.Visible = false;
            this.buttonInterest.Click += new System.EventHandler(this.buttonInterest_Click);
            // 
            // buttonWithdrawal
            // 
            this.buttonWithdrawal.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWithdrawal.Location = new System.Drawing.Point(393, 127);
            this.buttonWithdrawal.Name = "buttonWithdrawal";
            this.buttonWithdrawal.Size = new System.Drawing.Size(129, 23);
            this.buttonWithdrawal.TabIndex = 26;
            this.buttonWithdrawal.Text = "Make a withdrawal";
            this.buttonWithdrawal.UseVisualStyleBackColor = true;
            this.buttonWithdrawal.Visible = false;
            this.buttonWithdrawal.Click += new System.EventHandler(this.buttonWithdrawal_Click);
            // 
            // buttonDeposit
            // 
            this.buttonDeposit.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeposit.Location = new System.Drawing.Point(239, 128);
            this.buttonDeposit.Name = "buttonDeposit";
            this.buttonDeposit.Size = new System.Drawing.Size(129, 23);
            this.buttonDeposit.TabIndex = 25;
            this.buttonDeposit.Text = "Make a deposit";
            this.buttonDeposit.UseVisualStyleBackColor = true;
            this.buttonDeposit.Visible = false;
            this.buttonDeposit.Click += new System.EventHandler(this.buttonDeposit_Click);
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAmount.Location = new System.Drawing.Point(277, 227);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(157, 22);
            this.textBoxAmount.TabIndex = 24;
            this.textBoxAmount.Visible = false;
            // 
            // listBoxRecentTransactions
            // 
            this.listBoxRecentTransactions.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRecentTransactions.FormattingEnabled = true;
            this.listBoxRecentTransactions.ItemHeight = 15;
            this.listBoxRecentTransactions.Location = new System.Drawing.Point(253, 355);
            this.listBoxRecentTransactions.Name = "listBoxRecentTransactions";
            this.listBoxRecentTransactions.Size = new System.Drawing.Size(494, 94);
            this.listBoxRecentTransactions.TabIndex = 23;
            this.listBoxRecentTransactions.Visible = false;
            // 
            // labelAccountInfo
            // 
            this.labelAccountInfo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountInfo.Location = new System.Drawing.Point(291, 47);
            this.labelAccountInfo.Name = "labelAccountInfo";
            this.labelAccountInfo.Size = new System.Drawing.Size(475, 13);
            this.labelAccountInfo.TabIndex = 22;
            this.labelAccountInfo.Text = "Account Information";
            this.labelAccountInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelAccountInfo.Visible = false;
            // 
            // buttonAccountInfo
            // 
            this.buttonAccountInfo.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountInfo.Location = new System.Drawing.Point(667, 21);
            this.buttonAccountInfo.Name = "buttonAccountInfo";
            this.buttonAccountInfo.Size = new System.Drawing.Size(99, 23);
            this.buttonAccountInfo.TabIndex = 21;
            this.buttonAccountInfo.Text = "Account Info";
            this.buttonAccountInfo.UseVisualStyleBackColor = true;
            this.buttonAccountInfo.Visible = false;
            this.buttonAccountInfo.Click += new System.EventHandler(this.buttonAccountInfo_Click_1);
            // 
            // labelAccountTitle
            // 
            this.labelAccountTitle.AutoSize = true;
            this.labelAccountTitle.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountTitle.Location = new System.Drawing.Point(280, 21);
            this.labelAccountTitle.Name = "labelAccountTitle";
            this.labelAccountTitle.Size = new System.Drawing.Size(104, 18);
            this.labelAccountTitle.TabIndex = 20;
            this.labelAccountTitle.Text = "Account title";
            this.labelAccountTitle.Visible = false;
            // 
            // labelAccounts
            // 
            this.labelAccounts.AutoSize = true;
            this.labelAccounts.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccounts.Location = new System.Drawing.Point(63, 148);
            this.labelAccounts.Name = "labelAccounts";
            this.labelAccounts.Size = new System.Drawing.Size(63, 15);
            this.labelAccounts.TabIndex = 19;
            this.labelAccounts.Text = "Accounts";
            // 
            // listBoxAccounts
            // 
            this.listBoxAccounts.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAccounts.FormattingEnabled = true;
            this.listBoxAccounts.ItemHeight = 15;
            this.listBoxAccounts.Location = new System.Drawing.Point(36, 227);
            this.listBoxAccounts.Name = "listBoxAccounts";
            this.listBoxAccounts.Size = new System.Drawing.Size(120, 154);
            this.listBoxAccounts.TabIndex = 18;
            // 
            // gbTransactionInfo
            // 
            this.gbTransactionInfo.Controls.Add(this.cbRecipientAccount);
            this.gbTransactionInfo.Controls.Add(this.labelRecipientAccount);
            this.gbTransactionInfo.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTransactionInfo.Location = new System.Drawing.Point(239, 177);
            this.gbTransactionInfo.Name = "gbTransactionInfo";
            this.gbTransactionInfo.Size = new System.Drawing.Size(528, 130);
            this.gbTransactionInfo.TabIndex = 32;
            this.gbTransactionInfo.TabStop = false;
            this.gbTransactionInfo.Text = "Transaction details";
            this.gbTransactionInfo.Visible = false;
            // 
            // cbRecipientAccount
            // 
            this.cbRecipientAccount.FormattingEnabled = true;
            this.cbRecipientAccount.Location = new System.Drawing.Point(289, 50);
            this.cbRecipientAccount.Name = "cbRecipientAccount";
            this.cbRecipientAccount.Size = new System.Drawing.Size(157, 22);
            this.cbRecipientAccount.TabIndex = 39;
            this.cbRecipientAccount.Visible = false;
            // 
            // labelRecipientAccount
            // 
            this.labelRecipientAccount.AutoSize = true;
            this.labelRecipientAccount.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecipientAccount.Location = new System.Drawing.Point(286, 27);
            this.labelRecipientAccount.Name = "labelRecipientAccount";
            this.labelRecipientAccount.Size = new System.Drawing.Size(150, 15);
            this.labelRecipientAccount.TabIndex = 38;
            this.labelRecipientAccount.Text = "Select recipient account";
            this.labelRecipientAccount.Visible = false;
            // 
            // gbRecentTransactions
            // 
            this.gbRecentTransactions.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecentTransactions.Location = new System.Drawing.Point(239, 327);
            this.gbRecentTransactions.Name = "gbRecentTransactions";
            this.gbRecentTransactions.Size = new System.Drawing.Size(528, 144);
            this.gbRecentTransactions.TabIndex = 33;
            this.gbRecentTransactions.TabStop = false;
            this.gbRecentTransactions.Text = "Recent Transactions";
            this.gbRecentTransactions.Visible = false;
            // 
            // buttonTransfer
            // 
            this.buttonTransfer.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransfer.Location = new System.Drawing.Point(682, 127);
            this.buttonTransfer.Name = "buttonTransfer";
            this.buttonTransfer.Size = new System.Drawing.Size(129, 23);
            this.buttonTransfer.TabIndex = 35;
            this.buttonTransfer.Text = "Transfer";
            this.buttonTransfer.UseVisualStyleBackColor = true;
            this.buttonTransfer.Visible = false;
            this.buttonTransfer.Click += new System.EventHandler(this.bTransfer_Click);
            // 
            // bNewAccount
            // 
            this.bNewAccount.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNewAccount.Location = new System.Drawing.Point(36, 177);
            this.bNewAccount.Name = "bNewAccount";
            this.bNewAccount.Size = new System.Drawing.Size(120, 23);
            this.bNewAccount.TabIndex = 36;
            this.bNewAccount.Text = "New Account";
            this.bNewAccount.UseVisualStyleBackColor = true;
            this.bNewAccount.Click += new System.EventHandler(this.bNewAccount_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(39, 86);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(138, 23);
            this.bBack.TabIndex = 37;
            this.bBack.Text = "< Back to Dashboard";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // ManageAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 472);
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.bNewAccount);
            this.Controls.Add(this.buttonTransfer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.buttonInterest);
            this.Controls.Add(this.buttonWithdrawal);
            this.Controls.Add(this.buttonDeposit);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.listBoxRecentTransactions);
            this.Controls.Add(this.labelAccountInfo);
            this.Controls.Add(this.buttonAccountInfo);
            this.Controls.Add(this.labelAccountTitle);
            this.Controls.Add(this.labelAccounts);
            this.Controls.Add(this.listBoxAccounts);
            this.Controls.Add(this.gbTransactionInfo);
            this.Controls.Add(this.gbRecentTransactions);
            this.Name = "ManageAccounts";
            this.Text = "ManageAccounts";
            this.Controls.SetChildIndex(this.gbRecentTransactions, 0);
            this.Controls.SetChildIndex(this.gbTransactionInfo, 0);
            this.Controls.SetChildIndex(this.listBoxAccounts, 0);
            this.Controls.SetChildIndex(this.labelAccounts, 0);
            this.Controls.SetChildIndex(this.labelAccountTitle, 0);
            this.Controls.SetChildIndex(this.buttonAccountInfo, 0);
            this.Controls.SetChildIndex(this.labelAccountInfo, 0);
            this.Controls.SetChildIndex(this.listBoxRecentTransactions, 0);
            this.Controls.SetChildIndex(this.textBoxAmount, 0);
            this.Controls.SetChildIndex(this.buttonDeposit, 0);
            this.Controls.SetChildIndex(this.buttonWithdrawal, 0);
            this.Controls.SetChildIndex(this.buttonInterest, 0);
            this.Controls.SetChildIndex(this.labelAmount, 0);
            this.Controls.SetChildIndex(this.buttonSubmit, 0);
            this.Controls.SetChildIndex(this.buttonGo, 0);
            this.Controls.SetChildIndex(this.labelError, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.buttonTransfer, 0);
            this.Controls.SetChildIndex(this.bNewAccount, 0);
            this.Controls.SetChildIndex(this.bBack, 0);
            this.gbTransactionInfo.ResumeLayout(false);
            this.gbTransactionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Button buttonInterest;
        private System.Windows.Forms.Button buttonWithdrawal;
        private System.Windows.Forms.Button buttonDeposit;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.ListBox listBoxRecentTransactions;
        private System.Windows.Forms.Label labelAccountInfo;
        private System.Windows.Forms.Button buttonAccountInfo;
        private System.Windows.Forms.Label labelAccountTitle;
        private System.Windows.Forms.Label labelAccounts;
        private System.Windows.Forms.ListBox listBoxAccounts;
        private System.Windows.Forms.GroupBox gbTransactionInfo;
        private System.Windows.Forms.GroupBox gbRecentTransactions;
        private System.Windows.Forms.Button buttonTransfer;
        private System.Windows.Forms.Button bNewAccount;
        private System.Windows.Forms.Button bBack;
        private System.Windows.Forms.ComboBox cbRecipientAccount;
        private System.Windows.Forms.Label labelRecipientAccount;
    }
}