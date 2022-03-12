using Echelon.Core.Entities;

namespace Echelon.Api.Abstractions.Repositories;

public interface IHouseRepository : IDisposable
{
    /// <summary>
    /// Gets all houses.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains all houses.
    /// </returns>
    Task<List<House>> GetAll();

    /// <summary>
    /// Get the entity.
    /// </summary>
    /// <param name="id">Entity identifier.</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the house.
    /// </returns>
    Task<House?> GetById(int id);

    /// <summary>
    /// Insert the entity.
    /// </summary>
    /// <param name="house">The house to insert.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>A task that represents the asynchronous operation</returns>
    Task Create(House house, CancellationToken cancellationToken = default(CancellationToken));
}
