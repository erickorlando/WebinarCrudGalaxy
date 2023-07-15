namespace WebinarCrudGalaxy.Shared;

public class ClienteDtoResponse
{
    public int Id { get; set; }
    public string Nombres { get; set; } = default!;

    public string Apellidos { get; set; } = default!;

    public string Email { get; set; } = default!;
}