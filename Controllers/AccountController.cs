using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    /// <summary>
    /// Controller for the Account object. 
    /// Implements Observer/Subject pattern through IAccountSubject interface
    /// Implements Iterator pattern through Iterator interface
    /// Serializable class
    /// </summary>
    [Serializable]
    class AccountController : IAccountSubject
    {
        private static Account selectedAccount;
        public List<IAccountObserver> MyObservers = new List<IAccountObserver>();

        /// <summary>
        /// Creates a new Everyday object (child class of Account), adds to the CustomerAccounts list for that Customer, and notifies Account Observers
        /// </summary>
        /// <param name="cust">Customer object who owns the Everyday object to be created</param>
        /// <param name="balance">double value to be set for balance</param>
        public void CreateEverydayAccount(Customer cust, double balance)
        {            
                Everyday everyday = new Everyday(cust, balance);
                cust.addtoCustomerAccounts(everyday);
                NotifyAccountObservers(everyday);         
        }

        /// <summary>
        /// Creates a new Investment object (child class of Account), adds to the CustomerAccounts list for that Customer, and notifies Account Observers
        /// </summary>
        /// <param name="cust">Customer object who owns the Investment object to be created</param>
        /// <param name="interestRate">double value to be set for interestRate</param>
        /// <param name="fee">double value to be set for fee</param>
        /// <param name="balance">double value to be set for balance</param>
        public void CreateInvestmentAccount(Customer cust, double interestRate, double fee, double balance)
        {
            Investment investment = new Investment(cust, interestRate, fee, balance);
            cust.addtoCustomerAccounts(investment);
            NotifyAccountObservers(investment);
        }

        /// <summary>
        /// Creates a new Omni object (child class of Account), adds to the CustomerAccounts list for that Customer, and notifies Account Observers
        /// </summary>
        /// <param name="cust">Customer object who owns the Omni object to be created</param>
        /// <param name="interestRate">double value to be set for interestRate</param>
        /// <param name="overdraft">double value to be set for overdraft</param>
        /// <param name="fee">double value to be set for fee</param>
        /// <param name="balance">double value to be set for balance</param>
        public void CreateOmniAccount(Customer cust, double interestRate, double overdraft, double fee, double balance)
        {
            Omni omni = new Omni(cust, interestRate,overdraft, fee, balance);
            cust.addtoCustomerAccounts(omni);
            NotifyAccountObservers(omni);
        }

        /// <summary>
        /// Getter and setter for selectedAccount object
        /// </summary>
        /// <returns>returns an Account object</returns>
        public Account SelectedAccount
        {
            get
            {
                return selectedAccount;
            }
            set
            {
                selectedAccount = value;
            }
        }

        /// <summary>
        /// Attaches Observer to MyObservers List of IAccountObserver objects
        /// </summary>
        /// <param name="obs">ICustomerObserver object to attach</param>
        public void AttachAccountObserver(IAccountObserver obs)
        {
            MyObservers.Add(obs);
        }

        /// <summary>
        /// Notifies Observers about update to Account object
        /// </summary>
        /// <param name="account">Updated Account object</param>
        public void NotifyAccountObservers(Account account)
        {
            foreach (IAccountObserver obs in MyObservers)
            {
                obs.UpdateAccount(account);
            }
        }

        /// <summary>
        /// Creates new AccountIterator object
        /// </summary>
        /// <returns>Iterator object</returns>
        public IIterator CreateIterator()
        {
            return new AccountIterator();
        }
    }
}
