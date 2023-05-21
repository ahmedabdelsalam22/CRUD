using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories.ToList();    
            return View(categories);
        }

        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category obj) 
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else 
            {
                return View();
            }
          
        }
    }
}
