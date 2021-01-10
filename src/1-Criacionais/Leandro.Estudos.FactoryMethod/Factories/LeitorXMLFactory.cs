namespace Leandro.Estudos.FactoryMethod
{
  public class LeitorXMLFactory : LeitorFactory
  {
    public override LeitorBase CriarLeitor()
    {
      return new LeitorXML();
    }
  }
}