namespace Leandro.Estudos.FactoryMethod
{
  public class LeitorJsonFactory : LeitorFactory
  {
    public override LeitorBase CriarLeitor()
    {
      return new LeitorJSON();
    }
  }
}