namespace AbstractFactory.Abstractions.Payment;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
