using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706_A2_Campen_5047211
{
    public partial class ManageAccounts : BIT706_A2_Campen_5047211.ParentForm
    {
        private AccountController accountController = new AccountController();
        private CustomerController customerController = new CustomerController();
        //  class variables

        public ManageAccounts()
        {
            InitializeComponent();
            RefreshList();
            Update();
            labelAccounts.Text = customerController.SelectedCustomer.FullName + " Accounts";
        }

        /******************
         * EVENT HANDLERS
         ******************/
       
           
        private void showCurrentAccountOptions()
        {
            labelAccountTitle.Visible = true;
            buttonAccountInfo.Visible = true;
            labelAccountInfo.Visible = false;
            buttonDeposit.Visible = true;
            buttonWithdrawal.Visible = true;
            buttonTransfer.Visible = true;
            listBoxRecentTransactions.Visible = true;
            gbRecentTransactions.Visible = true;
            labelAccountInfo.Visible = false;
            listBoxRecentTransactions.Items.Clear();
            labelAccountTitle.Text = accountController.SelectedAccount.AccountName() + " Account";            

            if (accountController.SelectedAccount.AccountName() != "Everyday")
            {
                buttonInterest.Visible = true;
            }
            else
            {
                buttonInterest.Visible = false;
            }
        }

        private void showTransactionDetails(bool b)
        {
            labelAmount.Visible = b;
            gbTransactionInfo.Visible = b;
            textBoxAmount.Visible = b;
            textBoxAmount.Text = "";
            buttonSubmit.Tag = "";
            buttonSubmit.Visible = b;
            labelError.Visible = false;
            gbTransactionInfo.Visible = b;
            labelRecipientAccount.Visible = !b;
            cbRecipientAccount.Visible = !b;
        }

        private void resetTransactionDetails()
        {
            labelError.Visible = false;
            textBoxAmount.Text = "";
        }

        

        public void UpdateAccount(Account acc)
        {
            listBoxAccounts.Items.Add(acc);
        }

        private void bNewAccount_Click(object sender, EventArgs e)
        {
            Form newAccount = new NewAccount();
            newAccount.Show();
            this.Close();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Form selectCustomer = new SelectCustomer();
            selectCustomer.Show();
            this.Close();
        }

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            //  check valid selection is made in listbox
            Console.WriteLine(listBoxAccounts.SelectedIndex);
            if (listBoxAccounts.SelectedIndex != -1)
            {
                accountController.SelectedAccount = (Account)listBoxAccounts.SelectedItem;
                showCurrentAccountOptions();
            }
        }

        private void buttonAccountInfo_Click_1(object sender, EventArgs e)
        {
            labelAccountInfo.Text = accountController.SelectedAccount.AccountInfo();
            labelAccountInfo.Visible = true;
        }

        private void buttonInterest_Click(object sender, EventArgs e)
        {
            showTransactionDetails(false);
            accountController.SelectedAccount.AddInterest();
            UpdateRecentTransactions();
            labelAccountInfo.Text = accountController.SelectedAccount.AccountInfo();
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            showTransactionDetails(true);
            labelAmount.Text = "Enter amount to deposit";
            buttonSubmit.Tag = "deposit";
        }

        private void buttonWithdrawal_Click(object sender, EventArgs e)
        {
            showTransactionDetails(true);
            labelAmount.Text = "Enter amount to withdraw";
            buttonSubmit.Tag = "withdrawal";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            double userInput;
            labelError.Visible = false;
            if (buttonSubmit.Tag.ToString() == "deposit" && Double.TryParse(textBoxAmount.Text, out userInput) && userInput > 0)
            {
                accountController.SelectedAccount.Deposit(userInput);
                UpdateRecentTransactions();
                resetTransactionDetails();
            }
            else if (buttonSubmit.Tag.ToString() == "withdrawal" && Double.TryParse(textBoxAmount.Text, out userInput) && userInput > 0)
            {
                try
                {
                    accountController.SelectedAccount.Withdrawal(userInput);
                    UpdateRecentTransactions();
                    resetTransactionDetails();
                }
                catch (FailedWithdrawalException ex)
                {
                    UpdateRecentTransactions();
                    labelError.Visible = true;
                    MessageBox.Show(ex.Message);
                }
            }
            else if (buttonSubmit.Tag.ToString() == "transfer" && Double.TryParse(textBoxAmount.Text, out userInput) && userInput > 0)
            {
                try
                {
                    accountController.SelectedAccount.Withdrawal(userInput);
                    Account recipientAccount = (Account)cbRecipientAccount.SelectedItem;
                    recipientAccount.Deposit(userInput);
                    UpdateRecentTransactions();
                    resetTransactionDetails();
                }
                catch (FailedWithdrawalException ex)
                {
                    UpdateRecentTransactions();
                    labelError.Visible = true;
                    MessageBox.Show(ex.Message);
                }
            }

            labelAccountInfo.Text = accountController.SelectedAccount.AccountInfo();
        }

        private void bTransfer_Click(object sender, EventArgs e)
        {
            showTransactionDetails(true);
            labelRecipientAccount.Visible = true;
            cbRecipientAccount.Visible = true;
            cbRecipientAccount.Items.Clear();
            for (int i = 0; i < customerController.SelectedCustomer.CustomerAccounts.Count; i++)
            {
                if (customerController.SelectedCustomer.CustomerAccounts[i] != accountController.SelectedAccount)
                {
                    cbRecipientAccount.Items.Add(customerController.SelectedCustomer.CustomerAccounts[i]);
                }
            }
            buttonSubmit.Tag = "transfer";
        }

        private void PopulateAccountListBox()
        {
            listBoxAccounts.Items.Clear();
            for (int i = 0; i < customerController.SelectedCustomer.CustomerAccounts.Count; i++)
            {
                listBoxAccounts.Items.Add(customerController.SelectedCustomer.CustomerAccounts[i]);
            }
        }

        public void RefreshList()
        {
            listBoxAccounts.Items.Clear();
            for (IIterator it = accountController.CreateIterator(); it.isDone() == false;)

            {

                listBoxAccounts.Items.Add(((Account)it.getNext()));

            }

        }

        private void UpdateRecentTransactions()
        {
            listBoxRecentTransactions.Items.Clear();
            string transactionString = accountController.SelectedAccount.TransactionString();
            listBoxRecentTransactions.Items.Add(transactionString);

            
        }
    }
}
