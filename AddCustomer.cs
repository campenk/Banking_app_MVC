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
    public partial class AddCustomer : BIT706_A2_Campen_5047211.ParentForm
    {        
        private Controller control = new Controller();
                            
        public AddCustomer()
        {
            InitializeComponent();
        }

        /*
         *  EVENT HANDLERS
         */
        private void bSubmit_Click(object sender, EventArgs e)
        {
            bool nullValuePresent;
            string firstName = tbFirstName.Text;
            string lastName = tbLastName.Text;
            string phoneNumber = tbPhoneNo.Text;
            bool staffDicsount = cbStaffDiscount.Checked;

            //  check if any input fields contain null values
            if (IsNullValue(firstName) || IsNullValue(lastName) || IsNullValue(phoneNumber) )
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
                    control.CreateCustomer(firstName, lastName, phoneNumber, staffDicsount);

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

                catch (InvalidInputException exception)
                {
                    MessageBox.Show(exception.Message);
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

        //  resets form inputs
        private void bReset_Click(object sender, EventArgs e)
        {
            ResetFormContents();        
        }

        //  returns to CustomerOptions menu
        private void bBack_Click(object sender, EventArgs e)
        {
            Form customerOptions = new CustomerOptions();
            customerOptions.Show();
            this.Close();
        }

        /*
         *  CLASS METHODS
         */

        //  resets form inputs
        private void ResetFormContents()
        {
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPhoneNo.Text = "";
            cbStaffDiscount.Checked = false;
        }

        //  returns true if string is empty
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
