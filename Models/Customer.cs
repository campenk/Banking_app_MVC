using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    [Serializable]
    public class Customer
    {
        private static int nextID = 1;
        private int customerID;
        private string firstName;
        private string lastName;
        private string contactNo;
        private bool staffDiscount;
        private List<Account> customerAccounts = new List<Account>();
       
        // class constructor
        public Customer()
        {
            customerID = CustomerSingleton.NextId;
        }

        //  parametized class constructor with input validation
        public Customer(string newFirstName, string newLastName, string newContactNo, bool newStaffDiscount)
        {
            string errorMessage = "These fields contain invalid characters:"; 
            if (isDigitPresent(newFirstName) || isDigitPresent(newLastName) || isLetterPresent(newContactNo))
            {
                if (isDigitPresent(newFirstName))
                {
                    errorMessage += Environment.NewLine + "First Name";
                }
                if (isDigitPresent(newLastName))
                {
                    errorMessage += Environment.NewLine + "Last Name";
                }
                if (isLetterPresent(newContactNo))
                {
                    errorMessage += Environment.NewLine + "Phone Number";
                }
                throw new InvalidInputException(errorMessage);
            }

            customerID = CustomerSingleton.NextId;

            firstName = newFirstName;            
            lastName = newLastName;            
            contactNo = newContactNo; 
            staffDiscount = newStaffDiscount;
        }

        // getter and setter for FirstName with input validation
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (isDigitPresent(value))
                {                    
                    throw new InvalidInputException("Invalid characters: First Name");
                }
                else
                {
                    firstName = value;
                }
            }
        }

        // getter and setter for LastName with input validation
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (isDigitPresent(value))
                {                    
                    throw new InvalidInputException("Invalid characters: Last Name");
                }
                else
                {
                    lastName = value;
                }
            }
        }

        //  getter and setter for ContactNo with input validation
        public string ContactNo
        {
            get
            {
                return contactNo;
            }
            set
            {
                if (isLetterPresent(value))
                {                   
                    throw new InvalidInputException("Invalid characters: Phone Number");
                }
                else
                {
                    contactNo = value;
                }
            }
        }

        public bool StaffDiscount { get => staffDiscount; set => staffDiscount = value; }

        public int CustomerID { get => customerID; }
        public List<Account> CustomerAccounts { get => customerAccounts; }

        public void addtoCustomerAccounts (Account account)
        {
            customerAccounts.Add(account);
        }


        public string FullName { get => firstName + " " + lastName; }

        //  returns true if string contains a numeric character
        private bool isDigitPresent(string input) {
           return input.Any(c => char.IsDigit(c));
        }

        //  returns true if string contains an alphabet character
        public bool isLetterPresent (string input)
        {
            return !input.All(c => char.IsDigit(c));
        }      

        public override string ToString()
        {
            return FullName;
        }
    }
}
