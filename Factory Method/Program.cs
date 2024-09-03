using Factory_Method.Enums;
using Factory_Method.Implementations;
using System;


namespace Factory_Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PaymentFactory factory = new PaymentFactory();
            IPayment payment = factory.Create(PaymentMethod.GooglePay);
            payment.Pay(1000.00);
        }
    }
}