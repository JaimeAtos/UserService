using Core.Commons;

namespace Core.Entities
{
    public class UserPermission : AppEntityBase<Guid, Guid>
    {
        public Guid UserId { get; set; }
        public Guid PermissionId { get; set; }
        public User User { get; set; }
        public Permission Permission { get; set; }
    }
}