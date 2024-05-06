using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    internal class CashRegister
    {
        private POS pos = new POS();
        private CashPayment cashPayment = new CashPayment();

        public void ProcessCashPayment(double amount)
        {
            cashPayment.ProcessCashPayment(amount);
        }

        public POS GetPOS()
        {
            return pos;
        }

    }
}
