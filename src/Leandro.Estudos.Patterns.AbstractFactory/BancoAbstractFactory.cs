using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public abstract class BancoAbstractFactory
  {
    public abstract Boleto CriarBoleto(Debito debito);
    public abstract Cnab CriarCnab(List<Debito> debitos);
  }

  public class GerenciadorFactory
  {
    public static BancoAbstractFactory ObterFactory(Banco banco)
    {
      var factories = new Dictionary<Banco, BancoAbstractFactory>
      {
          {Banco.Itau, new ItauFactory()},
          {Banco.Bradesco, new BradescoFactory()},
      };
      return factories[banco];
    }
  }
}