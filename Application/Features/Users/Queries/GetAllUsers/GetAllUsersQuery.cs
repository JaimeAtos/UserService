using Application.DTOs;
using Application.Interfaces;
using Application.Specifications;
using Application.Wrappers;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Users.Queries.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<PagedResponse<List<UserDto>>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string Name { get; set; }

        public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, PagedResponse<List<UserDto>>>
        {
            private readonly IArdalisRepositoryAsync<User> _repositoryAsync;
            private readonly IMapper _mapper;


            public GetAllUsersQueryHandler(IArdalisRepositoryAsync<User> repositoryAsync, IMapper mapper)
            {
                _repositoryAsync=repositoryAsync;
                _mapper=mapper;
            }

            public async Task<PagedResponse<List<UserDto>>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
            {
                var users = await _repositoryAsync.ListAsync(new PagedUserSpecification(request.PageSize, request.PageNumber, request.Name));
                var userDto = _mapper.Map<List<UserDto>>(users);

                return new PagedResponse<List<UserDto>>(userDto, request.PageNumber, request.PageSize);
            }
        }
    }
}
