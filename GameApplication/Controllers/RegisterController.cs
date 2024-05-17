using GameApplication.Models;
using GameApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameApplication.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessRegistration(UserModel user)
        {
            SecurityService securityService = new SecurityService();

            if (securityService.IsValid(user))
                return View("RegisterSuccess", user);
            else
                return View("RegisterFailure", user);
        }
    }
}
