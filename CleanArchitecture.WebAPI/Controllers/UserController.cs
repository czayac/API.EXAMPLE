using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using CleanArchitecture.Application.Features.UserFeatures.DeleteUser;
using CleanArchitecture.Application.Features.UserFeatures.GetAllUser;
using CleanArchitecture.Application.Features.UserFeatures.UpdateUser;
using CleanArchitecture.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }
    [Authorize]
    [HttpGet("GetAll")]
    public async Task<ActionResult<List<GetAllUserResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllUserRequest(), cancellationToken);
        return Ok(response);
    }

    [Authorize(Roles = Role.Admin)]
    [HttpPost]
    public async Task<ActionResult<CreateUserResponse>> Create(CreateUserRequest request,  CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [Authorize(Roles = Role.Admin)]
    [HttpPut]
    public async Task<ActionResult<UpdateUserResponse>> Update(UpdateUserRequest request,  CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
    [Authorize(Roles = Role.Admin)]
    [HttpDelete]
    public async Task<ActionResult<DeleteUserResponse>> Delete(DeleteUserRequest request,  CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }


}