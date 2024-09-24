using Galeriya.Data; // To access the ApplicationDbContext 
using Microsoft.AspNetCore.Mvc; //To inherit Controller Class
using Galeriya.Models; // To use all the models

namespace Galeriya.Controllers
{
    public class PostController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //Get Posts
        public async Task<IActionResult> Index()
        {
            return View(//Probably need something here later on);
        }

    }
}
  


