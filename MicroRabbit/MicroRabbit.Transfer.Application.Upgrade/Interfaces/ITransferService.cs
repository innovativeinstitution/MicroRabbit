using MicroRabbit.Transfer.Domain.Upgrade.Models;

namespace MicroRabbit.Transfer.Application.Upgrade.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
