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
    public async Task<List<House>> GetAll()
    {
        return await _context.Houses.ToListAsync();
    }

    /// <inheritdoc />
    public async Task<House?> GetById(int id)
    {
        return await _context.Houses.Where(x => x.Id == id).SingleOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task Create(House house, CancellationToken cancellationToken = default(CancellationToken))
    {
        await _context.Houses.AddAsync(house);
        await _context.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _context.Dispose();
    }
}
