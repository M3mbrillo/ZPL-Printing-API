using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZPL_Server.Models.DTO;
using ZPL_Server.Services;

namespace ZPL_Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZebraController : ControllerBase
    {
        private readonly ILogger<ZebraController> _logger;

        public ZebraController(
            ILogger<ZebraController> logger,
            ZebraService zebraService    
        )
        {
            _logger = logger;
            ZebraService = zebraService;
        }

        public ZebraService ZebraService { get; }

        [HttpPost]
        [Route("{ipAddress}:{port}/print")]
        public IActionResult PostPrint([FromRoute] string ipAddress, [FromRoute] string port, [FromBody] ZplCommand zplCommand)
        {
            this.ZebraService.PrintTo(ipAddress, int.Parse(port), zplCommand.Command);
            return Ok();
        }
    }
}
