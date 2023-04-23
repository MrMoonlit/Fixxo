using _01_AspNetMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace _01_AspNetMVC.Controllers;

public class ProductController : Controller
{
    private readonly ProductService _productService;

    public ProductController(ProductService productService)
    {
        _productService = productService;
    }

    public async Task<IActionResult> Index()
    {
        var productList = await _productService.GetAllAsync();
        return View(productList);
    }

    public async Task<IActionResult> Details(int id)
    {
        var product = await _productService.GetByIdAsync(id);
      
        return View(product);
    }
}
