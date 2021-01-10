using System;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class BradescoBoleto : Boleto
  {
    public BradescoBoleto(Pagador pagador, decimal valor) 
      : base(pagador, "Bradesco", valor) { }

    public override void GerarCodigoBarras()
    {
      var codigoBarras = string.Empty;
      var random = new Random(DateTime.Now.Millisecond);
      for (var i = 0; i < 7; i++)
        codigoBarras += $"{random.Next(),8:N0} ";

      CodigoBarras = codigoBarras.Trim().Replace(".", "");
    }
  }
}