using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    class Controller:ICustomerSubject
    {
        private static List<Customer> allCustomers = new List<Customer>();
        private static Customer selectedCustomer;
        public List<ICustomerObserver> MyObservers = new List<ICustomerObserver>();

        //  Creates new Customer object and adds to the list allCustomers
        public void CreateCustomer(string firstName, string lastName, string phoneNumber, bool staffDiscount)
        {
            Customer c = new Customer(firstName, lastName, phoneNumber, staffDiscount);
            allCustomers.Add(c);
            NotifyCustomerObservers(c);
        }

        //  edits the selected customer if the inputs pass validation
        public void EditCustomer(string firstName, string lastName, string phoneNumber, bool staffDiscount)
        {
            string errorMessage = "These fields contain invalid characters:";
            bool inputErrorExists = false;
            try
            {
                selectedCustomer.FirstName = firstName;
            }
            catch (InvalidInputException ex)
            {
                errorMessage += Environment.NewLine + " First Name";
                inputErrorExists = true;
            }
            try
            {
                selectedCustomer.LastName = lastName;
            }
            catch (InvalidInputException ex)
            {
                errorMessage += Environment.NewLine + " Last Name";
                inputErrorExists = true;
            }
            try
            {
                selectedCustomer.ContactNo = phoneNumber;
                selectedCustomer.StaffDiscount = staffDiscount;
            }
            catch (InvalidInputException ex)
            {
                errorMessage += Environment.NewLine + " Contact Number";
                inputErrorExists = true;
            }

            if (inputErrorExists == true)
            { throw new InvalidInputException(errorMessage); }
        }

        //  deletes selected customer from allCustomers list
        public void DeleteCustomer()
        {
            allCustomers.Remove(selectedCustomer);
        }

        //  getter and setter for AllCustomers
        public List<Customer> AllCustomers { get => allCustomers; set => allCustomers = value; }

        // getter and setter for SelectedCustomer with validation
        public Customer SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {
                if (allCustomers.Contains(selectedCustomer))
                {
                    selectedCustomer = value;
                }
                else
                {
                   throw new InvalidInputException("Customer not found");
                }
            }
        }

        //  Creates test customer data
        public void CreateTestData()
        {
            if (allCustomers.Count == 0)
            {
                CreateCustomer("Sarah", "Smith", "0211111111", false);
                CreateCustomer("Lisa", "Brown", "0211111112", false);
                CreateCustomer("Tina", "Anderson", "0211111113", false);
                CreateCustomer("Robert", "Watson", "0211111114", true);
                CreateCustomer("Chris", "Smart", "0211111115", false);
                CreateCustomer("Liam", "Pollock", "0211111116", false);
                CreateCustomer("Tim", "Lawson", "0211111117", true);
                CreateCustomer("Frank", "Hammond", "0211111118", false);
                CreateCustomer("Anna", "Williams", "0211111119", false);
                CreateCustomer("Erica", "Roberston", "0211111110", true);
                CreateCustomer("Jess", "Wilson", "0211111121", false);
                CreateCustomer("Sam", "McLean", "0211111122", false);
                CreateCustomer("Bob", "Smith", "0211111123", false);
            }
        }

        public void AttachObserver(ICustomerObserver obs)
        {
            MyObservers.Add(obs);
        }

        public void NotifyCustomerObservers(Customer c)
        {
            foreach (ICustomerObserver obs in MyObservers)
            {
                obs.UpdateCustomer(c);
            }
        }


    }
}
