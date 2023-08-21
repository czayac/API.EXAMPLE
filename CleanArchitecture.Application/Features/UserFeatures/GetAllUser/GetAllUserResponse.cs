namespace CleanArchitecture.Application.Features.UserFeatures.GetAllUser;

public sealed record GetAllUserResponse
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
}