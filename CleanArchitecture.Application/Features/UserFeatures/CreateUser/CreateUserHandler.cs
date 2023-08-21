using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.CreateUser;

public sealed class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
{
    private readonly IRepository<User> _dapperRepository;
    private readonly IMapper _mapper;

    public CreateUserHandler(IMapper mapper, IRepository<User> dapperRepository)
    {
        _mapper = mapper;
        _dapperRepository = dapperRepository;
    }

    public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        await _dapperRepository.InsertAsync(user);          

        return _mapper.Map<CreateUserResponse>(user);
    }
}