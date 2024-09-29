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
        
        /**Use IActionResult for simple, quick-running tasks.
         * Use Task<//IActionResult> for I/O-bound,
         * long-running tasks to keep the application responsive.
        **/
        
        //Get Posts
        public async Task<IActionResult> Index()
        {
            return View(); //Probably need something here later on
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            
            return View(await _dbContext.Posts.FindAsync(id));
            //finding the post using postid
        }

        public IActionResult Create()
        {
            return View(); //returns the view of input form
        }
        
        
        

    }
}
  


