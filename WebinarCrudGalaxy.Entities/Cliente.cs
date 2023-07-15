using System.ComponentModel.DataAnnotations;

namespace WebinarCrudGalaxy.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nombres { get; set; } = default!;

        [StringLength(100)]
        public string Apellidos { get; set; } = default!;

        [StringLength(500)]
        public string Email { get; set; } = default!;
    }
}