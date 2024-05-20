using GameApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameApplication.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogin(UserModel user)
        {
            if (user.Username == "Testing" && user.Password == "password")
            {
                return View("LoginSuccess", user);
            }
            else
            {
                return View("LoginFailure", user);
            }
        }
    }
}
