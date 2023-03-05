using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.RepositoriesInterfaces;

namespace UserServiceApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repository;

        public UserController(IUserRepository repository)
        {
            this.repository=repository;
        }

        [HttpGet("/user")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await repository.GetEntity<User>().ToListAsync();
            return Ok(users);
        }

        [HttpGet("/user/{id}")]
        public async Task<IActionResult> GetUserByGuid(Guid id)
        {
            var user = await repository.GetEntity<User>().FindAsync(id);
            if(user == null) 
                return NotFound();
            return Ok(user);
        }

        [HttpDelete("/user/{id}")]
        public async Task<IActionResult> DeleteUserByGuid(Guid id)
        {
            var user = await repository.GetEntity<User>().FindAsync(id);
            if (user == null)
                return NotFound();
            user.State = false;
            await repository.UpdateAsync(user);
            return Ok(user);
        }
    }
}
