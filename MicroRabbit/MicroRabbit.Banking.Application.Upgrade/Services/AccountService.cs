using MicroRabbit.Banking.Application.Upgrade.Interfaces;
using MicroRabbit.Banking.Application.Upgrade.Models;
using MicroRabbit.Banking.Domain.Upgrade.Commands;
using MicroRabbit.Banking.Domain.Upgrade.Interfaces;
using MicroRabbit.Banking.Domain.Upgrade.Models;
using MicroRabbit.Domain.Core.Upgrade.Bus;

namespace MicroRabbit.Banking.Application.Upgrade.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IEventBus _bus;

        public AccountService(IAccountRepository accountRepository, IEventBus bus)
        {
            _accountRepository = accountRepository;
            _bus = bus;
        }

        public IEnumerable<Account> GetAccounts()
        {
            return _accountRepository.GetAccounts();
        }

        public void Transfer(AccountTransfer accountTransfer)
        {
            var createTransferCommand = new CreateTransferCommand(
                    accountTransfer.FromAccount,
                    accountTransfer.ToAccount,
                    accountTransfer.TransferAmount
                );

            _bus.SendCommand(createTransferCommand);
        }
    }
}
