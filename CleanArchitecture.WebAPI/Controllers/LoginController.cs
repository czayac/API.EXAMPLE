using CleanArchitecture.Application.Features.Login;
using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using CleanArchitecture.Application.Features.UserFeatures.Login;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("login")]
public class LoginController : ControllerBase
{
    private readonly IMediator _mediator;

    public LoginController(IMediator mediator)
    {
        _mediator = mediator;
    }


    [AllowAnonymous]
    [HttpPost("authenticate")]
    public async Task<ActionResult<AuthenticateLoginResponse>> Authenticate( AuthenticateLoginRequest request,
        CancellationToken cancellationToken)
    {
        var user = await _mediator.Send(request, cancellationToken);

        if (user == null)
            return BadRequest(new { message = "Username or password is incorrect" });

        return Ok(user);
    }
}