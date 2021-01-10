using System;

namespace Leandro.Estudos.Decorator.Notificadores
{
  public class SmsDecorator : NotificadorDecorator
  {
    public SmsDecorator(string numeroTelefone, Notificador notificador)
      : base(notificador)
    {
      NumeroTelefone = numeroTelefone;
    }

    public string NumeroTelefone { get; private set; }

    public override void Notificar(string mensagem)
    {
      Console.WriteLine($"Enviando notificacao por SMS.");
      Console.WriteLine($"\tDestinatario: {NumeroTelefone}");
      Console.WriteLine($"\t # Mensagem: {mensagem}");
      base.Notificar(mensagem);
    }
  }
}