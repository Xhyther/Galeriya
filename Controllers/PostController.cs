using Galeriya.Data; // To access the ApplicationDbContext 
using Microsoft.AspNetCore.Mvc; //To inherit Controller Class
using Galeriya.Models;
using Microsoft.EntityFrameworkCore; // To use all the models

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
            return View(await _dbContext.Posts.ToListAsync()); //Probably need something here later on
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

        [HttpPost] //For Creating
        [ValidateAntiForgeryToken] // Security to prevent CSRF attacks
        public async Task<IActionResult> Create( Post post)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(post);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(post);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
                return NotFound();
            
            var post = await _dbContext.Posts.FindAsync(id);
            return View(post);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PostTitle, ImgUrl, UploadPost")] Post post)
        {
            if(id != post.Id)
                return NotFound(); // If IDs do not match, return a 404 response

            if (ModelState.IsValid)
            {
                _dbContext.Entry(post).State = EntityState.Modified;  //Mark the entity as modified
                try
                {
                    _dbContext.Update(post);
                    await _dbContext.SaveChangesAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                        throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(post);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
                return NotFound();
            
            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return View(post);
        }

            
        [HttpDelete, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if(id == null)
                return NotFound();
            
            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }
            
            _dbContext.Posts.Remove(post);
            await _dbContext.SaveChangesAsync(); // Save changes to the database

            return RedirectToAction(nameof(Index));
        }
        
       
        

    }
}
  


