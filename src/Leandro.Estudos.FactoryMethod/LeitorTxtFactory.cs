namespace Leandro.Estudos.FactoryMethod
{
  public class LeitorTxtFactory : LeitorFactory
  {
    public override LeitorBase CriarLeitor()
    {
      return new LeitorTXT();
    }
  }
}