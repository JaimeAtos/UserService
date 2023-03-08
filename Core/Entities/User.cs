using Core.Commons;

namespace Core.Entities
{
    public class User : AppEntityBase<Guid, Guid>
    {
        public string Name { get; set; }
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
