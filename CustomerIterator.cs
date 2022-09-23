using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    class CustomerIterator: IIterator
    {
        private int currentIndex;
        private CustomerController customerController = new CustomerController();

        public CustomerIterator()
        {
            currentIndex = 0;
        }

        public Object getNext()
        {
            if (!isDone()) { return customerController.AllCustomers[currentIndex++]; }
            return null;
        }

        public bool isDone()
        {
            if (currentIndex < customerController.AllCustomers.Count) { return false; }
            return true;
        }
    }
}
