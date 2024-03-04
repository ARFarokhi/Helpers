namespace WebApi.Services.PaymentService
{
    public enum Payment
    {
        MasterCard,
        Paypal,
        Crypto
    }

    //// Uses the key "Paypal" to select the PaypalPaymentService specifically
    //public class PaypalWrapper([FromKeyedServices(Payment.Paypal)] IPaymentService paypal)
    //{
    //    public string Payment(decimal amount, string currency) => paypal.Payment(amount, currency);
    //}

    //// Uses the key "Crypto" to select the CryptoPaymentService specifically
    //public class CryptoWrapper([FromKeyedServices(Payment.Crypto)] IPaymentService crypto)
    //{
    //    public string Payment(decimal amount, string currency) => crypto.Payment(amount, currency);
    //}

    //// Uses the key "MasterCard" to select the MasterCardPaymentService specifically
    //public class MasterCardWrapper([FromKeyedServices(Payment.MasterCard)] IPaymentService masterCard)
    //{
    //    public string Payment(decimal amount, string currency) => masterCard.Payment(amount, currency);
    //}


    ////  Add the keyed services attribute with the key 
    //public class PaymentService([FromKeyedServices(Payment.MasterCard)] IPaymentService paymentService)
    //{
    //    // paymentService is EmailNotificationService
    //}
}
