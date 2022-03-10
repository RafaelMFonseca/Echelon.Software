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
    Task<List<House>?> GetAll();
}
