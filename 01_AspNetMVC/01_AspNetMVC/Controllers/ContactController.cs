using Microsoft.AspNetCore.Mvc;

namespace _01_AspNetMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
