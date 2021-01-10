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
      var dev = new Desenvolvedor("Leandro", "leandro@email.com", "61999887766");
      dev.AssinarNotificacao(Notificacoes.SMS);
      dev.AssinarNotificacao(Notificacoes.WhastApp);

      Notificador notificador = new EmailNotificador(dev.Email);
      if(dev.PossuiAssinatura(Notificacoes.SMS))
        notificador = new SmsDecorator(dev.Telefone, notificador);
      
      if(dev.PossuiAssinatura(Notificacoes.WhastApp))
        notificador = new WhatsAppDecorator(dev.Telefone, dev.Nome, notificador);

      notificador.Notificar("O sistem parece estar passando por uma instabilidade. Verfique por favor!");
    }
  }
}