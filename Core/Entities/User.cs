using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atos.Core.Abstractions;

namespace Core.Entities
{
    public class User : MyAppEntityBase<Guid, Guid>
    {
        public string Name { get; init; }
        public List<UserPermission> UserPermissions { get; set; }
        public List<RolePermission> RolePermissions { get; set; }

        //Todo: Agregar email y otras propiedades faltantes

        public User()
        {
            this.UserPermissions = new List<UserPermission>();
            this.RolePermissions = new List<RolePermission>();  
        }
    }
}
