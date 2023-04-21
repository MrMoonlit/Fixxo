using _01_AspNetMVC.models.DTO;
using _01_AspNetMVC.Services;
using _01_AspNetMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace _01_AspNetMVC.Controllers;

public class ContactController : Controller
{
    private readonly CustomerSupportServices _services;

    public ContactController(CustomerSupportServices services)
    {
        _services = services;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(ContactFormViewModel model)
    {
        if (ModelState.IsValid)
        {
            var result = await _services.SaveCommentAsync(model);

            if (result.StatusCode == System.Net.HttpStatusCode.Created)
            {
                ModelState.Clear();
                model = new ContactFormViewModel()
                {
                    ConfirmationMsg = "Thank you for your message. Our customer support will hopefully be responive within a fortnight"
                };
                return View(model);
            }
            
            model.ConfirmationMsg = "Oops, something went bellyup here. Please try again, if this happens again the server might have deemed your comment as trash.";
            return View(model);
        }
        
        return View(model);
    }
}

