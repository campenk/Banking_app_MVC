using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    public class FailedWithdrawalException : Exception
    {
        public FailedWithdrawalException()
        {
        }

        public FailedWithdrawalException(string message) : base(message)
        {
        }
    }
}
