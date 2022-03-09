using System.ComponentModel.DataAnnotations;

namespace Echelon.Core.Entities;

public class Machine
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;
}
