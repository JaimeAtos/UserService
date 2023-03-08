using Application.Exceptions;
using Application.Interfaces;
using Application.Wrappers;
using AutoMapper;
using Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands.UpdateUserCommand
{
    public class UpdateUserCommand : IRequest<Response<Guid>>
    {
        public Guid Id { get; set; }
        public string Name { get; set;}
    }

    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Response<Guid>>
    {
        //TODO: Checar si podemos utilizar el repo de Daniel con esto ya que se usar ardalis en el video
        //Ademas de eso: estos fields me estan dando error, checar porque, puede ser por el int o por otra cosa
        private readonly IArdalisRepositoryAsync<User> _repositoryAsync;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IArdalisRepositoryAsync<User> repositoryAsync, IMapper mapper)
        {
            _repositoryAsync=repositoryAsync;
            _mapper=mapper;
        }

        public async Task<Response<Guid>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _repositoryAsync.GetByIdAsync(request.Id);
            if (user == null)
                throw new KeyNotFoundException($"Record with id {request.Id} not found");
            else
            {
                user.Name = request.Name;
                await _repositoryAsync.UpdateAsync(user);
            }

            return new Response<Guid>(user.Id);
        }
    }
}
