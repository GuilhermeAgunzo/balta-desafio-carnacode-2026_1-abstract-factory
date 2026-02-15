using AbstractFactory.Abstractions.Payment;

namespace AbstractFactory.Services.Stripe;

public class StripeLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}
