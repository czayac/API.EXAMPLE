
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.Login;

 
public sealed record AuthenticateLoginRequest(string Username, string Password) : IRequest<AuthenticateLoginResponse>;