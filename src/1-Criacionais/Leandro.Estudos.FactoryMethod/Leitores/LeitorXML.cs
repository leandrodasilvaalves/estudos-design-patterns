namespace Leandro.Estudos.FactoryMethod
{
  public class LeitorXML : LeitorBase
  {
    public override void Ler()
    {
      System.Console.WriteLine(new string('-',100));
      System.Console.WriteLine("Lendo arquivo XML");
      System.Console.WriteLine(@"
        <teste>
          <itemTeste>Eu sou um item xml</itemTeste>
        </teste>
      ");
    }
  }
}