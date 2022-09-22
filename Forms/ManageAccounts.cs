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
        private AccountController accControl = new AccountController();
        private Controller custControl = new Controller();
        //  class variables

        public ManageAccounts()
        {
            InitializeComponent();
            PopulateAccountListBox();
            Update();
            Console.WriteLine("page loaded");

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
            listBoxRecentTransactions.Visible = true;
            gbRecentTransactions.Visible = true;
            labelAccountInfo.Visible = false;
            listBoxRecentTransactions.Items.Clear();
            labelAccountTitle.Text = accControl.SelectedAccount.AccountName() + " Account";

            if (accControl.SelectedAccount.AccountName() != "Everyday")
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
            for (int i = 0; i < custControl.SelectedCustomer.CustomerAccounts.Count; i++)
            {
                listBoxAccounts.Items.Add(custControl.SelectedCustomer.CustomerAccounts[i]);
            }
        }

        public void UpdateAccount(Account acc)
        {
            listBoxAccounts.Items.Add(acc);
        }

        private void bNewAccount_Click(object sender, EventArgs e)
        {
            Form newAccount = new NewAccount();
            newAccount.Show();
            this.Hide();
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Form selectCustomer = new SelectCustomer();
            selectCustomer.Show();
            this.Hide();
        }

        private void buttonGo_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("button clicked");


            //  check valid selection is made in listbox
            Console.WriteLine(listBoxAccounts.SelectedIndex);
            if (listBoxAccounts.SelectedIndex != -1)
            {
                accControl.SelectedAccount = (Account)listBoxAccounts.SelectedItem;
                showCurrentAccountOptions();
            }

        }

        private void buttonAccountInfo_Click_1(object sender, EventArgs e)
        {
            labelAccountInfo.Text = accControl.SelectedAccount.AccountInfo();
            labelAccountInfo.Visible = true;
        }

        private void buttonInterest_Click(object sender, EventArgs e)
        {
            showTransactionDetails(false);
            accControl.SelectedAccount.AddInterest();
            listBoxRecentTransactions.Items.Clear();
            listBoxRecentTransactions.Items.Add(accControl.SelectedAccount.TransactionString());
            labelAccountInfo.Text = accControl.SelectedAccount.AccountInfo();
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
                accControl.SelectedAccount.Deposit(userInput);
                listBoxRecentTransactions.Items.Clear();
                listBoxRecentTransactions.Items.Add(accControl.SelectedAccount.TransactionString());
                resetTransactionDetails();
            }
            else if (buttonSubmit.Tag.ToString() == "withdrawal" && Double.TryParse(textBoxAmount.Text, out userInput) && userInput > 0)
            {
                try
                {
                    accControl.SelectedAccount.Withdrawal(userInput);
                    listBoxRecentTransactions.Items.Clear();
                    listBoxRecentTransactions.Items.Add(accControl.SelectedAccount.TransactionString());
                    resetTransactionDetails();
                }
                catch (FailedWithdrawal ex)
                {
                    labelError.Visible = true;
                    MessageBox.Show(ex.Message);
                }
            }

            labelAccountInfo.Text = accControl.SelectedAccount.AccountInfo();
        }
    }
}
