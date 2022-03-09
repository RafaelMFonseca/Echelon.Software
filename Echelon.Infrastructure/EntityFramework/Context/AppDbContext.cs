using Microsoft.EntityFrameworkCore;
using Echelon.Core.Entities;

namespace Echelon.Infrastructure.EntityFramework.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Machine> Machines { get; set; }
}