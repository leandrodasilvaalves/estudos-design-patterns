namespace Leandro.Estudos.Decorator.Notificadores
{
  public class NotificadorDecorator : Notificador
  {
    private readonly Notificador _notificador;
    public NotificadorDecorator(Notificador notificador)
    {
      _notificador = notificador;
    }

    public override void Notificar(string mensagem)
    {
      _notificador.Notificar(mensagem);
    }
  }
}