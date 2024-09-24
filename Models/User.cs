using System.ComponentModel.DataAnnotations;

namespace Galeriya.Models
{
    public class User
    {
        public int Id { get; set; }
        public String? ProfilePicture { get; set; }

        [Required]
        public String UserName { get; set; }

        [MaxLength(250)]
        public String Bio {  get; set; }

        [Required, EmailAddress]
        public String Email { get; set; }
        public DateTime JoinDate { get; set; } = DateTime.Now;

        // A single Relationship in which all the post of a user is collected
        public ICollection<Post> Posts { get; set; }

    }
}
