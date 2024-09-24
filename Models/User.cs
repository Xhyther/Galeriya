namespace Galeriya.Models
{
    public class User
    {
        public int Id { get; set; }
        public String? ProfilePicture { get; set; }
        public String UserName { get; set; }
        public String Bio {  get; set; }
        public String Email { get; set; }
        public DateTime JoinDate { get; set; }

    }
}
