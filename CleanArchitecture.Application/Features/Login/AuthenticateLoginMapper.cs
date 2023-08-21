using AutoMapper;
using CleanArchitecture.Application.Features.UserFeatures.Login;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public sealed class AuthenticateLoginMapper : Profile
{
    public AuthenticateLoginMapper()
    {
        CreateMap<AuthenticateLoginRequest, Domain.Entities.Login>();
        CreateMap<Domain.Entities.Login, AuthenticateLoginResponse>();
    }
}