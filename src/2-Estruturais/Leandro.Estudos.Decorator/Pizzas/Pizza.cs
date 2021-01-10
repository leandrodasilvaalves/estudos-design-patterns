namespace Leandro.Estudos.Decorator
{
  public abstract class Pizza
  {
    public string Descricao { get; protected set; }
    public abstract string ObterDescricao();
    public abstract double CalcularCusto();
  }
}  
