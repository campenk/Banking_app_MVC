using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    class AccountController : IAccountSubject
    {
        private static Account selectedAccount;
        public List<IAccountObserver> MyObservers = new List<IAccountObserver>();

        //  Creates new Everyday object
        public void CreateEverydayAccount(Customer cust, double balance)
        {            
                Everyday everyday = new Everyday(cust, balance);
                cust.addtoCustomerAccounts(everyday);
                NotifyAccountObservers(everyday);         
        }

        public void CreateInvestmentAccount(Customer cust, double interestRate, double fee, double balance)
        {
            Investment investment = new Investment(cust, interestRate, fee, balance);
            cust.addtoCustomerAccounts(investment);
            NotifyAccountObservers(investment);
        }

        public void CreateOmniAccount(Customer cust, double interestRate, double overdraft, double fee, double balance)
        {
            Omni omni = new Omni(cust, interestRate,overdraft, fee, balance);
            cust.addtoCustomerAccounts(omni);
            NotifyAccountObservers(omni);
        }





        // getter and setter for selectedAccount
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

        

        public void AttachAccountObserver(IAccountObserver obs)
        {
            MyObservers.Add(obs);
        }

        public void NotifyAccountObservers(Account account)
        {
            foreach (IAccountObserver obs in MyObservers)
            {
                obs.UpdateAccount(account);
            }
        }


    }
}
