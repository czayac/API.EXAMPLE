using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.UpdateUser;

public sealed class UpdateUserHandler : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
{
    private readonly IRepository<User> _dapperRepository;
    private readonly IMapper _mapper;

    public UpdateUserHandler(IMapper mapper, IRepository<User> dapperRepository)
    {
        _mapper = mapper;
        _dapperRepository = dapperRepository;
    }

    public async Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(request);
        await _dapperRepository.UpdateAsync(user);          

        return _mapper.Map<UpdateUserResponse>(user);
    }
}