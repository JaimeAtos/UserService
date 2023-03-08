using Core.Commons;

namespace Core.Entities
{
    public class Email : AppEntityBase<Guid,Guid>
    {
        public string EmailDescription { get; set; }
        public bool IsDefault { get; set; }
        public User User { get; set; }
    }
}