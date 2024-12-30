using MicroRabbit.Domain.Core.Upgrade.Commands;
using MicroRabbit.Domain.Core.Upgrade.Events;

namespace MicroRabbit.Domain.Core.Upgrade.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        Task Publish<T>(T @event) where T : Event;

        Task Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
