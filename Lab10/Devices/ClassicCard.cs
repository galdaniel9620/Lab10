using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab10.Interface;

namespace Lab10.Devices
{
    internal class ClassicCard : IContactFull
    {
        public void InsertCard()
        {
            Console.WriteLine("Insert card");
        }

        public void MakePayment(double amount)
        {
            Console.WriteLine($"Make Payment: {amount}");
        }

        public void ExtractCard()
        {
            Console.WriteLine("Extract Card");
        }
    }
}
