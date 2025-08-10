using Microsoft.AspNetCore.Mvc;
using Repositories;
using DTOs;
using Helpers;
namespace Controllers;

[ApiController]
[Route("v1/api/categories")]
public class CategoryController : ControllerBase
{
    // private CategoryService _categoryService;
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService) {
        _categoryService = categoryService;
    }

    // [HttpGet]
    // public IActionResult GetCategories() {
    //     var categoryList = _categoryService.GetAllCategories();

    //     return Ok(ApiResponse<List<CategoryReadDto>>.SuccessResponse(categoryList, 200, "Categories returned successfully"));
    // }

    [HttpGet]
    public async Task<IActionResult> GetCategories([FromQuery] QueryParameters queryParameters) {
        queryParameters.Validate();
        var categoryList = await _categoryService.GetAllCategories(queryParameters);

        return Ok(ApiResponse<PaginatedResult<CategoryReadDto>>.SuccessResponse(categoryList, 200, "Categories returned successfully"));
    }

    // [HttpGet("{categoryId:guid}")]
    // public IActionResult GetCategoriesById(Guid categoryId) {
    //     var foundCategory = _categoryService.GetCategoriesById(categoryId);
    //     if(foundCategory == null) {
    //         return NotFound(ApiResponse<object>.ErrorResponse(
    //             new List<string>() {
    //                 "Category with this id doesn't exist."
    //             },
    //             400,
    //             "Validation failed"
    //         ));
    //     }

    //     return Ok(ApiResponse<CategoryReadDto>.SuccessResponse(foundCategory, 200, "Categories returned successfully"));
    // }

    [HttpGet("{categoryId:guid}")]
    public async Task<IActionResult> GetCategoriesById(Guid categoryId) {
        var foundCategory = await _categoryService.GetCategoriesById(categoryId);
        if(foundCategory == null) {
            return NotFound(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category with this id doesn't exist."
                },
                400,
                "Validation failed"
            ));
        }

        return Ok(ApiResponse<CategoryReadDto>.SuccessResponse(foundCategory, 200, "Categories returned successfully"));
    }

    // [HttpPost]
    // public IActionResult CreateCategory([FromBody] CategoryCreateDto categoryData) {
    //     var newCategory = _categoryService.CreateCategory(categoryData);

    //     return Created($"/v1/api/categories/{newCategory.CategoryId}", ApiResponse<CategoryReadDto>.SuccessResponse(newCategory, 201, "Category created successfully"));
    // }

    [HttpPost]
    public async Task<IActionResult> CreateCategory([FromBody] CategoryCreateDto categoryData) {
        var newCategory = await _categoryService.CreateCategory(categoryData);

        return Created($"/v1/api/categories/{newCategory.CategoryId}", ApiResponse<CategoryReadDto>.SuccessResponse(newCategory, 201, "Category created successfully"));
    }

    // [HttpPut("{categoryId:guid}")]
    // public IActionResult UpdateCategoryById(Guid categoryId, [FromBody] CategoryUpdateDto? categoryData) {
    //     if(categoryData == null) {
    //         return BadRequest(ApiResponse<object>.ErrorResponse(
    //             new List<string>() {
    //                 "Category data is missing."
    //             },
    //             400,
    //             "Validation failed"
    //         ));
    //     }
    //     if(string.IsNullOrWhiteSpace(categoryData.Name)) {
    //         if(categoryData.Name != null) {
    //             return BadRequest(ApiResponse<object>.ErrorResponse(
    //                 new List<string>() {
    //                     "Category name can't be whitespace."
    //                 },
    //                 400,
    //                 "Validation failed"
    //             ));
    //         }
    //     }

    //     var foundCategory = _categoryService.UpdateCategoryById(categoryId, categoryData);
    //     if(foundCategory == false) {
    //         return NotFound(ApiResponse<object>.ErrorResponse(
    //             new List<string>() {
    //                 "Category with this id doesn't exist."
    //             },
    //             400,
    //             "Validation failed"
    //         ));
    //     }

    //     return Ok(ApiResponse<object>.SuccessResponse(null, 204, "Category updated successfully"));
    // }

    [HttpPut("{categoryId:guid}")]
    public async Task<IActionResult> UpdateCategoryById(Guid categoryId, [FromBody] CategoryUpdateDto? categoryData) {
        if(categoryData == null) {
            return BadRequest(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category data is missing."
                },
                400,
                "Validation failed"
            ));
        }
        if(string.IsNullOrWhiteSpace(categoryData.Name)) {
            if(categoryData.Name != null) {
                return BadRequest(ApiResponse<object>.ErrorResponse(
                    new List<string>() {
                        "Category name can't be whitespace."
                    },
                    400,
                    "Validation failed"
                ));
            }
        }

        var foundCategory = await _categoryService.UpdateCategoryById(categoryId, categoryData);
        if(foundCategory == false) {
            return NotFound(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category with this id doesn't exist."
                },
                400,
                "Validation failed"
            ));
        }

        return Ok(ApiResponse<object>.SuccessResponse(null, 204, "Category updated successfully"));
    }

    // [HttpDelete("{categoryId:guid}")]
    // public IActionResult DeleteCategoryById(Guid categoryId) {
    //     var foundCategory = _categoryService.DeleteCategoryById(categoryId);
    //     if(foundCategory == false) {
    //         return NotFound(ApiResponse<object>.ErrorResponse(
    //             new List<string>() {
    //                 "Category with this id doesn't exist."
    //             },
    //             400,
    //             "Validation failed"
    //         ));
    //     }

    //     return Ok(ApiResponse<object>.SuccessResponse(null, 204, "Category deleted successfully"));
    // }

    [HttpDelete("{categoryId:guid}")]
    public async Task<IActionResult> DeleteCategoryById(Guid categoryId) {
        var foundCategory = await _categoryService.DeleteCategoryById(categoryId);
        if(foundCategory == false) {
            return NotFound(ApiResponse<object>.ErrorResponse(
                new List<string>() {
                    "Category with this id doesn't exist."
                },
                400,
                "Validation failed"
            ));
        }

        return Ok(ApiResponse<object>.SuccessResponse(null, 204, "Category deleted successfully"));
    }
}