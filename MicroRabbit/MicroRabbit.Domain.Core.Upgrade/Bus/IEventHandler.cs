using MicroRabbit.Domain.Core.Upgrade.Events;

namespace MicroRabbit.Domain.Core.Upgrade.Bus
{
    public interface IEventHandler<in TEvent> : IEventHandler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }

    public interface IEventHandler
    {

    }
}
