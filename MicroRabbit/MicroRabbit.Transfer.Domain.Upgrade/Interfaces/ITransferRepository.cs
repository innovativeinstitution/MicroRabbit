using MicroRabbit.Transfer.Domain.Upgrade.Models;

namespace MicroRabbit.Transfer.Domain.Upgrade.Interfaces
{
    public interface ITransferRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
        void Add(TransferLog transferLog);
    }
}
