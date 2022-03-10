using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Echelon.Core.Entities;

namespace Echelon.Infrastructure.EntityFramework.Mappings;

public class HouseMapping : IEntityTypeConfiguration<House>
{
    public void Configure(EntityTypeBuilder<House> builder)
    {
        builder.ToTable(nameof(House));

        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasColumnName("id").ValueGeneratedOnAdd();

        builder.Property(m => m.Area).HasColumnName("area");
        builder.Property(m => m.Bedrooms).HasColumnName("bedrooms");
        builder.Property(m => m.Suites).HasColumnName("suites");
        builder.Property(m => m.Bathrooms).HasColumnName("bathrooms");
        builder.Property(m => m.ParkingSpaces).HasColumnName("parking_spaces");
        builder.Property(m => m.Floor).HasColumnName("floor");
        builder.Property(m => m.AcceptsPets).HasColumnName("accepts_pets");
        builder.Property(m => m.HasFurniture).HasColumnName("has_furniture");
        builder.Property(m => m.IsNearSubway).HasColumnName("is_near_subway");

        builder.Property(m => m.ForRent).HasColumnName("for_rent");
        builder.Property(m => m.ForSale).HasColumnName("for_sale");

        builder.Property(m => m.SalePrice).HasColumnName("sale_price");
        builder.Property(m => m.RentPrice).HasColumnName("rent_price");
        builder.Property(m => m.CondominiumPrice).HasColumnName("condominium_price");
        builder.Property(m => m.IptuPrice).HasColumnName("iptu_price");
        builder.Property(m => m.HomeProtectionPrice).HasColumnName("home_protection_price");
        builder.Property(m => m.TenantServiceFeePrice).HasColumnName("tenant_service_fee_price");

        builder.Property(m => m.Description).HasColumnName("description").HasMaxLength(1000);
    }
}
