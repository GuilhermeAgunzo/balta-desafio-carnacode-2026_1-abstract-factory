namespace AbstractFactory.Abstractions.Payment;

public interface IPaymentProviderFactory
{
    IPaymentProcessor CreatePaymentProcessor();
    IPaymentValidator CreatePaymentValidator();
    IPaymentLogger CreatePaymentLogger();
}
