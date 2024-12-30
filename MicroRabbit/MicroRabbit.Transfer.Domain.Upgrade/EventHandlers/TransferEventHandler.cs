using MicroRabbit.Domain.Core.Upgrade.Bus;
using MicroRabbit.Transfer.Domain.Upgrade.Events;
using MicroRabbit.Transfer.Domain.Upgrade.Interfaces;
using MicroRabbit.Transfer.Domain.Upgrade.Models;

namespace MicroRabbit.Transfer.Domain.Upgrade.EventHandlers
{
    public class TransferEventHandler : IEventHandler<TransferCreatedEvent>
    {
        private readonly ITransferRepository _transferRepository;

        public TransferEventHandler(ITransferRepository transferRepository)
        {
            _transferRepository = transferRepository;
        }

        public async Task Handle(TransferCreatedEvent @event)
        {
            _transferRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount
            });

            await Task.CompletedTask;
        }
    }
}
