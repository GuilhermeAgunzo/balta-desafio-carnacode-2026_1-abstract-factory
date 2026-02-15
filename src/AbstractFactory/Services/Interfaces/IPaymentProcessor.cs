namespace AbstractFactory.Services.Interfaces;

public interface IPaymentProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}
