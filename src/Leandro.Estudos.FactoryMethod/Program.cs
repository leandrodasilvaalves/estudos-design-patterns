using System;
using System.Collections.Generic;
using Leandro.Estudos.FactoryMethod;

namespace Leandro.Estudos.Patterns.FactoryMethod
{
  class Program
  {
    static void Main(string[] args)
    {
        var gerenciadorFacotry = new GerenciadorFactory();
        var factory = gerenciadorFacotry[Leitor.Xml];
        var leitor = factory.CriarLeitor();
        leitor.Ler();

        factory = gerenciadorFacotry[Leitor.Json];
        leitor = factory.CriarLeitor();
        leitor.Ler();

        factory =gerenciadorFacotry[Leitor.Txt];
        leitor = factory.CriarLeitor();
        leitor.Ler();
    }
  }
}
