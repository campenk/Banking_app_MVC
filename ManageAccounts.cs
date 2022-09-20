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
        public ManageAccounts()
        {
            InitializeComponent();
            Update();
        }

        private void PopulateAccountListBox()
        {
            listBoxAccounts.Items.Clear();
            for (int i = 0; i < control.AllCustomers.Count; i++)
            {
                listBoxAccounts.Items.Add(control.AllCustomers[i].FullName);
            }
        }

        public void UpdateCustomer(Customer c)
        {
            listBoxAccounts.Items.Add(c.FullName);
        }

        private void bNewAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
