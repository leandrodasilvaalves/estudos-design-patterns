using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class BradescoFactory : BancoAbstractFactory
  {
    public override Boleto CriarBoleto(Debito debito)
    {
      return new BradescoBoleto(debito.Pagador, debito.Valor);
    }

    public override Cnab CriarCnab(List<Debito> debitos)
    {
      var cnab = new BradescoCnab();
      cnab.GerarArquivo(debitos);
      return cnab;
    }
  }
}