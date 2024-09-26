using Microsoft.AspNetCore.Mvc;
using MyFood.com.Context;

namespace MyFood.com.Controllers
{
    public class DefaultController : Controller
    {
        private readonly AppDBContext _dbContext;

        public DefaultController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            ViewBag.category = _dbContext.Category.ToList();
            var values = _dbContext.Menu.ToList();
            return View(values);
        }

    }
}
