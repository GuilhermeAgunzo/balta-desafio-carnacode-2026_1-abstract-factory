namespace AbstractFactory.Services.Interfaces;

public interface IPaymentProviderFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentValidator CreatePaymentValidator();
    IPaymentLogger CreatePaymentLogger();
}
