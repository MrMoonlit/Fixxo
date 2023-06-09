﻿using _01_AspNetMVC.Services;
using _01_AspNetMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _01_AspNetMVC.Controllers;

public class HomeController : Controller
{
    private readonly ProductService _productService;
    private readonly ShowcaseService _showcaseService;

    public HomeController(ProductService productService, ShowcaseService showcaseService)
    {
        _productService = productService;
        _showcaseService = showcaseService;
    }

    public async Task<IActionResult> Index()
    {
        var showcase = await _showcaseService.GetLatestShowcaseAsync();
        var featuredProducts = await _productService.GetByTagAsync("Featured");
        featuredProducts = featuredProducts.Take(8).ToList();
        var newProducts = await _productService.GetByTagAsync("New");
        newProducts = newProducts.Take(6).ToList();
        var popularProducts = await _productService.GetByTagAsync("Popular");
        popularProducts = popularProducts.Take(6).ToList();
        HomeViewViewModel model = new HomeViewViewModel
        {
            ShowcaseDTO = showcase,
            Featured = featuredProducts,
            New = newProducts,
            Popular = popularProducts,
        };

        return View(model);
    }
}
