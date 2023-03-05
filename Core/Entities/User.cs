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
        public List<Email> Emails { get; set; }

        //Todo: Realizar relaciones

        public User()
        {
            UserPermissions = new List<UserPermission>();
            RolePermissions = new List<RolePermission>();  
            Emails = new List<Email>();
        }
    }
}
