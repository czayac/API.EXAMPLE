using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;

public sealed record DeleteUserRequest(int Id) : IRequest<DeleteUserResponse>;