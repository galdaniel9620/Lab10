using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Interface
{
    internal interface IContactless
    {
        void TapCard();
        void MakePayment(double amount);
    }
}
