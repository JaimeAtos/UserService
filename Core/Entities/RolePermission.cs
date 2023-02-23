using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Core.Entities
{
    public class RolePermission : MyAppEntityBase<Guid, Guid>
    {
        public Guid UserId { get; set; }
        public Guid PermissionId { get; set; }
        public string RoleName { get; set; }

        public User User { get; set; }
        public Permission Permission { get; set; }
    }
}
