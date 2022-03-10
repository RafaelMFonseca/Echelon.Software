using System.ComponentModel.DataAnnotations;

namespace Echelon.Core.Entities;

public class House
{
    [Key]
    [Required]
    public int Id { get; set; }

    public int Area { get; set; }
    public int Bedrooms { get; set; }
    public int Suites { get; set; }
    public int Bathrooms { get; set; }
    public int ParkingSpaces { get; set; }
    public int Floor { get; set; }
    public bool AcceptsPets { get; set; }
    public bool HasFurniture { get; set; }
    public bool IsNearSubway { get; set; }

    public bool ForRent { get; set; }
    public bool ForSale { get; set; }

    public decimal SalePrice { get; set; }
    public decimal RentPrice { get; set; }
    public decimal CondominiumPrice { get; set; }
    public decimal IptuPrice { get; set; }
    public decimal HomeProtectionPrice { get; set; }
    public decimal TenantServiceFeePrice { get; set; }

    public string Description { get; set; }
}
