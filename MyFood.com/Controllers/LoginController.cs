using Humanizer;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFood.com.Context;
using MyFood.com.Entity;
using MyFood.com.Helper;
using MyFood.com.Helper.Constants;

namespace MyFood.com.Controllers
{
	public class LoginController : Controller
	{
        private readonly AppDBContext _dbContext;

        public LoginController(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        //[Authorize(Roles =RoleKeywords.AdminRole)]
        [HttpGet]
        public IActionResult SignIn()
		{
			return View();
		}

        [HttpPost]
        public IActionResult SignIn(Userr p)
        {
            var res = _dbContext.Userr.Where(x => x.UserName == p.UserName)
                .Where(x => x.Password == p.Password);

            if (res.Any())
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.error = "Username or Password incorrect";
            }
            return View(p);
        }

        [HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}

        [HttpPost]
        public IActionResult SignUp(Userr p)
        {
            p.Salt = "X";
            p.PasswordHash = "yy";
            p.ConfimPassword = "k";
            p.RoleName = "Admin";
            //ViewBag.i = "hd";
            _dbContext.Userr.Add(p);
            _dbContext.SaveChanges();
            return RedirectToAction("SignIn", "Login");
        }

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("SignIn", "Login");
        }


    }
}
