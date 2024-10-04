using Galeriya.Data;
using Microsoft.AspNetCore.Mvc;

namespace Galeriya.Controllers;

public class UserController : Controller
{
    private readonly ApplicationDbContext _context;

    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View();
    }
    
    
}