namespace AbstractFactory.Abstractions.Payment;

public interface IPaymentService
{
    void ProcessPayment(decimal amount, string cardNumber);
}
