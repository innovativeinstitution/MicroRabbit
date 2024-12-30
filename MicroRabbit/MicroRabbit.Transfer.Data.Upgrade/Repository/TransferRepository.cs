using MicroRabbit.Transfer.Data.Upgrade.Context;
using MicroRabbit.Transfer.Domain.Upgrade.Interfaces;
using MicroRabbit.Transfer.Domain.Upgrade.Models;

namespace MicroRabbit.Transfer.Data.Upgrade.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private TransferDbContext _ctx;

        public TransferRepository(TransferDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(TransferLog transferLog)
        {
            _ctx.TransferLogs.Add(transferLog);
            _ctx.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _ctx.TransferLogs;
        }
    }
}
