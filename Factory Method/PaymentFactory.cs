using System;
using Factory_Method.Enums;
using Factory_Method.Implementations;

namespace Factory_Method
{
    public class PaymentFactory
    {
        public static IPayment Create(PaymentMethod paymentMethod)
        {
            switch (paymentMethod)
            {
                case PaymentMethod.CreditCard:
                    return new CreditCardPayment();
                
                case PaymentMethod.PayPal:
                    return new PayPalPayment();
                
                case PaymentMethod.GooglePay:
                    return new GooglePayPayment();
                
                default:
                    throw new NotSupportedException(
                        $"{paymentMethod} is not supported by the system."
                        );
                
            }
            
        }
    }
}