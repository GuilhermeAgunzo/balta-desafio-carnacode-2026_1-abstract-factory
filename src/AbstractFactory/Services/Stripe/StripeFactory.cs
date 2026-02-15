using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Stripe;

public class StripeFactory : IPaymentProviderFactory
{
    public IPaymentLogger CreatePaymentLogger() => new StripeLogger();
    public IPaymentProcessor CreatePaymentProcessor() => new StripeProcessor();
    public IPaymentValidator CreatePaymentValidator() => new StripeValidator();
}
