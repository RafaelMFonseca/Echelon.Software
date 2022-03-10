using Microsoft.AspNetCore.Mvc;
using Echelon.Api.Abstractions.Services;

namespace Echelon.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HouseController : ControllerBase
{
    private readonly ILogger<HouseController> _logger;
    private readonly IHouseService _houseService;

    public HouseController(ILogger<HouseController> logger, IHouseService houseService)
    {
        _logger = logger;
        _houseService = houseService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var houses = await _houseService.GetAll();
        if (houses is null) return NotFound();
        return Ok(houses);
    }
}
