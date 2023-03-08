using Application.Features.Users.Commands.CreateUserCommand;
using Application.Features.Users.Commands.DeleteUserCommand;
using Application.Features.Users.Commands.UpdateUserCommand;
using Application.Features.Users.Queries.GetUserById;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.RepositoriesInterfaces;

namespace UserServiceApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class UserController : BaseApiController
    {

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            return Ok(await Mediator.Send(new GetUserByIdQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserByGuid(UpdateUserCommand command, Guid id)
        {
            if (id != command.Id)
                return BadRequest();

            return Ok(await Mediator.Send(command));
        }

        //[HttpGet("/user")]
        //public async Task<IActionResult> GetAllUsers()
        //{
        //    var users = await _repository.GetEntity<User>().ToListAsync();
        //    return Ok(users);
        //}

        //[HttpGet("/user/{id}")]
        //public async Task<IActionResult> GetUserByGuid(Guid id)
        //{
        //    var user = await _repository.GetEntity<User>().FindAsync(id);
        //    if (user == null)
        //        return NotFound();
        //    return Ok(user);
        //}

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUserByGuid(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteUserCommand { Id = id}));
        }

    }
}
