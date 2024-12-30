using MicroRabbit.Banking.Domain.Upgrade.Models;

namespace MicroRabbit.Banking.Domain.Upgrade.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
