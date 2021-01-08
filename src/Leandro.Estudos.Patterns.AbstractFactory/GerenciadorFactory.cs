using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class GerenciadorFactory : Dictionary<Banco, BancoAbstractFactory>
  {
    public GerenciadorFactory()
    {
      Add(Banco.Itau, new ItauFactory());
      Add(Banco.Bradesco, new BradescoFactory());
    }
  }
}