using Api.Models.DTOs;
using Api.Models.Entities;
using Api.Repositories;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("All")]
        public async Task<IActionResult> GetAllAync()
        {
            return Ok(await _productService.GetAllAsync());
        }

        [HttpPost]
        [Route("CreateNew")]
        public async Task<IActionResult> AddAsync(NewProductDTO model)
        {
            if (ModelState.IsValid)
            {
                if (await _productService.AddAsync(model))
                    return Created("", null);
                else return BadRequest();
            }
            return BadRequest();
        }
    }
}
