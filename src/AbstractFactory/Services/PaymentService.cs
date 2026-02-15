using AbstractFactory.Services.Interfaces;
using DesignPatternChallenge;

namespace AbstractFactory.Services;

public class PaymentService : IPaymentService
{
    private readonly string _gateway;

    public PaymentService(string gateway)
    {
        _gateway = gateway;
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        // Problema: Switch case gigante para cada gateway
        // Quando adicionar novo gateway, precisa modificar este método
        switch (_gateway.ToLower())
        {
            case "pagseguro":
                var pagSeguroValidator = new PagSeguroValidator();
                if (!pagSeguroValidator.ValidateCard(cardNumber))
                {
                    Console.WriteLine("PagSeguro: Cartão inválido");
                    return;
                }

                var pagSeguroProcessor = new PagSeguroProcessor();
                var pagSeguroResult = pagSeguroProcessor.ProcessTransaction(amount, cardNumber);

                var pagSeguroLogger = new PagSeguroLogger();
                pagSeguroLogger.Log($"Transação processada: {pagSeguroResult}");
                break;

            case "mercadopago":
                var mercadoPagoValidator = new MercadoPagoValidator();
                if (!mercadoPagoValidator.ValidateCard(cardNumber))
                {
                    Console.WriteLine("MercadoPago: Cartão inválido");
                    return;
                }

                var mercadoPagoProcessor = new MercadoPagoProcessor();
                var mercadoPagoResult = mercadoPagoProcessor.ProcessTransaction(amount, cardNumber);

                var mercadoPagoLogger = new MercadoPagoLogger();
                mercadoPagoLogger.Log($"Transação processada: {mercadoPagoResult}");
                break;

            case "stripe":
                var stripeValidator = new StripeValidator();
                if (!stripeValidator.ValidateCard(cardNumber))
                {
                    Console.WriteLine("Stripe: Cartão inválido");
                    return;
                }

                var stripeProcessor = new StripeProcessor();
                var stripeResult = stripeProcessor.ProcessTransaction(amount, cardNumber);

                var stripeLogger = new StripeLogger();
                stripeLogger.Log($"Transação processada: {stripeResult}");
                break;

            default:
                throw new ArgumentException("Gateway não suportado");
        }
    }
}
