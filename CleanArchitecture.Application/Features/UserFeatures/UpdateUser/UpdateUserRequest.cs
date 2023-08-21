using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser;

public sealed record UpdateUserRequest(int Id, string Email, string Name) : IRequest<UpdateUserResponse>;