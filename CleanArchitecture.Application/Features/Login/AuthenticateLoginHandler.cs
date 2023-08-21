using AutoMapper;
using CleanArchitecture.Application.Features.UserFeatures.Login;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.Login;

public sealed class AuthenticateLoginHandler : IRequestHandler<AuthenticateLoginRequest, AuthenticateLoginResponse>
{

    private readonly ILoginService _loginService;
    private readonly IMapper _mapper;

    public AuthenticateLoginHandler(IMapper mapper, ILoginService loginService)
    {
        _mapper = mapper;
        _loginService = loginService;
    }

    public async Task<AuthenticateLoginResponse> Handle(AuthenticateLoginRequest request, CancellationToken cancellationToken)
    {

        var login =  _loginService.Authenticate(request.Username, request.Password);

        return _mapper.Map<AuthenticateLoginResponse>(login);
    }
}