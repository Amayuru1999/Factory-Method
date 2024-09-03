using System;

namespace Factory_Method.Implementations
{
    public class PayPalPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Successfully paid {amount} with PayPal.");
        }
    }
}