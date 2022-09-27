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
    public partial class CustomerOptions : BIT706_A2_Campen_5047211.ParentForm, IObserver
    {
        private Controller control = new Controller();
        public CustomerOptions()
        {
            InitializeComponent();
            control.CreateTestData();
            PopulateCustomerListBox();
        }
        
        private void CustomerOptions_Load(object sender, EventArgs e)
        {
            Update();      
        }

        /*
         *  EVENT HANDLERS
         */

        //  opens AddCustomer form
        private void bAddNewCustomer_Click(object sender, EventArgs e)
        {
            Form addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }       

        //  checks a valid customer has been selected then opens EditCustomer form
        private void bEditCustomer_Click(object sender, EventArgs e)
        {
            //  checks a customer has been selected
            if (lbCustomerList.SelectedIndex == -1)
            {
                string message = "Please select a customer";
                string caption = "No customer selected";                
                MessageBox.Show(message, caption, MessageBoxButtons.OK);               
            }
            else
            {
                //  checks selected customer is valid
                try
                {
                    control.SelectedCustomer = control.AllCustomers[lbCustomerList.SelectedIndex];
                    Form editCustomer = new EditCustomer();
                    editCustomer.Show();
                    this.Close();
                }
                catch (InvalidInputException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //  checks a valid customer has been selected then deletes that customer
        private void bDeleteCustomer_Click(object sender, EventArgs e)
        {
            //  checks a customer has been selected
            if (lbCustomerList.SelectedIndex == -1)
            {
                string message = "Please select a customer";
                string caption = "No customer selected";
                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
            else
            {
                //  checks selected customer is valid
                try
                {
                    control.SelectedCustomer = control.AllCustomers[lbCustomerList.SelectedIndex];
                    string message = "Please confirm you would like to delete " + control.SelectedCustomer.FullName;
                    string caption = "Confirm deletion";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;
                    result = MessageBox.Show(message, caption, buttons);
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        control.DeleteCustomer();
                        PopulateCustomerListBox();
                    }
                }
                catch (InvalidInputException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }        

        //  returns to dashboard menu
        private void bBack_Click(object sender, EventArgs e)
        {
            Form dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }

        //  populates lbCustomerList with Customer objects from the AllCustomers list
        private void PopulateCustomerListBox()
        {
            lbCustomerList.Items.Clear();
            for (int i = 0; i < control.AllCustomers.Count; i++)
            {
                lbCustomerList.Items.Add(control.AllCustomers[i].FullName);
            }
        }

        public void Update(Customer c)
        {
            lbCustomerList.Items.Add(c.FullName);
        }
    }
}
