using System;
using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  class Program
  {
    private readonly static GerenciadorFactory gerenciadorFactory = new GerenciadorFactory();
    static void Main(string[] args)
    {
        ExemploBoletoItau();
        ExemploBoletoBradesco();
        ExemploCnabs();
    }

    static void ExemploBoletoItau()
    {
      Console.WriteLine("----------------CRIACAO DE BOLETOS----------------");
      var factoryItau = gerenciadorFactory[Banco.Itau];
      var joao = new Pagador("Joao da Silva");
      var debitoJoao = new Debito(joao, 100.0M);
      var boletoItau = factoryItau.CriarBoleto(debitoJoao);
      Console.WriteLine($"{nameof(ItauBoleto)}:{boletoItau}");
    }

    static void ExemploBoletoBradesco()
    {
      var factoryBradesco = gerenciadorFactory[Banco.Bradesco];
      var jose = new Pagador("Jose da Silva");
      var debitoJose = new Debito(jose, 85.75M);
      var boletoBradesco = factoryBradesco.CriarBoleto(debitoJose);
      Console.WriteLine($"{nameof(BradescoBoleto)}:{boletoBradesco}");
    }

    static void ExemploCnabs()
    {
      var debitos = new List<Debito>{
        new Debito(new Pagador("Joao da Silva"),100M),
        new Debito(new Pagador("Jose da Silva"),85.75M),
        new Debito(new Pagador("Maria da Silva"), 25.50M),
        new Debito(new Pagador("Pedro da Silva"), 48.70M),
      };

      Console.WriteLine("-----------------CRIACAO DE CNABS-----------------");
      var factoryItau = gerenciadorFactory[Banco.Itau];      
      var cnabItau = factoryItau.CriarCnab(debitos);
      Console.WriteLine($"{nameof(ItauCnab)}:\n{cnabItau}");

      var factoryBradesco = gerenciadorFactory[Banco.Bradesco];
      var cnabBradesco = factoryBradesco.CriarCnab(debitos);
      Console.WriteLine($"{nameof(BradescoCnab)}:\n{cnabBradesco}");
    }
  }
}
