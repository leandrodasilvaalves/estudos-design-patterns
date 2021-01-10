using System;

namespace Leandro.Estudos.Decorator
{
  class Program
  {
    static void Main(string[] args)
    {
      ExemploPizza();
    }

    static void ExemploPizza()
    {
      var pizza = new PizzaGrande();
      var queijo = new PizzaQueijoDecorator(pizza);
      var tomate = new PizzaTomateDecorator(queijo);
      Console.WriteLine("Pizza: {0} -\t Total: {1}", tomate.ObterDescricao(), tomate.CalcularCusto().ToString("C2"));
    }
  }
}