using System.Collections.Generic;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public abstract class Cnab
  {
    protected Cnab()
    {
        Boletos = new List<Boleto>();
    }
    public List<Boleto> Boletos { get; protected set; }
    public abstract void GerarArquivo(List<Debito> debitos);

    public override string ToString()
    {
      var consolidado = "";
      Boletos.ForEach(x =>{
        consolidado += $"{x.Banco} {x.Pagador.Nome} {x.CodigoBarras} {x.Vencimento.ToString("ddMMyyyy")} {x.Valor.ToString().Replace(",","")}\n";
      });
      return consolidado;
    }
  }
}