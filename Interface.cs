using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706_A2_Campen_5047211
{
    public interface IObserver
    {
        void Update(Customer c);
    }

    public interface ISubject
    {
        void AttachObserver(IObserver obs);
        void NotifyObservers(Customer c);
    }
}