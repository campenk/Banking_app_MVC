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
    public partial class SelectCustomer : BIT706_A2_Campen_5047211.ParentForm
    {
        private CustomerController customerController = new CustomerController();

        public SelectCustomer()
        {
            InitializeComponent();
            PopulateCustomerListBox();
        }

        //  populates lbCustomerList with Customer objects from the AllCustomers list
        private void PopulateCustomerListBox()
        {
            lbCustomerList.Items.Clear();
            for (int i = 0; i < customerController.AllCustomers.Count; i++)
            {
                lbCustomerList.Items.Add(customerController.AllCustomers[i]);
            }
        }

        private void bSubmit_Click(object sender, EventArgs e)
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
                    customerController.SelectedCustomer = (Customer)lbCustomerList.SelectedItem;
                    Form manageAccount = new ManageAccounts();
                    manageAccount.Show();
                    this.Close();
                }
                catch (InvalidInputException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            Form dashboard = new Dashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
