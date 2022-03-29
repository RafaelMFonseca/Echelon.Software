using Echelon.Api.Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Echelon.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserService _userService;

    public UserController(ILogger<UserController> logger, IUserService userService)
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
