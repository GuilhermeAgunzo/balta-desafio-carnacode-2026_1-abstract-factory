namespace AbstractFactory.Services.Interfaces;

public interface IPaymentService
{
    void ProcessPayment(decimal amount, string cardNumber);
}
