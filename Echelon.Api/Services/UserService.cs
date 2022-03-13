using Echelon.Api.Abstractions.Repositories;
using Echelon.Api.Abstractions.Services;
using Echelon.Core.Entities;
using Echelon.Core.Models;
using AutoMapper;

namespace Echelon.Api.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;
    private readonly IMapper _mapper;

    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    /// <inheritdoc />
    public Task<UserLoginResponseModel> Login(UserLoginRequestModel request, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public void Dispose()
    {
        _userRepository.Dispose();
    }
}
