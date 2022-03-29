using Echelon.Infrastructure.EntityFramework.Context;
using Echelon.Api.Abstractions.Repositories;
using Echelon.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Echelon.Api.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context) { }

    /// <inheritdoc />
    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await _context.Users.Where(x => x.Email == email).FirstOrDefaultAsync(cancellationToken);
    }
}
