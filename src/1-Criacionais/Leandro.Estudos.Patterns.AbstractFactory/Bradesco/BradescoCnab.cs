using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class BradescoCnab : Cnab
  {
    public override void GerarArquivo(List<Debito> debitos)
    {
      debitos.ForEach(debito => 
        Boletos.Add(new BradescoBoleto(debito.Pagador, debito.Valor)));
    }
  }
}