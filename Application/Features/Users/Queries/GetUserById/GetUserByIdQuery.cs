using Application.DTOs;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Users.Queries.GetUserById
{
    public class GetUserByIdQuery : IRequest<Response<UserDto>>
    {
        public Guid Id { get; set; }

        public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Response<UserDto>>
        {
            private readonly IArdalisRepositoryAsync<User> _repositoryAsync;
            private readonly IMapper _mapper;

            public GetUserByIdQueryHandler(IMapper mapper, IArdalisRepositoryAsync<User> repositoryAsync)
            {
                _mapper=mapper;
                _repositoryAsync=repositoryAsync;
            }

            public async Task<Response<UserDto>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _repositoryAsync.GetByIdAsync(request.Id);
                if (user == null)
                    throw new KeyNotFoundException($"Record with id {request.Id} not found");
                else
                {
                    var dto = _mapper.Map<UserDto>(user);
                    return new Response<UserDto>(dto);
                }
            }
        }
    }
}
