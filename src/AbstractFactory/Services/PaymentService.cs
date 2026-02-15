using AbstractFactory.Abstractions.Payment;

namespace AbstractFactory.Services;

public class PaymentService : IPaymentService
{
    private readonly IPaymentProviderFactory _paymentProviderFactory;

    private readonly IPaymentValidator _paymentValidator;
    private readonly IPaymentProcessor _paymentProcessor;
    private readonly IPaymentLogger _paymentLogger;

    public PaymentService(IPaymentProviderFactory paymentProviderFactory)
    {
        _paymentProviderFactory = paymentProviderFactory;

        _paymentValidator = _paymentProviderFactory.CreatePaymentValidator();
        _paymentProcessor = _paymentProviderFactory.CreatePaymentProcessor();
        _paymentLogger = _paymentProviderFactory.CreatePaymentLogger();
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if (!_paymentValidator.ValidateCard(cardNumber))
        {
            Console.WriteLine("Cartão inválido");
            return;
        }

        var paymentResult = _paymentProcessor.ProcessTransaction(amount, cardNumber);
        _paymentLogger.Log($"Transação processada: {paymentResult}");

    }
}
