using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllUser;

public sealed class GetAllUserHandler : IRequestHandler<GetAllUserRequest, List<GetAllUserResponse>>
{
   
    private readonly IRepository<User> _dapperRepository;
    private readonly IMapper _mapper;

    public GetAllUserHandler(IMapper mapper, IRepository<User> dapperRepository)
    {
    
        _mapper = mapper;
        _dapperRepository = dapperRepository;
    }
    
    public async Task<List<GetAllUserResponse>> Handle(GetAllUserRequest request, CancellationToken cancellationToken)
    {
        var users = await _dapperRepository.GetAllAsync();
        return _mapper.Map<List<GetAllUserResponse>>(users);
    }
}