using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10.Interface;

namespace Lab10.Devices
{
    internal class ContactlessCard: ClassicCard, IContactless
    {
        public void TapCard()
        {
            Console.WriteLine("Tap Card");
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine($"Make payment: {amount}");
        }
    }
}
