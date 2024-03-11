using System;

namespace exercise16
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            balance = openingBalance;
        }

        public override string ToString()
        {
            return $"The card has a balance of {balance} euros";
        }
    }

    class Program
    {
        static void Main()
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);
        }
    }
}
