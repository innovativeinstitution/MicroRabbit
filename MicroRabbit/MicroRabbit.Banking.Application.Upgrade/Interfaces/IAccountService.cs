using MicroRabbit.Banking.Application.Upgrade.Models;
using MicroRabbit.Banking.Domain.Upgrade.Models;

namespace MicroRabbit.Banking.Application.Upgrade.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
        void Transfer(AccountTransfer accountTransfer);
    }
}
