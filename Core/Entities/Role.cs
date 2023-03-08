using Core.Commons;

namespace Core.Entities
{
    public class Role : AppEntityBase<Guid, Guid>
    {
        public string RoleDescription { get; set; }
        public User User { get; set; }
    }
}
