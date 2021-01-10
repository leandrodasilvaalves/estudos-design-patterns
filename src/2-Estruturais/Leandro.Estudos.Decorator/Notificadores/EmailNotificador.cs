using System;

namespace Leandro.Estudos.Decorator.Notificadores
{
  public class EmailNotificador : Notificador
  {
    public EmailNotificador(string email)
    {
      Email = email;
    }
    public string Email { get; private set; }

    public override void Notificar(string mensagem)
    {
      Console.WriteLine($"Enviando notificao para o email: {Email}");
      Console.WriteLine($"\t # Mensagem: {mensagem}");
    }
  }
}