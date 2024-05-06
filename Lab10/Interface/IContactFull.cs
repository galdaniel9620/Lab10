using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Interface
{
    internal interface IContactFull
    {
        void InsertCard();
        void MakePayment(double amount);
        void ExtractCard();
    }
}
