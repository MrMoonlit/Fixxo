using Microsoft.AspNetCore.Mvc;

namespace _01_AspNetMVC.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateAccount()
        {
            return View();
        }
    }
}
