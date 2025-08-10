using DTOs;
using Controllers;
using Helpers;
namespace Repositories;

// public interface ICategoryService {
//     List<CategoryReadDto> GetAllCategories();
//     CategoryReadDto? GetCategoriesById(Guid categoryId);
//     CategoryReadDto CreateCategory(CategoryCreateDto categoryData);
//     bool UpdateCategoryById(Guid categoryId, CategoryUpdateDto categoryData);
//     bool DeleteCategoryById(Guid categoryId);
// }

public interface ICategoryService {
    Task<PaginatedResult<CategoryReadDto>> GetAllCategories(QueryParameters queryParameters);
    Task<CategoryReadDto?> GetCategoriesById(Guid categoryId);
    Task<CategoryReadDto> CreateCategory(CategoryCreateDto categoryData);
    Task<bool> UpdateCategoryById(Guid categoryId, CategoryUpdateDto categoryData);
    Task<bool> DeleteCategoryById(Guid categoryId);
}