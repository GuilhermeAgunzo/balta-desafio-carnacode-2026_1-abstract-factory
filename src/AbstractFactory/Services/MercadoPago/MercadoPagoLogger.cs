using AbstractFactory.Abstractions.Payment;

namespace AbstractFactory.Services.MercadoPago;

public class MercadoPagoLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}
