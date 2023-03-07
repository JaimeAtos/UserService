using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Commons
{
    public abstract class AuditableEntityBase : AppEntityBase<Guid, Guid>
    {
        public string LastModifiedBy { get; set; }
        public DateTime? LastModification { get; set; }
    }
}
