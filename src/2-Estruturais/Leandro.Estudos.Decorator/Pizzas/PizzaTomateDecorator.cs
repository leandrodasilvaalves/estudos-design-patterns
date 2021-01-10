namespace Leandro.Estudos.Decorator
{
  public class PizzaTomateDecorator : PizzaDecorator
  {
    public PizzaTomateDecorator(Pizza pizza) : base(pizza)
    {
      Descricao = "Tomate";
    }

    public override double CalcularCusto()
    {
      return base.CalcularCusto() + 0.25;
    }

    public override string ObterDescricao()
    {
      return $"{base.ObterDescricao()}, {Descricao}";
    }
  }
}  
