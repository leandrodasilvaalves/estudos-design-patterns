namespace Leandro.Estudos.Decorator
{
  public class PizzaGrande : Pizza
  {
    public PizzaGrande()
    {
      Descricao = "Pizza Grande";
    }
    public override double CalcularCusto()
    {
      return 45.00;
    }

    public override string ObterDescricao()
    {
      return Descricao;
    }
  }
}  
