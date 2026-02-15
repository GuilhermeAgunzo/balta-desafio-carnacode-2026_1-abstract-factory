using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.PagSeguro;

public class PagSeguroFactory : IPaymentProviderFactory
{
    public IPaymentLogger CreatePaymentLogger() => new PagSeguroLogger();
    public IPaymentProcessor CreatePaymentProcessor() => new PagSeguroProcessor();
    public IPaymentValidator CreatePaymentValidator() => new PagSeguroValidator();

}
