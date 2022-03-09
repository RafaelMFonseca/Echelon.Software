using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Echelon.Core.Entities;

namespace Echelon.Infrastructure.EntityFramework.Mappings;

public class MachineMapping : IEntityTypeConfiguration<Machine>
{
    public void Configure(EntityTypeBuilder<Machine> builder)
    {
        builder.HasKey(m => m.Id);

        builder.Property(c => c.Id).HasColumnName("id").ValueGeneratedOnAdd();
        builder.Property(m => m.Name).HasColumnName("name").IsRequired();

        builder.ToTable("Machines");

        builder.HasData(new Machine[]
        {
            new() { Id = 1, Name = "Windows 10" },
            new() { Id = 2, Name = "Ubuntu" },
            new() { Id = 3, Name = "Windows 11" },
        });
    }
}
