using MicroRabbit.Banking.Domain.Upgrade.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroRabbit.Banking.Data.Upgrade.Context
{
    public class BankingDbContext : DbContext
    {
        public BankingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
