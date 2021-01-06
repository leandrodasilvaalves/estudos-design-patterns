using System;
using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("----------------CRIACAO DE BOLETOS----------------");
      var factoryItau = GerenciadorFactory.ObterFactory(Banco.Itau);
      var joao = new Pagador("Joao da Silva"); 
      var debitoJoao = new Debito(joao, 100.0M);     
      var boletoItau = factoryItau.CriarBoleto(debitoJoao);
      Console.WriteLine($"{nameof(ItauBoleto)}:{boletoItau}");

      var factoryBradesco = GerenciadorFactory.ObterFactory(Banco.Bradesco);
      var jose = new Pagador("Jose  da Silva");
      var debitoJose = new Debito(jose, 85.75M);
      var boletoBradesco = factoryBradesco.CriarBoleto(debitoJose);      
      Console.WriteLine($"{nameof(BradescoBoleto)}:{boletoBradesco}");

      var debitos = new List<Debito>{
        debitoJoao,
        debitoJose,
        new Debito(new Pagador("Maria  da Silva"), 25.50M),
        new Debito(new Pagador("Pedro  da Silva"), 48.70M),
      };

      Console.WriteLine("-----------------CRIACAO DE CNABS-----------------");
      var cnabItau = factoryItau.CriarCnab(debitos);
      Console.WriteLine($"{nameof(ItauCnab)}:\n{cnabItau}");

      var cnabBradesco = factoryBradesco.CriarCnab(debitos);
      Console.WriteLine($"{nameof(BradescoCnab)}:\n{cnabBradesco}");
    }
  }
}
