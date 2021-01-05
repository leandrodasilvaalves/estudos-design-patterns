using System;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class ItauBoleto : Boleto
  {
    public ItauBoleto(Pagador pagador, decimal valor) 
      : base(pagador, "Itau", valor) { }
    public override void GerarCodigoBarras()
    {
      CodigoBarras = Guid.NewGuid() + "-" + Guid.NewGuid();
    }
  }
}