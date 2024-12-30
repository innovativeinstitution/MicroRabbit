using MicroRabbit.Banking.Data.Upgrade.Context;
using MicroRabbit.Banking.Domain.Upgrade.Interfaces;
using MicroRabbit.Banking.Domain.Upgrade.Models;

namespace MicroRabbit.Banking.Data.Upgrade.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private BankingDbContext _ctx;

        public AccountRepository(BankingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
