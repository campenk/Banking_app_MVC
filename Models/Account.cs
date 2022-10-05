using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    [Serializable]
    public abstract class Account 
    {
        protected static int nextID = 1;
        protected int accountID;
        protected Customer customer;
        protected double balance;
        protected CustomerController custControl = new CustomerController();
        public Account()
        {
            accountID = AccountSingleton.NextId;
        }

        public Account(Customer c)
        {
            accountID = AccountSingleton.NextId;

            if (custControl.AllCustomers.Contains(c))
            {
                customer = c;
            }
            else
            {
                throw new InvalidInputException("Invalid customer selected");
            }
        }

        public abstract string AccountName();
        public abstract string AccountInfo();
        public abstract void AddInterest();
        public abstract string TransactionString();
        public abstract void Deposit(double despoit);
        public abstract void Withdrawal(double withdrawal);
        public abstract bool IsDigitPresent(string input);
        public abstract bool IsLetterPresent(string input);

        public int AccountID { get => accountID; }
        public double Balance { get => balance; }

        public Customer CustomerOnAccount { get => customer; set => customer = value; }       

        public void UpdateAccount(Account acc)
        {
            throw new NotImplementedException();
        }  
    }
}
