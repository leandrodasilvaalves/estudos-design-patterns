namespace Leandro.Estudos.Decorator.Notificadores
{
  public abstract class Notificador : INotificador
  {
    public abstract void Notificar(string mensagem);
  }
}