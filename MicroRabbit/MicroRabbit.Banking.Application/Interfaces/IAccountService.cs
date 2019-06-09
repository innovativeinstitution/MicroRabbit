using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Application.Interfaces
{
    public interface IAccountService
    {
        IEnumerable<Account> GetAccounts();
    }
}
