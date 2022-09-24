using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    [Serializable]
    public class Everyday : Account
    {
        private string accountName = "Everyday";
        private string transactionString;

        public Everyday(Customer newCustomer, double newBalance)
        {            
            customer = newCustomer;
            balance = newBalance;
        }
        public override string AccountInfo()
        {
            return "Everyday " + accountID + "; Balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
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
            if ((balance - withdrawal) > 0)
            {
                balance -= withdrawal;
                transactionString = "Everyday " + accountID + ";  withdrawal $" + withdrawal + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
            }
            else
            {
                transactionString = "Everyday " + accountID + ";  withdrawal $" + withdrawal + ";  transaction failed;  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
                throw new FailedWithdrawalException(accountName + " account: Withdrawal failed due to insufficient funds");
            }
        }

        public override void Deposit(double deposit)
        {
            balance += deposit;
            transactionString = "Everyday " + accountID + ";  deposit $" + deposit + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
        }

        public override void AddInterest()
        { }

        public override string ToString()
        {
            return accountName + " " + accountID;
        }

        //  returns true if string contains a numeric character
        public override bool IsDigitPresent(string input)
        {
            return input.Any(c => char.IsDigit(c));
        }

        //  returns true if string contains an alphabet character
        public override bool IsLetterPresent(string input)
        {
            return !input.All(c => char.IsDigit(c));
        }
    }
}
