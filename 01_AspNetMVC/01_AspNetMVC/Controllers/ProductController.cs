using Microsoft.AspNetCore.Mvc;

namespace _01_AspNetMVC.Controllers;

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
