using Microsoft.AspNetCore.Mvc;
using Models;
using DTOs;
namespace Controllers;

/*
    Results.Ok() -> 200
    Results.Content() -> 200
    Results.Created() -> 201
    Results.NoContent() -> 204
    Results.BadRequest() -> 400
    Results.NotFound() -> 404
*/

[ApiController]
[Route("api/categories")]
public class CategoryController : ControllerBase
{
    private static List<Category> categories = new List<Category>();

    [HttpGet]
    public IActionResult GetCategories([FromQuery] string? searchValue) {
        // if(!string.IsNullOrEmpty(searchValue)) {
        //     var searchedCategories = categories.Where(c => !string.IsNullOrWhiteSpace(c.Name) && c.Name.ToLower().Contains(searchValue.ToLower()));
        //     return Ok(searchedCategories);
        // }

        if(!string.IsNullOrEmpty(searchValue)) {
            var searchedCategories = categories
            .Where(c => !string.IsNullOrWhiteSpace(c.Name) && c.Name.ToLower().Contains(searchValue.ToLower()))
            .Select(c => new CategoryReadDto() {
                CategoryId = c.CategoryId,
                Name = c.Name,
                Description = c.Description,
                CreatedAt = c.CreatedAt
            });
            
            return Ok(ApiResponse<List<CategoryReadDto>>.SuccessResponse(searchedCategories.ToList(), 200, "Categories returned successfully"));
        }

        var categoryList = categories.Select(c => new CategoryReadDto() {
            CategoryId = c.CategoryId,
            Name = c.Name,
            Description = c.Description,
            CreatedAt = c.CreatedAt
        });

        // return Ok(new ApiResponse<List<CategoryReadDto>>(categoryList.ToList(), 200, "Categories returned successfully"));

        // return Ok(ApiResponse<IEnumerable<CategoryReadDto>>.SuccessResponse(categoryList, 200, "Categories returned successfully"));

        return Ok(ApiResponse<List<CategoryReadDto>>.SuccessResponse(categoryList.ToList(), 200, "Categories returned successfully"));
    }

    [HttpGet("{categoryId:guid}")]
    public IActionResult GetCategoriesById(Guid categoryId) {
        var foundCategory = categories.FirstOrDefault(c => c.CategoryId == categoryId);
        if(foundCategory == null) {
            return NotFound(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category with this id doesn't exist."
                },
                400,
                "Validation failed"
            ));
        }

        var categoryReadDto = new CategoryReadDto() {
            CategoryId = foundCategory.CategoryId,
            Name = foundCategory.Name,
            Description = foundCategory.Description,
            CreatedAt = foundCategory.CreatedAt
        };

        return Ok(ApiResponse<CategoryReadDto>.SuccessResponse(categoryReadDto, 200, "Categories returned successfully"));
    }

    [HttpPost]
    public IActionResult CreateCategory([FromBody] CategoryCreateDto categoryData) {
        // if(string.IsNullOrWhiteSpace(categoryData.Name)) {
        //     return BadRequest("Category name is required.");
        // }
        // if(categoryData.Name.Length < 2) {
        //     return BadRequest("Category name must be at least 2 characters long.");
        // }

        // if(!ModelState.IsValid) {
        //     var errors = ModelState
        //     .Where(e => e.Value != null && e.Value.Errors.Count > 0)
        //     .Select(e => new {
        //         Field = e.Key,
        //         Message = e.Value!.Errors.Select(x => x.ErrorMessage)
        //     });

        //     var errorString = string.Join(
        //         "; ",
        //         errors.Select(e => $"{e.Field}: {string.Join(
        //             ", ",
        //             e.Message
        //         )}")
        //     );

        //     return BadRequest(errorString);
        // }

        var newCategory = new Category() {
            CategoryId = Guid.NewGuid(),
            Name = categoryData.Name,
            CreatedAt = DateTime.UtcNow
        };
        newCategory.Description = categoryData.Description ?? newCategory.Description;

        categories.Add(newCategory);

        var categoryReadDto = new CategoryReadDto() {
            CategoryId = newCategory.CategoryId,
            Name = newCategory.Name,
            Description = newCategory.Description,
            CreatedAt = newCategory.CreatedAt
        };

        return Created($"/api/categories/{newCategory.CategoryId}", ApiResponse<CategoryReadDto>.SuccessResponse(categoryReadDto, 201, "Category created successfully"));
    }

    [HttpPut("{categoryId:guid}")]
    public IActionResult UpdateCategoryById(Guid categoryId, [FromBody] CategoryUpdateDto? categoryData) {
        if(categoryData == null) {
            return BadRequest("Category data is missing.");
        }

        var foundCategory = categories.FirstOrDefault(c => c.CategoryId == categoryId);
        if(foundCategory == null) {
            // return NotFound("Category with this id doesn't exist.");

            return NotFound(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category with this id doesn't exist."
                },
                400,
                "Validation failed"
            ));
        }

        if(!string.IsNullOrWhiteSpace(categoryData.Name)) {
            // if(categoryData.Name.Length < 2) {
            //     return BadRequest("Category name must be at least 2 characters long.");
            // }
            foundCategory.Name = categoryData.Name;
        }
        else if(categoryData.Name != null) {
            // return BadRequest("Category name can't be empty.");
            return BadRequest(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category name can't be whitespace."
                },
                400,
                "Validation failed"
            ));
        }
        foundCategory.Description = categoryData.Description ?? foundCategory.Description;

        // return NoContent();

        return Ok(ApiResponse<object>.SuccessResponse(null, 204, "Category updated successfully"));
    }

    [HttpDelete("{categoryId:guid}")]
    public IActionResult DeleteCategoryById(Guid categoryId) {
        var foundCategory = categories.FirstOrDefault(c => c.CategoryId == categoryId);
        if(foundCategory == null) {
            // return NotFound("Category with this id doesn't exist.");
            return NotFound(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category with this id doesn't exist."
                },
                400,
                "Validation failed"
            ));
        }

        categories.Remove(foundCategory);

        // return NoContent();

        return Ok(ApiResponse<object>.SuccessResponse(null, 204, "Category deleted successfully"));
    }
}