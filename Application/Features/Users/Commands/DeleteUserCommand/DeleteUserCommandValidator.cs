using FluentValidation;

namespace Application.Features.Users.Commands.DeleteUserCommand
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(r => r.Id).NotEmpty().WithMessage("{PropertyName} cannot be empty");          
        }
    }
}