using System.Collections.Generic;
using System.Linq;

namespace Leandro.Estudos.Decorator.Notificadores
{
  public class Desenvolvedor
  {
    public Desenvolvedor(string nome, string email, string telefone)
    {
      MeiosNotificacoes = new List<Notificacoes> { Notificacoes.Email };
      Nome = nome;
      Email = email;
      Telefone = telefone;
    }

    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string Telefone { get; private set; }

    public List<Notificacoes> MeiosNotificacoes { get; private set; }

    public void AssinarNotificacao(Notificacoes notificacao)
    {
      if (!PossuiAssinatura(notificacao))
        MeiosNotificacoes.Add(notificacao);
    }

    public bool PossuiAssinatura(Notificacoes notificacao)
        => MeiosNotificacoes.Any(x => x == notificacao);
  }

  public enum Notificacoes
  {
    Email,
    SMS,
    WhastApp
  }
}