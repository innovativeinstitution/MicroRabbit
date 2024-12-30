using MicroRabbit.Domain.Core.Upgrade.Commands;

namespace MicroRabbit.Banking.Domain.Upgrade.Commands
{
    public abstract class TransferCommand : Command
    {
        public int From { get; protected set; }
        public int To { get; protected set; }
        public decimal Amount { get; protected set; }
    }
}
