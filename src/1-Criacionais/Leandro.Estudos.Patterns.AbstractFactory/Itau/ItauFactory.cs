using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class ItauFactory : BancoAbstractFactory
  {
    public override Boleto CriarBoleto(Debito debito)
    {
      return new ItauBoleto(debito.Pagador, debito.Valor);
    }

    public override Cnab CriarCnab(List<Debito> pagadores)
    {
      var cnab = new ItauCnab();
      cnab.GerarArquivo(pagadores);
      return cnab;
    }
  }
}