namespace FSH.WebAPI.Application.Identity.Roles;

public class UpdatePermissionsRequest
{
    public string? Permission { get; set; }
    public bool Enabled { get; set; }
}