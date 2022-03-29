using Echelon.Api.Abstractions.Repositories;
using Echelon.Api.Abstractions.Services;
using Echelon.Api.Abstractions.Security;
using Echelon.Core.Models;
using AutoMapper;

namespace Echelon.Api.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IPasswordVerifier _passwordVerifier;
    private readonly IMapper _mapper;

    public UserService(
        IUserRepository userRepository,
        IPasswordVerifier passwordVerifier,
        IMapper mapper)
    {
        _userRepository = userRepository;
        _passwordVerifier = passwordVerifier;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public async Task<UserLoginResponseModel> Login(UserLoginRequestModel request, CancellationToken cancellationToken = default)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email);

        if (user == null || user.Password == null || !_passwordVerifier.Verify(request.Password, user.Password))
        {
            return new UserLoginResponseModel(false);
        }

        return new UserLoginResponseModel(true);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _userRepository.Dispose();
    }
}
