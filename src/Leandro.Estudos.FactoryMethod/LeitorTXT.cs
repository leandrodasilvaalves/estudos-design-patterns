namespace Leandro.Estudos.FactoryMethod
{
  public class LeitorTXT : LeitorBase
  {
    public override void Ler()
    {
      System.Console.WriteLine(new string('-',100));
      System.Console.WriteLine("Lendo um arquivo txt");
      System.Console.WriteLine(@"Eu sou um arquivo txt \n
        leando a linha 1 \n
        leando a linha 2 \n
        leando a linha 3
      ");
    }
  }
}