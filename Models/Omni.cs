using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    public class Omni : Account
    {
        private string accountName = "Omni";
        private double interestRate;
        private double overdraft;
        private double fee;
        private string transactionString;

        public Omni(Customer newCustomer, double newInterestRate, double newOverdraft, double newFee, double newBalance)
        {
            customer = newCustomer;
            interestRate = newInterestRate;
            overdraft = newOverdraft;

            //  TODO: Staff discount should be processed at the point of charging fees, not here
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
            return "Omni " + accountID + "; Interest Rate " + interestRate + "%; Overdraft Limit $" + overdraft + "; Fee $" + fee + "; Balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
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
            if ((balance - withdrawal) < overdraft)
            {
                double transactionFee = fee;
                if (this.CustomerOnAccount.StaffDiscount == true)
                {
                    transactionFee = fee / 2;
                }
                balance -= transactionFee;
                transactionString = "Omni " + accountID + ";  withdrawal $" + withdrawal + ";  transaction failed; fee $" + transactionFee + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
                throw new FailedWithdrawalException(accountName + " account: Withdrawal failed due to insufficient funds");
            }
            else
            {
                balance -= withdrawal;
                transactionString = "Omni " + accountID + ";  withdrawal $" + withdrawal + ";   balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
            }
        }

        public override void Deposit(double deposit)
        {
            balance += deposit;
            transactionString = "Omni " + accountID + ";  deposit $" + deposit + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
        }

        public override void AddInterest()
        {
            double interest = (balance - 1000) * (interestRate / 100);
            Console.WriteLine(interest.ToString());
            balance += interest;
            transactionString = "Omni " + accountID + ";  add interest $" + interest + ";  balance $" + Math.Round(balance, 2, MidpointRounding.AwayFromZero);
        }

        public double InterestRate { get => interestRate; set => interestRate = value; }
        public double Overdraft { get => overdraft; set => overdraft = value; }
        public double Fee { get => fee; set => fee = value; }

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
