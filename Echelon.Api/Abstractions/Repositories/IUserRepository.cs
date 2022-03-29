using Echelon.Core.Entities;

namespace Echelon.Api.Abstractions.Repositories;

/// <summary>
/// Represents the user repository.
/// </summary>
public interface IUserRepository : IRepository<User>
{
    /// <summary>
    /// Get the user by email.
    /// </summary>
    /// <param name="email">User email.</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>
    /// A task that represents the asynchronous operation
    /// The task result contains the user.
    /// </returns>
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default(CancellationToken));
}
