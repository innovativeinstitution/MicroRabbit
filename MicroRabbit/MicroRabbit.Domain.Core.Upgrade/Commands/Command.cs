using MicroRabbit.Domain.Core.Upgrade.Events;

namespace MicroRabbit.Domain.Core.Upgrade.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
