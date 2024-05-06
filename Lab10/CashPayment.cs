namespace Lab10
{
    internal class CashPayment
    {

        public void ProcessCashPayment(double amount)
        {
            Console.WriteLine($"Opening cash register.");
            Console.WriteLine($"Inserting: {amount} into cash register.");
            Console.WriteLine($"Closing cash register.");
            Console.WriteLine($"Printing receipt.");
        }
    }
}
