using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidVendingMachine
{
    public interface ICanGreet
    {
        void SayHello();
        void SayBye();
    }

    public interface ICanTellTime
    {
        void TellTime();
    }

    public interface IVendingMachine
    {
        void DisplayMenu();
        void Start();
    }

    public interface IFriendlyVendingMachine : ICanGreet, ICanTellTime, IVendingMachine { }
}
