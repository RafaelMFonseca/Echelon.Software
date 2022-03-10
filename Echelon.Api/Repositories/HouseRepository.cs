using Microsoft.EntityFrameworkCore;
using Echelon.Api.Abstractions.Repositories;
using Echelon.Infrastructure.EntityFramework.Context;
using Echelon.Core.Entities;

namespace Echelon.Api.Repositories;

public class HouseRepository : IHouseRepository
{
    private readonly AppDbContext _context;

    public HouseRepository(AppDbContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public Task<List<House>?> GetAll()
    {
        return _context.Houses.ToListAsync();
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _context.Dispose();
    }
}
