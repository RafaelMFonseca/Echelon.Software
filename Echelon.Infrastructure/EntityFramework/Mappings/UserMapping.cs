using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Echelon.Core.Entities;

namespace Echelon.Infrastructure.EntityFramework.Mappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User));

        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasColumnName("id").ValueGeneratedOnAdd();
        builder.Property(m => m.Email).HasColumnName("email").HasMaxLength(256);
        builder.Property(m => m.Name).HasColumnName("name").HasMaxLength(50);
        builder.Property(m => m.Password).HasColumnName("password").HasMaxLength(300);
    }
}
