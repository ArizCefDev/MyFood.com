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
            var x = _dbContext.Category.ToList();
            return View(x);
        }
    }
}
