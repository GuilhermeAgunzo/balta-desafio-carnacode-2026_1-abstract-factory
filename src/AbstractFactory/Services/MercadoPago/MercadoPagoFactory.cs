using AbstractFactory.Abstractions.Payment;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoFactory : IPaymentProviderFactory
{
    public IPaymentLogger CreatePaymentLogger() => new MercadoPagoLogger();
    public IPaymentProcessor CreatePaymentProcessor() => new MercadoPagoProcessor();
    public IPaymentValidator CreatePaymentValidator() => new MercadoPagoValidator();
}
