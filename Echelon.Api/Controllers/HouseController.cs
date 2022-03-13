using Echelon.Api.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Echelon.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HouseController : ControllerBase
{
    private readonly ILogger<HouseController> _logger;
    private readonly IUserService _userService;

    public HouseController(ILogger<HouseController> logger, IUserService userService)
    {
        _logger = logger;
        _userService = userService;
    }

    [HttpPost]
    public async Task<IActionResult> Login()
    {
        return null;
    }
}
