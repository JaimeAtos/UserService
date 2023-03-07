using Atos.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class AppEntityBase<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        public TKey Id { get; set; }
        public bool State { get; set; }
        public TUserKey IdUserCreator { get; set; }
        public TUserKey UserCreatorId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
