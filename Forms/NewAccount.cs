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
        AccountController accControl = new AccountController();
        Controller custControl = new Controller();
        public NewAccount()
        {
            InitializeComponent();
        }

        private void cbAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Point pointControl1 = new Point(181, 182);
            Point pointControl2 = new Point(181, 240);
            Point pointControl3 = new Point(181, 298);
            Point pointControl4 = new Point(181, 356);
            Point pointControl5 = new Point(181, 413);
            Point pointLabel1 = new Point(52, 182);
            Point pointLabel2 = new Point(52, 240);
            Point pointLabel3 = new Point(52, 298);
            Point pointLabel4 = new Point(52, 356);
            Point pointLabel5 = new Point(52, 413);

            try
            {
                if (cbAccountType.SelectedIndex != -1)
                {
                    if (cbAccountType.SelectedItem.ToString() == "Everyday")
                    {
                        labelBalance.Location = pointLabel1;
                        labelBalance.Visible = true;
                        tbBalance.Location = pointControl1;
                        tbBalance.Visible = true;

                        bSubmit.Location = pointControl2;
                        bSubmit.Visible = true;
                        bReset.Location = new Point(333, 240);
                        bReset.Visible = true;

                    }
                    else if (cbAccountType.SelectedItem.ToString() == "Investment")
                    {
                        labelFee.Location = pointLabel1;
                        labelFee.Visible = true;
                        tbFee.Location = pointControl1;
                        tbFee.Visible = true;

                        labelInterestRate.Location = pointLabel2;
                        labelInterestRate.Visible = true;
                        tbInterestRate.Location = pointControl2;
                        tbInterestRate.Visible = true;

                        labelBalance.Location = pointLabel3;
                        labelBalance.Visible = true;
                        tbBalance.Location = pointControl3;
                        tbBalance.Visible = true;

                        bSubmit.Location = pointControl4;
                        bSubmit.Visible = true;
                        bReset.Location = new Point(333, 356);
                        bReset.Visible = true;
                    }
                    else if (cbAccountType.SelectedItem.ToString() == "Omni")
                    {
                        labelFee.Location = pointLabel1;
                        labelFee.Visible = true;
                        tbFee.Location = pointControl1;
                        tbFee.Visible = true;

                        labelInterestRate.Location = pointLabel2;
                        labelInterestRate.Visible = true;
                        tbInterestRate.Location = pointControl2;
                        tbInterestRate.Visible = true;

                        labelOverdraft.Location = pointLabel3;
                        labelOverdraft.Visible = true;
                        tbOverdraft.Location = pointControl3;
                        tbOverdraft.Visible = true;

                        labelBalance.Location = pointLabel4;
                        labelBalance.Visible = true;
                        tbBalance.Location = pointControl4;
                        tbBalance.Visible = true;

                        bSubmit.Location = pointControl5;
                        bSubmit.Visible = true;
                        bReset.Location = new Point(333, 413);
                        bReset.Visible = true;
                    }
                }
            }
            catch (NullReferenceException ex)
            {

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
                double balance;
                if (Double.TryParse(tbBalance.Text, out balance))
                {
                    try
                    {
                        accControl.CreateEverydayAccount(custControl.SelectedCustomer, balance);
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
                double balance;
                double fee;
                double interestRate;
                if (Double.TryParse(tbBalance.Text, out balance) && Double.TryParse(tbFee.Text, out fee) && Double.TryParse(tbInterestRate.Text, out interestRate))
                {
                    try
                    {
                        accControl.CreateInvestmentAccount(custControl.SelectedCustomer, interestRate, fee, balance);
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
                double balance;
                double fee;
                double interestRate;
                double overdraft;
                if (Double.TryParse(tbBalance.Text, out balance) && Double.TryParse(tbFee.Text, out fee) && Double.TryParse(tbInterestRate.Text, out interestRate) && Double.TryParse(tbOverdraft.Text, out overdraft))
                {
                    try
                    {
                        accControl.CreateOmniAccount(custControl.SelectedCustomer, interestRate, overdraft, fee, balance);
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
            string message = "Would you like to return to the Customer Options menu?";
            string caption = "New customer created successfully!";
            DialogResult result;
            result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

            //  check customer input on message box
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Form customerOptions = new CustomerOptions();
                customerOptions.Show();
                this.Close();
            }
            else if (result == System.Windows.Forms.DialogResult.No)
            {
                ResetFormContents();
            }
        }

    }
}
