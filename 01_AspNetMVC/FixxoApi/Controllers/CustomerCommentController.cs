using Api.Models.DTOs;
using Api.Repositories;
using Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomerCommentController : ControllerBase
{
    public readonly CustomerCommentRepository _commentRepo;

    public CustomerCommentController(CustomerCommentRepository commentService)
    {
        _commentRepo = commentService;
    }

    [HttpPost]
    [Route("AddComment")]
    public async Task<IActionResult> AddAsync(CustomerCommentDTO model)
    {
        if (ModelState.IsValid)
        {
            await _commentRepo.AddAsync(model);
            return Created("", null);
        }

        return BadRequest();
    }
}
