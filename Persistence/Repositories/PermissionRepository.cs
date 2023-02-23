using Atos.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;
using Persistence.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class PermissionRepository : RepositoryBase<Guid, Guid>, IPermissionRepository
    {
        public PermissionRepository(UserServiceDbContext context) : base(context)
        {
        }
    }
}
