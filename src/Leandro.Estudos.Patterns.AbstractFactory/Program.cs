using System;
using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("----------------CRIACAO DE BOLETOS----------------");
      var factoryItau = ObterFactory(Banco.Itau);
      var fulano = new Pagador("Fulano da Silva"); 
      var debitoFulano = new Debito(fulano, 100.0M);     
      var boletoItau = factoryItau.CriarBoleto(debitoFulano);
      Console.WriteLine($"{nameof(ItauBoleto)}:{boletoItau}");

      var factoryBradesco = ObterFactory(Banco.Bradesco);
      var cicrano = new Pagador("Cicrano  da Silva");
      var debitoCicrano = new Debito(cicrano, 85.75M);
      var boletoBradesco = factoryBradesco.CriarBoleto(debitoCicrano);      
      Console.WriteLine($"{nameof(BradescoBoleto)}:{boletoBradesco}");

      var debitos = new List<Debito>{
        debitoFulano,
        debitoCicrano,
        new Debito(new Pagador("Beltrano  da Silva"), 25.50M),
        new Debito(new Pagador("Criatura  da Silva"), 48.70M),
      };

      Console.WriteLine("-----------------CRIACAO DE CNABS-----------------");
      var cnabItau = factoryItau.CriarCnab(debitos);
      Console.WriteLine($"{nameof(ItauCnab)}:\n{cnabItau}");

      var cnabBradesco = factoryBradesco.CriarCnab(debitos);
      Console.WriteLine($"{nameof(BradescoCnab)}:\n{cnabBradesco}");
    }

    private static BancoAbstractFactory ObterFactory(Banco banco)
    {
      var factories = new Dictionary<Banco, BancoAbstractFactory>
      {
          {Banco.Itau, new ItauFactory()},
          {Banco.Bradesco, new BradescoFactory()},
      };
      return factories[banco];
    }
  }

  enum Banco
  {
    Itau,
    Bradesco,
  }
}
