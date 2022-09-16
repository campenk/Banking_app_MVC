using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{ 
        public class InvalidInputException : Exception
        {
            public InvalidInputException()
            {
            }

            public InvalidInputException(string message) : base(message)
            {
            }
        }
}

