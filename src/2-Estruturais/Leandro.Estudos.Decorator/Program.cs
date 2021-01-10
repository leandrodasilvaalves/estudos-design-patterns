using System;
using Leandro.Estudos.Decorator.Notificadores;

namespace Leandro.Estudos.Decorator
{
  class Program
  {
    static void ImprimirLinha()
    {
      Console.WriteLine($"\n{new string('-', 120)}");
    }
    static void Main(string[] args)
    {
      ImprimirLinha();
      ExemploPizza();

      ImprimirLinha();
      ExemploNotificador();
    }

    static void ExemploPizza()
    {
      Console.WriteLine("Exemplo Pizza");
      var pizza = new PizzaGrande();
      var queijo = new PizzaQueijoDecorator(pizza);
      var tomate = new PizzaTomateDecorator(queijo);
      Console.WriteLine("Pizza: {0} -\t Total: {1}", tomate.ObterDescricao(), tomate.CalcularCusto().ToString("C2"));
    }

    static void ExemploNotificador()
    {
      Console.WriteLine("Exemplo Notificador");
      var notificador = new EmailNotificador("email@teste.com");
      var smsNotificador = new SmsDecorator(619998877, notificador);
      var whatsappNotificador = new WhatsAppDecorator(619998877, "Leandro", smsNotificador);
      whatsappNotificador.Notificar("O sistem parece estar passando por uma instabilidade. Verfique por favor!");
    }
  }
}