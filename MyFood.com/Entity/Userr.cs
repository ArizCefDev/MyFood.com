namespace MyFood.com.Entity
{
    public class Userr
    {
        public long ID { get; set; }
        public string? UserName { get; set; }
        public string? Salt { get; set; }
        public string? PasswordHash { get; set; }
        public string? Password { get; set; }
        public string? RoleName { get; set; }
        public string? ConfimPassword { get; set; }
    }
}
