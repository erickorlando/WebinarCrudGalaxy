using System.ComponentModel.DataAnnotations;

namespace WebinarCrudGalaxy.Shared;

public class ClienteDtoRequest
{
    [StringLength(100)]
    [Required]
    public string Nombres { get; set; } = default!;

    [StringLength(100)]
    [Required]
    public string Apellidos { get; set; } = default!;

    [StringLength(500)]
    [EmailAddress]
    public string Email { get; set; } = default!;
}