using MicroRabbit.Domain.Core.Upgrade.Bus;
using MicroRabbit.Transfer.Application.Upgrade.Interfaces;
using MicroRabbit.Transfer.Domain.Upgrade.Interfaces;
using MicroRabbit.Transfer.Domain.Upgrade.Models;

namespace MicroRabbit.Transfer.Application.Upgrade.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _transferRepository.GetTransferLogs();
        }
    }
}
