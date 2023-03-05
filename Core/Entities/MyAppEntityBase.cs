using Atos.Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public abstract class MyAppEntityBase<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        public TKey Id { get; set; }
        public bool State { get; set; }
        public TUserKey IdUserCreator { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastModification { get; set; }
    }
}
