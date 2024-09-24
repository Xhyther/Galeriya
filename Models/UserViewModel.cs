using System.ComponentModel.DataAnnotations;

namespace Galeriya.Models
{
    public class UserViewModel
    {
        public String UserName { get; set; }
        public String Bio { get; set; }
        public String Email { get; set; }

        //Temporary place holder for pfp based on stackoverflow (tbh idk)
        public IFormFile ProfilePicture { get; set; }
    }
}
