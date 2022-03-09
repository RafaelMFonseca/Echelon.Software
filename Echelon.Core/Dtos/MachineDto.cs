using System.ComponentModel.DataAnnotations;

namespace Echelon.Core.Dtos;

public class MachineDto
{
    [Required(ErrorMessage = "Name is required.")]
    public string Name { get; set; } = string.Empty;
}