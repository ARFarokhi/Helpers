namespace WebApi.Services.PaymentService;

public class CryptoPaymentService : IPaymentService
{
    public string Payment(decimal amount, string currency) =>
        $"Crypto Payment with Amount:{amount}{currency}";
}