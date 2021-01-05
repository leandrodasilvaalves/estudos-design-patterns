using Newtonsoft.Json;

namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public abstract class Boleto
  {
    protected Boleto(Pagador pagador, string banco, decimal valor)
    {
      Pagador = pagador;
      Banco = banco;
      GerarCodigoBarras();
      Valor = valor;
    }

    public decimal Valor { get; set; }
    public string Banco { get; private set; }
    public Pagador Pagador { get; private set; }
    public string CodigoBarras { get; protected set; }
    public abstract void GerarCodigoBarras();

    public override string ToString()
    {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
  }
}