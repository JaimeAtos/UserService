using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Core.Entities;
using MediatR;

namespace Application.Features.Users.Commands.CreateUserCommand
{
                         //DTO
    public class CreateUserCommand : IRequest<Response<Guid>>
    {
        public string Name { get; init; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Response<Guid>>
    {
        //TODO: Checar si podemos utilizar el repo de Daniel con esto ya que se usar ardalis en el video
        //Ademas de eso: estos fields me estan dando error, checar porque, puede ser por el int o por otra cosa
        private readonly IArdalisRepositoryAsync<User> _repositoryAsync;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IArdalisRepositoryAsync<User> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync=repositoryAsync;
            _mapper=mapper;
        }

        public async Task<Response<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var newRecord = _mapper.Map<User>(request);
            var data = await _repositoryAsync.AddAsync(newRecord);

            return new Response<Guid>(data.Id);
        }
    }
}
