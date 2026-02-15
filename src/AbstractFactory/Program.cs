using AbstractFactory.Services;
using AbstractFactory.Services.MercadoPago;
using AbstractFactory.Services.PagSeguro;

Console.WriteLine("=== Sistema de Pagamentos ===\n");

var pagSeguroService = new PaymentService(new PagSeguroFactory());
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoService = new PaymentService(new MercadoPagoFactory());
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();

// Pergunta para reflexão:
// - Como adicionar um novo gateway sem modificar PaymentService?
// - Como garantir que todos os componentes de um gateway sejam compatíveis entre si?
// - Como evitar criar componentes de gateways diferentes acidentalmente?