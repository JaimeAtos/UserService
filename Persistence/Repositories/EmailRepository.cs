using Atos.EFCore.Repository;
using Persistence.Context;
using Persistence.RepositoriesInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class EmailRepository : RepositoryBase<Guid, Guid>, IEmailRepository
    {
        public EmailRepository(UserServiceDbContext context) : base(context)
        {
        }
    }
}
