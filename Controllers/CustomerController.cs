using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    /// <summary>
    /// Controller for the Customer object. 
    /// Implements Observer/Subject pattern through ICustomerSubject interface
    /// Implements Iterator pattern through Iterator interface
    /// Serializable class
    /// </summary>
    [Serializable]
    public class CustomerController:ICustomerSubject
    {
        private static List<Customer> allCustomers = new List<Customer>();
        private static Customer selectedCustomer;
        public List<ICustomerObserver> MyObservers = new List<ICustomerObserver>();

        /// <summary>
        /// Creates a new Customer object, adds to the allCustomers list, and notifies the Customer Observer
        /// </summary>
        /// <param name="firstName">The string to be set for firstName</param>
        /// <param name="lastName">The string to be set for the lastName</param>
        /// <param name="phoneNumber">The string to be set for the phoneNumber</param>
        /// <param name="staffDiscount">The bool to be set for staffDiscount</param>
        public void CreateCustomer(string firstName, string lastName, string phoneNumber, bool staffDiscount)
        {
            Customer c = new Customer(firstName, lastName, phoneNumber, staffDiscount);
            allCustomers.Add(c);
            //Investment investment = new Investment(c, 4, 10, 750);
            //Omni omni = new Omni(c, 2, -1000, 10, 300);
            //Everyday everyday = new Everyday(c, 150);
            //c.addtoCustomerAccounts(investment);
            //c.addtoCustomerAccounts(omni);
            //c.addtoCustomerAccounts(everyday);
            NotifyCustomerObservers(c);
        }

        /// <summary>
        /// Edits the selected customer if the inputs pass validation
        /// </summary>
        /// <param name="firstName">The string to be set for firstName</param>
        /// <param name="lastName">The string to be set for the lastName</param>
        /// <param name="phoneNumber">The string to be set for the phoneNumber</param>
        /// <param name="staffDiscount">The bool to be set for staffDiscount</param>
        /// <exception cref="InvalidInputException">Thrown if parameters contain invalid characters</exception>
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


        /// <summary>
        /// Deletes selected customer from allCustomers list
        /// </summary>        
        public void DeleteCustomer()
        {
            allCustomers.Remove(selectedCustomer);
        }

        /// <summary>
        /// Getter and setter for AllCustomers list
        /// </summary>
        /// <returns>returns List of Customer objects</returns>
        public List<Customer> AllCustomers { get => allCustomers; set => allCustomers = value; }

        /// <summary>
        /// Getter and setter for SelectedCustomer object
        /// </summary>
        /// <returns>returns Customer object</returns>
        public Customer SelectedCustomer
        {
            get
            {
                return selectedCustomer;
            }
            set
            {                
                    selectedCustomer = value;              
            }
        }

        /// <summary>
        /// Attaches Observer to MyObservers List of ICustomerObserver objects
        /// </summary>
        /// <param name="obs">ICustomerObserver object to attach</param>
        public void AttachObserver(ICustomerObserver obs)
        {
            MyObservers.Add(obs);
        }

        /// <summary>
        /// Notifies Observers about update to Customer object
        /// </summary>
        /// <param name="c">Updated Customer object</param>
        public void NotifyCustomerObservers(Customer c)
        {
            foreach (ICustomerObserver obs in MyObservers)
            {
                obs.UpdateCustomer(c);
            }
        }

        /// <summary>
        /// Creates new CustomerIterator object
        /// </summary>
        /// <returns>Returns Iterator object</returns>
        public IIterator CreateIterator()
        {
            return new CustomerIterator();
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

    }
}
