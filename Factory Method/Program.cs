using Factory_Method.Enums;
using Factory_Method.Implementations;
using System;


namespace Factory_Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IPayment payment = new PaymentFactory().Create(PaymentMethod.CreditCard);
            payment.Pay(1000.00);
        }
    }
}