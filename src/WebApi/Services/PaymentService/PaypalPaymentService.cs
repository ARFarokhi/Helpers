namespace WebApi.Services.PaymentService;

public class PaypalPaymentService : IPaymentService
{
    public string Payment(decimal amount, string currency) =>
        $"Paypal Payment with Amount:{amount}{currency}";
}