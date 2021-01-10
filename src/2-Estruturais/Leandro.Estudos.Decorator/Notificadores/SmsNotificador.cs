using System;

namespace Leandro.Estudos.Decorator.Notificadores
{
  public class SmsNotificador : Notificador
  {
    public long NumeroTelefone { get; private set; }
    public SmsNotificador(long numeroTelefone)
    {
      NumeroTelefone = numeroTelefone;
    }

    public override void Notificar(string mensagem)
    {
      Console.WriteLine($"Enviando notificacao por SM.");
      Console.WriteLine($"\tDestinatario: {NumeroTelefone}");
      Console.WriteLine($"\t # Mensagem: {mensagem}");
    }
  }
}