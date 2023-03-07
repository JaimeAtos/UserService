namespace Core.Entities
{
    public class Permission : AppEntityBase<Guid,Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Controller { get; set; }
        public string Action { get; set; }

        public List<UserPermission> UserPermission { get; set; }
        public List<RolePermission> RolePermissions { get; set; }

        public Permission()
        {
            this.UserPermission = new List<UserPermission>();
            this.RolePermissions = new List<RolePermission>();
        }
    }
}