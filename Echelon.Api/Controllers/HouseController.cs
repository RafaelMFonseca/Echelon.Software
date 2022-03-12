using Microsoft.AspNetCore.Mvc;
using Echelon.Api.Abstractions.Services;
using Echelon.Core.Models;

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
        var housesDto = await _houseService.GetAll();
        if (housesDto is null) return NotFound();
        return Ok(housesDto);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var houseDto = await _houseService.GetById(id);
        if (houseDto is null) return NotFound();
        return Ok(houseDto);
    }

    [HttpPut]
    public async Task<IActionResult> Create(HouseDto houseDto)
    {
        var createHouseDto = await _houseService.Create(houseDto);
        if (createHouseDto is null) return NotFound();
        return Ok(createHouseDto);
    }
}
