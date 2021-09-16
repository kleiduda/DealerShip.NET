using DealerShip.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace DealerShip.Domain.Interfaces
{
    public interface INotificador
    {
        bool TemNotificacao();
        List<Notificacao> ObterNotificacoes();
        void Handle(Notificacao notificacao);
    }
}
