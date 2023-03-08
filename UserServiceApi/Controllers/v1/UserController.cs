using Application.Features.Users.Commands.CreateUserCommand;
using Application.Features.Users.Commands.DeleteUserCommand;
using Application.Features.Users.Commands.UpdateUserCommand;
using Application.Features.Users.Queries.GetAllUsers;
using Application.Features.Users.Queries.GetUserById;
using Microsoft.AspNetCore.Mvc;

namespace UserServiceApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpGet()]
        public async Task<IActionResult> GetUserById([FromQuery] GetAllUsersParameters filter)
        {
            return Ok(await Mediator.Send(new GetAllUsersQuery
            {
                PageNumber = filter.PageNumber,
                PageSize = filter.PageSize,
                Name = filter.Name
            }));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            return Ok(await Mediator.Send(new GetUserByIdQuery { Id = id }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserByGuid(UpdateUserCommand command, Guid id)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserByGuid(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteUserCommand { Id = id}));
        }

    }
}
