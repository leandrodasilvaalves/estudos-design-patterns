using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class ItauCnab : Cnab
  {
    public override void GerarArquivo(List<Debito> debitos)
    {
      debitos.ForEach(debito => 
        Boletos.Add(new ItauBoleto(debito.Pagador, debito.Valor)));
    }
  }
}