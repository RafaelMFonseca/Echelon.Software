using Echelon.Core.Models;

namespace Echelon.Api.Abstractions.Services;

public interface IHouseService : IDisposable
{
    /// <summary>
    /// Gets all houses.
    /// </summary>
    /// <returns>
    /// A task that represents the asynchronous operation.
    /// The task result contains all houses.
    /// </returns>
    Task<List<HouseDto>> GetAll();

    /// <summary>
    /// Get the entity.
    /// </summary>
    /// <param name="id">Entity identifier.</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the house.
    /// </returns>
    Task<HouseDto?> GetById(int id);

    /// <summary>
    /// Insert the entity.
    /// </summary>
    /// <param name="houseDto">The house to insert.</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the house.
    /// </returns>
    Task<HouseDto?> Create(HouseDto houseDto);
}
