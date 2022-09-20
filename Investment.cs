using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    public class Investment : Account
    {
        private string accountName = "Investment";
        private double interestRate;
        private double fee;
        private string transactionString;

        public Investment(Customer newCustomer, double newInterestRate, double newFee, double newBalance)
        {
            customer = newCustomer;
            interestRate = newInterestRate;
            if (customer.StaffDiscount == true)
            {
                fee = newFee / 2;
            }
            else
            {
                fee = newFee;
            }
            balance = newBalance;
        }
        public override string AccountInfo()
        {
            return "Investment " + accountID + "; Interest Rate " + interestRate + "%; Fee $" + fee + "; Balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
        }
        public override string AccountName()
        {
            return accountName;
        }
        public override string TransactionString()
        {
            return transactionString;
        }

        public override void Withdrawal(double withdrawal)
        {
            if ((balance - withdrawal) < 0)
            {
                balance -= fee;
                transactionString = "Investment " + accountID + ";  withdrawal $" + withdrawal + ";  transaction failed;  fee $" + fee + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
                throw new FailedWithdrawal(accountName + " account: Withdrawal failed due to insufficient funds");
            }
            else
            {
                balance -= withdrawal;
                transactionString = "Investment " + accountID + ";  withdrawal $" + withdrawal + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
            }
        }

        public override void Deposit(double deposit)
        {
            balance += deposit;
            transactionString = "Investment " + accountID + ";  deposit $" + deposit + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
        }

        public override void AddInterest()
        {
            double interest = balance * (interestRate / 100);
            balance += interest;
            transactionString = "Investment " + accountID + ";  add interest $" + interest + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
        }

        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double Fee { get => fee; set => fee = value; }
    }
}
