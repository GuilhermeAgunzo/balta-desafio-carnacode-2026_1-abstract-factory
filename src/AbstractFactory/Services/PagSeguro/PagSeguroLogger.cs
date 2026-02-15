using AbstractFactory.Abstractions.Payment;

namespace AbstractFactory.Services.PagSeguro;

public class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}
