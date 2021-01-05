using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public abstract class BancoAbstractFactory
  {
    public abstract Boleto CriarBoleto(Debito debito);
    public abstract Cnab CriarCnab(List<Debito> debitos);
  }
}