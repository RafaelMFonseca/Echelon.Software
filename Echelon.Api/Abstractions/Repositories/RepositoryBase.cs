using Echelon.Infrastructure.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;

namespace Echelon.Api.Abstractions.Repositories;

/// <summary>
/// Generic repositoy implementation.
/// </summary>
/// <typeparam name="TEntity">The entity type.</typeparam>
public abstract class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public RepositoryBase(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    /// <inheritdoc />
    public async Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _dbSet.ToListAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await _dbSet.FindAsync(id, cancellationToken);
    }

    /// <inheritdoc />
    public async Task CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Add(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Update(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
    {
        _dbSet.Remove(entity);
        await _context.SaveChangesAsync(cancellationToken);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _context.Dispose();
    }
}
