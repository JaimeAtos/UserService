using Atos.Core.Abstractions;

namespace Core.Commons
{
    public class AppEntityBase<TKey, TUserKey> : IEntityBase<TKey, TUserKey>
    {
        public TKey Id { get ; set; }
        public bool State { get ; set; }
        public TUserKey UserCreatorId { get ; set; }
        public DateTime CreatedDate { get ; set; }
        public TUserKey IdUserCreator { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
