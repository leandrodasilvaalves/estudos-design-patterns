namespace Leandro.Estudos.Decorator
{
  public abstract class PizzaDecorator : Pizza
  {
    private Pizza _pizza;
    public PizzaDecorator(Pizza pizza)
    {
      _pizza = pizza;
    }

    public override double CalcularCusto()
    {
      return _pizza.CalcularCusto();
    }

    public override string ObterDescricao()
    {
      return _pizza.ObterDescricao();
    }
  }
}  
