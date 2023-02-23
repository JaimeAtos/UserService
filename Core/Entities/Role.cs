using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Role : MyAppEntityBase<Guid, Guid>
    {
        public string RoleDescription { get; set; }
        public User User { get; set; }
    }
}
