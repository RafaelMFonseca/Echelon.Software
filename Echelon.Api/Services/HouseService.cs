using Echelon.Api.Abstractions.Repositories;
using Echelon.Api.Abstractions.Services;
using Echelon.Core.Entities;
using Echelon.Core.Dtos;
using AutoMapper;

namespace Echelon.Api.Services;

public class HouseService : IHouseService
{
    private readonly IHouseRepository _houseRepository;
    private readonly IMapper _mapper;

    public HouseService(IHouseRepository houseRepository, IMapper mapper)
    {
        _houseRepository = houseRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<List<HouseDto>?> GetAll()
    {
        List<House>? houses = await _houseRepository.GetAll();
        if (houses is not null) return _mapper.Map<List<HouseDto>>(houses);
        return null;
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _houseRepository.Dispose();
    }
}
