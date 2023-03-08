using Core.Entities;

namespace Application.DTOs
{
    public class UserDto
    {
        //TODO: verificar que campos debo de mostrar en front con el DTO
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public List<UserPermission> UserPermissions { get; set; }
        public List<RolePermission> RolePermissions { get; set; }
        public List<Email> Emails { get; set; }
    }
}
