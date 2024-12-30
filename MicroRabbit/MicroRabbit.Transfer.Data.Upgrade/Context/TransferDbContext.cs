using MicroRabbit.Transfer.Domain.Upgrade.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Transfer.Data.Upgrade.Context
{
    public class TransferDbContext : DbContext
    {
        public TransferDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TransferLog> TransferLogs { get; set; }
    }
}
