using Microsoft.AspNetCore.Mvc;
using MyFood.com.Context;
using MyFood.com.Entity;

namespace MyFood.com.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDBContext _dbContext;

        public AdminController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var x = _dbContext.Category.ToList();
            return View(x);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category p)
        {
            _dbContext.Category.Add(p);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult CategoryDelete(int id)
        {
            var c = _dbContext.Category.Find(id);
            _dbContext.Category.Remove(c);
            _dbContext.SaveChanges();
            return RedirectToAction("Index", "Admin");
        }

		[HttpGet]
		public IActionResult CategoryUpdate(int id)
		{
			var c = _dbContext.Category.Find(id);
			return View(c);
		}

		[HttpPost]
		public IActionResult CategoryUpdate(Category p)
		{
			_dbContext.Category.Update(p);
			_dbContext.SaveChanges();
			return RedirectToAction("Index", "Admin");
		}

		public IActionResult Menu()
        {
            var x = _dbContext.Menu.ToList();
            return View(x);
        }

       

    }
}
