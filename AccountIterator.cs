using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    class AccountIterator: IIterator
    {
        private int currentIndex;
        private CustomerController customerController = new CustomerController();

        public AccountIterator()
        {
            currentIndex = 0;
        }

        public Object getNext()
        {
            if (!isDone()) { return customerController.SelectedCustomer.CustomerAccounts[currentIndex++]; }
            return null;
        }

        public bool isDone()
        {
            if (currentIndex < customerController.SelectedCustomer.CustomerAccounts.Count) { return false; }
            return true;
        }
    }
}
