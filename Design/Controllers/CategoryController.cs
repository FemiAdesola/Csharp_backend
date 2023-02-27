namespace Design.Controllers;

using Microsoft.AspNetCore.Mvc;
using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

public class CategoryController : ApiControllerBase
{
    private readonly ILogger<CategoryController> _logger;
    private readonly ICrudService<Category, CategoryRequest> _service;

    public User? Admin { get; }

    //  dependency injection
    public  CategoryController(ILogger<CategoryController> logger, ICrudService<Category, CategoryRequest> service)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _service = service;
    }

    // POST /api/v1/categories
    [HttpPost]
    public async Task<IActionResult> CreateCategoryAsync(CategoryRequest request)
    {
        var category = await _service.CreateAsync(request);
        if (category is null)
        {
            return BadRequest("Something is wrong with the payload");
        }
        return Ok(category);
    }

    // GET /api/v1/categories
    [HttpGet("")]
    public async Task<ActionResult<IEnumerable<Category>>> GetAllCategoryAsync()
    {
        try
        {
            var categories = await _service.GetAllAsync();
            return Ok(categories);

        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the .....");
        }
    }

    // GET /api/v1/categories/{:id}
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Category>> GetCategoryAsync(int id)
    {
        
        try
        {
            var result = await _service.GetAsync(id);
            if (result == null)
            {
                return NotFound("Category is not found");
            }

            return result;
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error retrieving data from the ....");
        }
        

    }

    // PUT /api/v1/categories/{:id}
    [HttpPut("{id:int}")]
    public async Task<ActionResult<Category>> UpdateCategoryAsync(int id, CategoryRequest request)
    {
        try
        {
            var category = await _service.UpdateAsync(id, request);
            if (category is null)
            {
                return NotFound("Category is not found");
            }
            return Ok(category);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error updating data");
        }
    }

    // DELETE /api/v1/categories/{:id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCategoryAsync(int id)
    {
        try 
        {
            var deleteCategory = await _service.DeleteAsync(id);
            if (!deleteCategory)
            {
                return NotFound($"Category with Id = {id} not found");
            }
            return Ok(new { Message = ($"Category with Id = {id} is deleted ")});
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
                "Error deleting data");
        }
    }

    // GET /api/v1/categories/{:id}/products
    public async Task<IEnumerable<Category>> GetProductByCategoryAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }
}