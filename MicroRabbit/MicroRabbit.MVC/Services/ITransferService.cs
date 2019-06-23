using MicroRabbit.MVC.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
