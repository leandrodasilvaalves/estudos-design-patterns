using System;

namespace Leandro.Estudos.Decorator.Notificadores
{
  public class WhatsAppDecorator : NotificadorDecorator
  {
    public WhatsAppDecorator(long numeroWhatsApp,
                               string nomeContato,
                               Notificador notificador) : base(notificador)
    {
      NumeroWhatsApp = numeroWhatsApp;
      NomeContato = nomeContato;
    }

    public long NumeroWhatsApp { get; private set; }
    public string NomeContato { get; private set; }

    public override void Notificar(string mensagem)
    {
      Console.WriteLine($"Enviando notificacao por WhatsApp.");
      Console.WriteLine($"\tNome: {NomeContato} | Numero: {NumeroWhatsApp}");
      Console.WriteLine($"\t # Mensagem: {mensagem}");
      base.Notificar(mensagem);
    }
  }
}