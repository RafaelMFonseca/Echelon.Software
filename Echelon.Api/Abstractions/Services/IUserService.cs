using Echelon.Core.Models;

namespace Echelon.Api.Abstractions.Services;

/// <summary>
/// Represents the user service.
/// </summary>
public interface IUserService : IDisposable
{
    /// <summary>
    /// Performs a login.
    /// </summary>
    /// <param name="request">Credentials to use</param>
    /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to cancel the operation.</param>
    /// <returns>The login result.</returns>
    public Task<UserLoginResponseModel> Login(UserLoginRequestModel request, CancellationToken cancellationToken = default(CancellationToken));
}
