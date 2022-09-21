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
        private Controller control = new Controller();
        //  class variables
        private Customer c;
        private List<Account> accountList;
        private Account currentAccount;

        public ManageAccounts()
        {
            InitializeComponent();
            PopulateAccountListBox();
            Update();
        }

        /******************
         * EVENT HANDLERS
         ******************/
        private void buttonGo_Click(object sender, EventArgs e)
        {
            //  check valid selection is made in listbox
            if (listBoxAccounts.SelectedIndex != -1)
            {
                currentAccount = accountList[listBoxAccounts.SelectedIndex];
                showCurrentAccountOptions();
            }
        }

        private void buttonAccountInfo_Click(object sender, EventArgs e)
        {
            labelAccountInfo.Text = currentAccount.AccountInfo();
            labelAccountInfo.Visible = true;
        }

        private void buttonInterest_Click(object sender, EventArgs e)
        {
            showTransactionDetails(false);
            currentAccount.AddInterest();
            listBoxRecentTransactions.Items.Clear();
            listBoxRecentTransactions.Items.Add(currentAccount.TransactionString());
            labelAccountInfo.Text = currentAccount.AccountInfo();
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
                currentAccount.Deposit(userInput);
                listBoxRecentTransactions.Items.Clear();
                listBoxRecentTransactions.Items.Add(currentAccount.TransactionString());
                resetTransactionDetails();
            }
            else if (buttonSubmit.Tag.ToString() == "withdrawal" && Double.TryParse(textBoxAmount.Text, out userInput) && userInput > 0)
            {
                try
                {
                    currentAccount.Withdrawal(userInput);
                    listBoxRecentTransactions.Items.Clear();
                    listBoxRecentTransactions.Items.Add(currentAccount.TransactionString());
                    resetTransactionDetails();
                }
                catch (FailedWithdrawal ex)
                {
                    labelError.Visible = true;
                    MessageBox.Show(ex.Message);
                }
            }

            labelAccountInfo.Text = currentAccount.AccountInfo();
        }

        private void showCurrentAccountOptions()
        {
            labelAccountTitle.Visible = true;
            buttonAccountInfo.Visible = true;
            labelAccountInfo.Visible = false;
            buttonDeposit.Visible = true;
            buttonWithdrawal.Visible = true;
            listBoxRecentTransactions.Visible = true;
            gbRecentTransactions.Visible = true;
            labelAccountInfo.Visible = false;
            listBoxRecentTransactions.Items.Clear();
            labelAccountTitle.Text = currentAccount.AccountName() + " Account";

            if (currentAccount.AccountName() != "Everyday")
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
        }

        private void resetTransactionDetails()
        {
            labelError.Visible = false;
            textBoxAmount.Text = "";
        }

        private void PopulateAccountListBox()
        {
            listBoxAccounts.Items.Clear();
            Console.WriteLine(control.SelectedCustomer.CustomerAccounts.Count);
            for (int i = 0; i < control.SelectedCustomer.CustomerAccounts.Count; i++)
            {
                listBoxAccounts.Items.Add(control.SelectedCustomer.CustomerAccounts[i]);
                Console.WriteLine(control.SelectedCustomer.CustomerAccounts[i]);
            }
        }

        public void UpdateAccount(Account acc)
        {
            listBoxAccounts.Items.Add(acc);
        }

        private void bNewAccount_Click(object sender, EventArgs e)
        {

        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Form selectCustomer = new SelectCustomer();
            selectCustomer.Show();
            this.Hide();
        }
    }
}
