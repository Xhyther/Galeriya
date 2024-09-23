namespace Galeriya.Models
{
    public class User
    {
        public int Id { get; set; }
        public String? ProfilePicture { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
