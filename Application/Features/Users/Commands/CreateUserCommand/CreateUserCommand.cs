using Application.Wrappers;
using Atos.Core.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Users.Commands.CreateUserCommand
{
                         //DTO
    public class CreateUserCommand : IRequest<Response<Guid>>
    {
        public string Name { get; init; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Response<Guid>>
    {
        public async Task<Response<Guid>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
