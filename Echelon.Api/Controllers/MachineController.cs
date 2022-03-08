using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Echelon.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MachineController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Windows 10", "Ubunto", "MacOS"
        };

        private readonly ILogger<MachineController> _logger;

        public MachineController(ILogger<MachineController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            _logger.Log(LogLevel.Information, "something here!!");
            return Summaries;
        }
    }
}