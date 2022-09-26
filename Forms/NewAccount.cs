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
    public partial class NewAccount : BIT706_A2_Campen_5047211.ParentForm
    {
        AccountController accountController = new AccountController();
        CustomerController customerController = new CustomerController();
        public NewAccount()
        {
            InitializeComponent();
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int xControlPoint = 181;
            int xLabelPoint =  52;
            int xResetButtonPoint = 333;
            int yPoint1 = 182;
            int yPoint2 = 240;
            int yPoint3 = 298;
            int yPoint4 = 356;
            int yPoint5 = 413;
            
            if (cbAccountType.SelectedIndex == -1)
            {

            }
            else
            {
                Console.WriteLine(cbAccountType.SelectedIndex);
                {
                    string selectedAccountType = cbAccountType.SelectedItem.ToString();
                    Console.WriteLine(selectedAccountType);
                    if (selectedAccountType == "Everyday")
                    {
                        SetFormControlPosition(labelBalance, xLabelPoint, yPoint1);
                        SetFormControlPosition(tbBalance, xControlPoint, yPoint1);

                        SetFormControlPosition(bSubmit, xControlPoint, yPoint2);
                        SetFormControlPosition(bReset, xResetButtonPoint, yPoint2);

                    }
                    else if (selectedAccountType == "Investment")
                    {
                        SetFormControlPosition(labelFee, xLabelPoint, yPoint1);
                        SetFormControlPosition(tbFee, xControlPoint, yPoint1);

                        SetFormControlPosition(labelInterestRate, xLabelPoint, yPoint2);
                        SetFormControlPosition(tbInterestRate, xControlPoint, yPoint2);

                        SetFormControlPosition(labelBalance, xLabelPoint, yPoint3);
                        SetFormControlPosition(tbBalance, xControlPoint, yPoint3);

                        SetFormControlPosition(bSubmit, xControlPoint, yPoint4);
                        SetFormControlPosition(bReset, xResetButtonPoint, yPoint4);


                    }
                    else if (selectedAccountType == "Omni")
                    {

                        SetFormControlPosition(labelFee, xLabelPoint, yPoint1);
                        SetFormControlPosition(tbFee, xControlPoint, yPoint1);

                        SetFormControlPosition(labelInterestRate, xLabelPoint, yPoint2);
                        SetFormControlPosition(tbInterestRate, xControlPoint, yPoint2);

                        SetFormControlPosition(labelOverdraft, xLabelPoint, yPoint3);
                        SetFormControlPosition(tbOverdraft, xControlPoint, yPoint3);

                        SetFormControlPosition(labelBalance, xLabelPoint, yPoint4);
                        SetFormControlPosition(tbBalance, xControlPoint, yPoint4);


                        SetFormControlPosition(bSubmit, xControlPoint, yPoint5);
                        SetFormControlPosition(bReset, xResetButtonPoint, yPoint5);
                    }
                }
            }   
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            ResetFormContents();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            string selectedAccountType = cbAccountType.Text;

            if (selectedAccountType == "Everyday")
            {
                if (Double.TryParse(tbBalance.Text, out double balance))
                {
                    try
                    {
                        accountController.CreateEverydayAccount(customerController.SelectedCustomer, balance);
                        AccountCreatedMessage();
                    }
                    catch (InvalidInputException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    throw new InvalidInputException("Invalid input");
                }
            }
            else if (selectedAccountType == "Investment")
            {
                if (Double.TryParse(tbBalance.Text, out double balance) && Double.TryParse(tbFee.Text, out double fee) && Double.TryParse(tbInterestRate.Text, out double interestRate))
                {
                    try
                    {
                        accountController.CreateInvestmentAccount(customerController.SelectedCustomer, interestRate, fee, balance);
                        AccountCreatedMessage();
                    }
                    catch (InvalidInputException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    throw new InvalidInputException("Invalid input");
                }
            }

            else if (selectedAccountType == "Omni")
            {
                if (Double.TryParse(tbBalance.Text, out double balance) && Double.TryParse(tbFee.Text, out double fee) && Double.TryParse(tbInterestRate.Text, out double interestRate) && Double.TryParse(tbOverdraft.Text, out double overdraft))
                {
                    try
                    {
                        accountController.CreateOmniAccount(customerController.SelectedCustomer, interestRate, overdraft, fee, balance);
                        AccountCreatedMessage();
                    }
                    catch (InvalidInputException exception)
                    {
                        MessageBox.Show(exception.Message);
                    }
                }
                else
                {
                    throw new InvalidInputException("Invalid input");
                }
            }
        }
        private void ResetFormContents()
        {
            cbAccountType.SelectedIndex = -1;
            labelInterestRate.Visible = false;
            labelOverdraft.Visible = false;
            labelFee.Visible = false;
            labelBalance.Visible = false;
            tbFee.Visible = false;
            tbInterestRate.Visible = false;
            tbOverdraft.Visible = false;
            tbBalance.Visible = false;
            bSubmit.Visible = false;
            bReset.Visible = false;
        }

        private void AccountCreatedMessage()
        {
            //  show message box with success message and option to return to CustomerOptions menu
            string message = "Would you like to return to the Manage Accounts menu?";
            string caption = "New account created successfully!";
            DialogResult result;
            result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            //  check customer input on message box
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Form manageAccounts = new ManageAccounts();
                manageAccounts.Show();
                this.Close();
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                ResetFormContents();
            }
        }

        private void SetFormControlPosition(Control control, int xPosition, int yPosition)
        {
            control.Visible = true;
            control.Location = new Point(xPosition, yPosition);
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Form manageAccounts = new ManageAccounts();
            manageAccounts.Show();
            this.Close();
        }
    }
}
