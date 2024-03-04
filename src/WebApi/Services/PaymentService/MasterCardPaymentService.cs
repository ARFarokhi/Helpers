namespace WebApi.Services.PaymentService;

public class MasterCardPaymentService : IPaymentService
{
    public string Payment(decimal amount, string currency) =>
        $"MasterCard Payment with Amount:{amount}{currency}";
}