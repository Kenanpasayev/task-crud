using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_pronia.DAL;
using MVC_pronia.Models;

namespace MVC_pronia.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Category> categories = _context.Categories.Include(x => x.Products).ToList();
            return View(categories);
        }
    }
}
