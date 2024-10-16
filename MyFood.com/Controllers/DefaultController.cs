using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public IActionResult Index(string searchString)
        {
            ViewBag.category = _dbContext.Category.ToList();
            ViewBag.social=_dbContext.Social.ToList();

            var values = _dbContext.Menu.ToList();


            if (!string.IsNullOrEmpty(searchString))
            {
                values = (List<Entity.Menu>)values.Where(m => m.Title.Contains(searchString));
            }

            //var values = _dbContext.Menu.ToList();
            return View(values);
        }

        public IActionResult About()
        {
            ViewBag.category = _dbContext.Category.ToList();
            ViewBag.social = _dbContext.Social.ToList();

            var values = _dbContext.About.ToList();
            return View(values);
        }

    }
}
