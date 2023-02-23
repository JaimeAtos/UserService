using Atos.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.RepositoriesInterfaces;

namespace Persistence.Repositories
{
    public class UserPermissionRepository : RepositoryBase<Guid, Guid>, IUserPermissionRepository
    {
        public UserPermissionRepository(UserServiceDbContext context) : base(context)
        {
        }
    }
}
