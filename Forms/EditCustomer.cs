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
    public partial class EditCustomer : BIT706_A2_Campen_5047211.ParentForm        

    {
        private CustomerController control = new CustomerController();
        public EditCustomer()
        {
            InitializeComponent();
            //  populates input fields with data from selected customer
            tbFirstName.Text = control.SelectedCustomer.FirstName;
            tbLastName.Text = control.SelectedCustomer.LastName;
            tbPhoneNo.Text = control.SelectedCustomer.ContactNo;
            cbStaffDiscount.Checked = control.SelectedCustomer.StaffDiscount;            
        }

        //  resets form inputs
        private void bReset_Click(object sender, EventArgs e)
        {
            ResetFormContents();
        }

        //  saves customer data if inputs are valid

        private void bSubmit_Click(object sender, EventArgs e)
        {
            bool nullValuePresent;
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phoneNumber = tbPhoneNo.Text;
            bool staffDicsount = cbStaffDiscount.Checked;

            //  checks if any input fields are empty
            if (IsNullValue(firstName) || IsNullValue(lastName) || IsNullValue(phoneNumber))
            {
                nullValuePresent = true;
            }
            else
            {
                nullValuePresent = false;
            }

            if (nullValuePresent == false)
            {
                try
                {
                    control.EditCustomer(firstName, lastName, phoneNumber, staffDicsount);
                    //  show message box with success message and option to return to CustomerOptions menu
                    string message = "Would you like to return to the Customer Options menu?";
                    string caption = "Customer edited successfully!";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);

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
                catch (InvalidInputException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //  else if nullValuePresent == true
            else
            {
                string message = "Please check all fields are filled out";
                string caption = "Error";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
        }

        // return to CustomerOptions menu
        private void bBack_Click(object sender, EventArgs e)
        {
            Form customerOptions = new CustomerOptions();
            customerOptions.Show();
            this.Close();
        }

        //  resets form input fields
        private void ResetFormContents()
        {
            tbFirstName.Text = control.SelectedCustomer.FirstName;
            tbLastName.Text = control.SelectedCustomer.LastName;
            tbPhoneNo.Text = control.SelectedCustomer.ContactNo;
            cbStaffDiscount.Checked = control.SelectedCustomer.StaffDiscount;
        }

        // returns true if string is empty
        private bool IsNullValue(string c)
        {
            if (c == null || c == "")
            {
                return true;
            }
            return false;
        }
    }
}
