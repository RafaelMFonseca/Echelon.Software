namespace Echelon.Api.Abstractions.Repositories;

/// <summary>
/// Represents a generic repository.
/// </summary>
/// <typeparam name="TEntity">The entity type.</typeparam>
public interface IRepository<TEntity> : IDisposable where TEntity : class
{
    /// <summary>
    /// Gets all entity entries..
    /// </summary>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains all entities.
    /// </returns>
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Get the entity.
    /// </summary>
    /// <param name="id">Entity identifier.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the entity.
    /// </returns>
    Task<TEntity?> GetByIdAsync(int id, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Insert the entity.
    /// </summary>
    /// <param name="entity">The entity to insert.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task CreateAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Update the entity.
    /// </summary>
    /// <param name="entity">The entity to update.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Delete the entity.
    /// </summary>
    /// <param name="entity">The entity to delete.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default(CancellationToken));
}
