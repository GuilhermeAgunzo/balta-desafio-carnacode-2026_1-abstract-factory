namespace AbstractFactory.Services.Interfaces;

public interface IPaymentValidator
{
    bool ValidateCard(string cardNumber);
}
