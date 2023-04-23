using Api.Filters;
using Api.Models.DTOs;
using Api.Models.Entities;
using Api.Repositories;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [UseApiKey]
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
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _productService.GetAllAsync());
        }

        [HttpGet]
        [Route("Category")]
        public async Task<IActionResult> GetByCategory(string category)
        {
            return Ok(await _productService.GetByCategoryAsync(category));
        }

        [HttpGet]
        [Route("Tag")]
        public async Task<IActionResult> GetByTag(string tag)
        {
            return Ok(await _productService.GetByTagAsync(tag));
        }

        [HttpGet]
        [Route("Id")]
        public async Task<IActionResult> GetById(int tag)
        {
            return Ok(await _productService.GetByIdAsync(tag));
        }

        [HttpPost]
        [Route("CreateNew")]
        public async Task<IActionResult> AddItem(NewProductDTO model)
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
