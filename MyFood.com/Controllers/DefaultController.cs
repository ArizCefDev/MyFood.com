using Microsoft.AspNetCore.Mvc;

namespace MyFood.com.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
