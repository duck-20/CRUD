using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class CRUDController : Controller
    {
        private readonly CrudContext _context;
        public CRUDController(CrudContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Display()
        {
            List <ProductList> products = new List<ProductList>();
            products=_context.ProductLists.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Create(ProductList model)
        {
            if(model != null)
            {
                _context.ProductLists.Add(model);
                
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Display");
        }
    }
}
