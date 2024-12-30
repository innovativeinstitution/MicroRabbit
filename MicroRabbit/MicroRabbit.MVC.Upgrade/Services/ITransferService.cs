using MicroRabbit.MVC.Upgrade.Models.DTO;

namespace MicroRabbit.MVC.Upgrade.Services
{
    public interface ITransferService
    {
        Task Transfer(TransferDto transferDto);
    }
}
