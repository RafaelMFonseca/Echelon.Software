using Echelon.Infrastructure.EntityFramework.Context;
using Echelon.Api.Abstractions.Repositories;
using Echelon.Core.Entities;

namespace Echelon.Api.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context) { }
}
