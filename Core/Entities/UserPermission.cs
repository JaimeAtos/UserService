using static System.Net.Mime.MediaTypeNames;

namespace Core.Entities
{
    public class UserPermission : MyAppEntityBase<Guid, Guid>
    {
        public Guid UserId { get; set; }
        public Guid PermissionId { get; set; }

        public User User { get; set; }
        public Permission Permission { get; set; }
    }
}