namespace AbstractFactory.Abstractions.Payment;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}
