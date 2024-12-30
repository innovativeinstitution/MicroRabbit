using MicroRabbit.Transfer.Application.Upgrade.Interfaces;
using MicroRabbit.Transfer.Domain.Upgrade.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Transfer.Api.Upgrade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        // GET api/transfer
        [HttpGet]
        public ActionResult<IEnumerable<TransferLog>> Get()
        {
            return Ok(_transferService.GetTransferLogs());
        }
    }
}
