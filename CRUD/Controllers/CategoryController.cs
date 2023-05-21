using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category obj) 
        {
             
            if (obj.Name == obj.DisplayOrder.ToString()) // manual validation(custome) .. 
            {
                 ModelState.AddModelError("CustomeError", "Name and DisplayOrder must not be the same");
            }
            if (ModelState.IsValid)
            {
                _context.Categories.Add(obj);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else 
            {
                return View(obj);
            }
          
        }
    }
}
