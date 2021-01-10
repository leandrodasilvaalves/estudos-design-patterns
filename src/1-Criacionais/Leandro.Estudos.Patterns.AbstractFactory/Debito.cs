namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class Debito
  {
    public Debito(Pagador pagador, decimal valor)
    {
      Pagador = pagador;
      Valor = valor;
    }

    public Pagador Pagador { get; private set; }
    public decimal Valor { get; private set; }
  }
}