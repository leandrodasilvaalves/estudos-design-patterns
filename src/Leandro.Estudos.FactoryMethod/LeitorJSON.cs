namespace Leandro.Estudos.FactoryMethod
{
  public class LeitorJSON : LeitorBase
  {
    public override void Ler()
    {
      System.Console.WriteLine(new string('-',100));
      System.Console.WriteLine("Lendo um arquivo JSON");
      System.Console.WriteLine(@"
        json:{
          item: 'eu sou um item json'
        }
      ");
    }
  }
}