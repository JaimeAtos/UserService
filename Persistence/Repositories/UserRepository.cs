using Atos.EFCore.Repository;
using Persistence.Context;
using Persistence.RepositoriesInterfaces;

namespace Persistence.Repositories
{
    public class UserRepository : RepositoryBase<Guid, Guid>, IUserRepository
    {
        public UserRepository(UserServiceDbContext context) : base(context)
        {
        }
    }
}
