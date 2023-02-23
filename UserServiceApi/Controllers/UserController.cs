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
            var result = await repository.GetEntity<User>().ToListAsync();
            return Ok(result);
        }
    }
}
