namespace Core.Entities
{
    public class Email : MyAppEntityBase<Guid,Guid>
    {
        public string EmailDescription { get; set; }
        public bool IsDefault { get; set; }
    }
}