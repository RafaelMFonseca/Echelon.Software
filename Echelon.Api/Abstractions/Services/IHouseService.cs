using Echelon.Core.Dtos;

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
    Task<List<HouseDto>?> GetAll();
}
