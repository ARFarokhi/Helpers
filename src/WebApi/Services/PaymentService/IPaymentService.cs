namespace WebApi.Services.PaymentService;

public interface IPaymentService
{
    string Payment(decimal amount, string currency);
}