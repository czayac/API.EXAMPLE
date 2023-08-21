namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser;

public sealed record UpdateUserResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}