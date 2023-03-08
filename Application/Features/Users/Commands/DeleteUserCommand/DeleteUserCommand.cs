using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Users.Commands.DeleteUserCommand
{
    public class DeleteUserCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
    }

    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Response<Guid>>
    {
        private readonly IArdalisRepositoryAsync<User> _repositoryAsync;
        private readonly IMapper _mapper;

        public DeleteUserCommandHandler(IArdalisRepositoryAsync<User> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync=repositoryAsync;
            _mapper=mapper;
        }

        public async Task<Response<Guid>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repositoryAsync.GetByIdAsync(request.Id);
            if (user == null)
            {
                throw new KeyNotFoundException($"Record with id {request.Id} not found");
            }
            else
            {
                user.State = false;
                await _repositoryAsync.UpdateAsync(user);
            }

            return new Response<Guid>(user.Id);
        }
    }
}
