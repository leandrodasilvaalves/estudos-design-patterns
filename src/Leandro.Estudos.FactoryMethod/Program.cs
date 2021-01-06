using System;
using System.Collections.Generic;
using Leandro.Estudos.FactoryMethod;

namespace Leandro.Estudos.Patterns.FactoryMethod
{
  class Program
  {
    static void Main(string[] args)
    {
        var factory = ObterFactory(Leitor.Xml);
        var leitor = factory.CriarLeitor();
        leitor.Ler();

        factory = ObterFactory(Leitor.Json);
        leitor = factory.CriarLeitor();
        leitor.Ler();

        factory = ObterFactory(Leitor.Txt);
        leitor = factory.CriarLeitor();
        leitor.Ler();
    }

    static LeitorFactory ObterFactory(Leitor leitor)
    {
      var factories = new Dictionary<Leitor, LeitorFactory>
      {
          {Leitor.Json, new LeitorJsonFactory()},
          {Leitor.Xml, new LeitorXMLFactory()},
          {Leitor.Txt, new LeitorTxtFactory()},
      };
      return factories[leitor];
    }
  }
}
