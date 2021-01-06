using System.Collections.Generic;

namespace Leandro.Estudos.FactoryMethod
{
  public class GerenciadorFactory : Dictionary<Leitor, LeitorFactory>
  {
    public GerenciadorFactory()
    {
      Add(Leitor.Json, new LeitorJsonFactory());
      Add(Leitor.Txt, new LeitorTxtFactory());
      Add(Leitor.Xml, new LeitorXMLFactory());
    }
  }
}