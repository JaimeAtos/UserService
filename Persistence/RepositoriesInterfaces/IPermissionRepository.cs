﻿using Atos.EFCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.RepositoriesInterfaces
{
    public interface IPermissionRepository : IRepositoryBase<Guid, Guid>
    {
    }
}
