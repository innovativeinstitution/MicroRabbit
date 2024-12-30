using MediatR;
using MicroRabbit.Banking.Domain.Upgrade.Commands;
using MicroRabbit.Banking.Domain.Upgrade.Events;
using MicroRabbit.Domain.Core.Upgrade.Bus;

namespace MicroRabbit.Banking.Domain.Upgrade.CommandHandlers
{
    public class TransferCommandHandler : IRequestHandler<CreateTransferCommand, bool>
    {
        private readonly IEventBus _bus;

        public TransferCommandHandler(IEventBus bus)
        {
            _bus = bus;
        }

        public async Task<bool> Handle(CreateTransferCommand request, CancellationToken cancellationToken)
        {
            //publish event to RabbitMQ
            await _bus.Publish(new TransferCreatedEvent(request.From, request.To, request.Amount));

            return await Task.FromResult(true);
        }
    }
}
