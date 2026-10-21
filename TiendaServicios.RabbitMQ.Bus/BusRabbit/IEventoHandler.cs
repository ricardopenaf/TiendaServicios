using System;
using System.Collections.Generic;
using System.Text;
using TiendaServicios.RabbitMQ.Bus.Eventos;

namespace TiendaServicios.RabbitMQ.Bus.BusRabbit
{
    public interface IEventoHandler<in TEvent> : IEventoHandler where TEvent : Evento
    {
        Task Handle(TEvent @event);
    }

    public interface IEventoHandler
    {
    }

}
