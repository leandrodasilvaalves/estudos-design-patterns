namespace Leandro.Estudos.Patterns.AbstractFactory
{
  public class Pagador
  {
      public string Nome { get; private set; }

    public Pagador(string nome)
    {
      Nome = nome;
    }
  }
}