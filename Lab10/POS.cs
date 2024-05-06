using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10.Devices;
using Lab10.Interface;

namespace Lab10
{
    internal class POS
    {
        public void AcceptContactFullPayment(IContactFull paymenthMethod, double amount)
        {
            paymenthMethod.InsertCard();
            paymenthMethod.MakePayment(amount);
            paymenthMethod.ExtractCard();
        }

        public void AcceptContactlessPayment(IContactless paymenthMethod, double amount)
        {
            paymenthMethod.TapCard();
            paymenthMethod.MakePayment(amount);
        }
    }
}
