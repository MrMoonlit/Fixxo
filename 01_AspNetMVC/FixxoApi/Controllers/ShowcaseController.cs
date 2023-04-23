using Api.Filters;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [UseApiKey]
    [Route("api/[controller]")]
    [ApiController]
    public class ShowcaseController : ControllerBase
    {
        private readonly ShowcaseService _showcaseService;

        public ShowcaseController(ShowcaseService showcaseService)
        {
            _showcaseService = showcaseService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<IActionResult> Get()
        {
            return Ok(await _showcaseService.GetAsync());
        }

    }
}
