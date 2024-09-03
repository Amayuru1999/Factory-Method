
using System;

namespace Factory_Method.Implementations
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Successfully paid {amount} with credit card.");
        }
    }
}