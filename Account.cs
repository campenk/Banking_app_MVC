using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    public abstract class Account : IAccountObserver
    {
        protected static int nextID = 1;
        protected int accountID;
        protected Customer customer;
        protected double balance;
        public List<IAccountObserver> MyObservers = new List<IAccountObserver>();

        public Account()
        {
            accountID = nextID;
            nextID++;
        }

        public Account(Customer c)
        {
            accountID = nextID;
            nextID++;
            customer = c;
            NotifyAccountObservers(this);
        }

        public abstract string AccountName();
        public abstract string AccountInfo();
        public abstract void AddInterest();
        public abstract string TransactionString();
        public abstract void Deposit(double despoit);
        public abstract void Withdrawal(double withdrawal);



        public int AccountID { get => accountID; }
        public double Balance { get => balance; }


        public Customer CustomerOnAccount { get => customer; set => customer = value; }

        public void AttachObserver(IAccountObserver obs)
        {
            MyObservers.Add(obs);
        }

        public void NotifyAccountObservers(Account acc)
        {
            foreach (IAccountObserver obs in MyObservers)
            {
                obs.UpdateAccount(acc);
            }
        }

        public void UpdateAccount(Account acc)
        {
            throw new NotImplementedException();
        }

        
    }
}
