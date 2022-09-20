using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    public interface ICustomerObserver
    {
        void UpdateCustomer(Customer c);
    }

    public interface ICustomerSubject
    {
        void AttachObserver(ICustomerObserver obs);
        void NotifyCustomerObservers(Customer c);
    }

    public interface IAccountObserver
    {
        void UpdateAccount(Account acc);
    }

    public interface IAccountSubject
    {
        void AttachObserver(ICustomerObserver obs);

        void NotifyAccountObservers(Account a);
    }



}