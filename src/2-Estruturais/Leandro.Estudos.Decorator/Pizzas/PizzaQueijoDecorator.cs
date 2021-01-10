namespace Leandro.Estudos.Decorator
{
  public class PizzaQueijoDecorator : PizzaDecorator
  {
    public PizzaQueijoDecorator(Pizza pizza) : base(pizza)
    {
      Descricao = "Queijo";
    }

    public override double CalcularCusto()
    {
      return base.CalcularCusto() + 1.25;
    }

    public override string ObterDescricao()
    {
      return $"{base.ObterDescricao()}, {Descricao}";
    }
  }
}  
