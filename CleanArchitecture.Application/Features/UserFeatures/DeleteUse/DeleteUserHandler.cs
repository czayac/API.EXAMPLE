using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.DeleteUser;

public sealed class DeleteUserHandler : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
{
    private readonly IRepository<User> _dapperRepository;
    private readonly IMapper _mapper;

    public DeleteUserHandler(IMapper mapper, IRepository<User> dapperRepository)
    {
        _mapper = mapper;
        _dapperRepository = dapperRepository;
    }

    public async Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        await _dapperRepository.DeleteAsync(request.Id);          

        return _mapper.Map<DeleteUserResponse>(user);
    }
}