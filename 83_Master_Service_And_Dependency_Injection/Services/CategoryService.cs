using Models;
using DTOs;
using Repositories;
using AutoMapper;
using Data;
using Controllers;
using Enums;
using Helpers;
using Microsoft.EntityFrameworkCore;
namespace Services;

public class CategoryService : ICategoryService {
    // private static readonly List<Category> _categories = new List<Category>();
    private readonly AppDbContext _appDbContext;
    private readonly IMapper _mapper;

    public CategoryService(AppDbContext appDbContext, IMapper mapper) {
        _appDbContext = appDbContext;
        _mapper = mapper;
    }

    // public List<CategoryReadDto> GetAllCategories() {
    //     // return _categories.Select(c => new CategoryReadDto() {
    //     //     CategoryId = c.CategoryId,
    //     //     Name = c.Name,
    //     //     Description = c.Description,
    //     //     CreatedAt = c.CreatedAt
    //     // }).ToList();

    //     return _mapper.Map<List<CategoryReadDto>>(_categories);
    // }

    public async Task<PaginatedResult<CategoryReadDto>> GetAllCategories(QueryParameters queryParameters) {
        // var categories = await _appDbContext.Categories.ToListAsync();

        // return _mapper.Map<List<CategoryReadDto>>(categories);

        var pageNumber = queryParameters.PageNumber;
        var pageSize = queryParameters.PageSize;
        var search = queryParameters.Search;
        var sortOrder = queryParameters.SortOrder;

        IQueryable<Category> query = _appDbContext.Categories;
        
        // if(!string.IsNullOrEmpty(search)) query = query.Where(q => q.Name.Contains(search) || q.Description.Contains(search));
        if(!string.IsNullOrEmpty(search)) query = query.Where(q => EF.Functions.ILike(q.Name ?? "", $"%{search.Trim()}%") || EF.Functions.ILike(q.Description ?? "", $"%{search.Trim()}%"));

        if(!string.IsNullOrEmpty(sortOrder) && Enum.TryParse<SortOrder>(sortOrder.Trim(), true, out var parsedSortOrder)) {
            switch(parsedSortOrder) {
                case SortOrder.NameAsc:
                    query = query.OrderBy(q => q.Name);
                    break;
                case SortOrder.NameDesc:
                    query = query.OrderByDescending(q => q.Name);
                    break;
                case SortOrder.CreatedAtAsc:
                    query = query.OrderBy(q => q.CreatedAt);
                    break;
                case SortOrder.CreatedAtDesc:
                    query = query.OrderByDescending(q => q.CreatedAt);
                    break;
                default:
                    query = query.OrderBy(q => q.Name);
                    break;
            }
        }
        
        var totalCount = await query.CountAsync();
        var items = await query.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();
        var results = _mapper.Map<List<CategoryReadDto>>(items);
        
        return new PaginatedResult<CategoryReadDto>() {
            Items = results,
            TotalCount = totalCount,
            PageNumber = pageNumber,
            PageSize = pageSize
        };
    }

    // public CategoryReadDto? GetCategoriesById(Guid categoryId) {
    //     var foundCategory = _categories.FirstOrDefault(c => c.CategoryId == categoryId);

    //     // return foundCategory == null ? null : new CategoryReadDto() {
    //     //     CategoryId = foundCategory.CategoryId,
    //     //     Name = foundCategory.Name,
    //     //     Description = foundCategory.Description,
    //     //     CreatedAt = foundCategory.CreatedAt
    //     // };

    //     return foundCategory == null ? null : _mapper.Map<CategoryReadDto>(foundCategory);
    // }

    public async Task<CategoryReadDto?> GetCategoriesById(Guid categoryId) {
        var foundCategory = await _appDbContext.Categories.FindAsync(categoryId);

        return foundCategory == null ? null : _mapper.Map<CategoryReadDto>(foundCategory);
    }

    // public CategoryReadDto CreateCategory(CategoryCreateDto categoryData) {
    //     // var newCategory = new Category() {
    //     //     CategoryId = Guid.NewGuid(),
    //     //     Name = categoryData.Name,
    //     //     CreatedAt = DateTime.UtcNow
    //     // };

    //     var newCategory = _mapper.Map<Category>(categoryData);
    //     newCategory.CategoryId = Guid.NewGuid();
    //     newCategory.CreatedAt = DateTime.UtcNow;
    //     newCategory.Description = categoryData.Description ?? newCategory.Description;

    //     _categories.Add(newCategory);

    //     // return new CategoryReadDto() {
    //     //     CategoryId = newCategory.CategoryId,
    //     //     Name = newCategory.Name,
    //     //     Description = newCategory.Description,
    //     //     CreatedAt = newCategory.CreatedAt
    //     // };

    //     return _mapper.Map<CategoryReadDto>(newCategory);
    // }

    public async Task<CategoryReadDto> CreateCategory(CategoryCreateDto categoryData) {
        var newCategory = _mapper.Map<Category>(categoryData);
        newCategory.CategoryId = Guid.NewGuid();
        newCategory.CreatedAt = DateTime.UtcNow;
        newCategory.Description = categoryData.Description ?? newCategory.Description;

        await _appDbContext.Categories.AddAsync(newCategory);
        await _appDbContext.SaveChangesAsync();

        return _mapper.Map<CategoryReadDto>(newCategory);
    }

    // public bool UpdateCategoryById(Guid categoryId, CategoryUpdateDto categoryData) {
    //     var foundCategory = _categories.FirstOrDefault(c => c.CategoryId == categoryId);

    //     if(foundCategory == null) {
    //         return false;
    //     }
        
    //     // _mapper.Map(categoryData, foundCategory);
    //     foundCategory.Name = categoryData.Name;
    //     foundCategory.Description = categoryData.Description ?? foundCategory.Description;
        
    //     return true;
    // }

    public async Task<bool> UpdateCategoryById(Guid categoryId, CategoryUpdateDto categoryData) {
        var foundCategory = await _appDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == categoryId);

        if(foundCategory == null) {
            return false;
        }
        
        // _mapper.Map(categoryData, foundCategory);
        foundCategory.Name = categoryData.Name;
        foundCategory.Description = categoryData.Description ?? foundCategory.Description;
        _appDbContext.Categories.Update(foundCategory);
        await _appDbContext.SaveChangesAsync();
        
        return true;
    }

    // public bool DeleteCategoryById(Guid categoryId) {
    //     var foundCategory = _categories.FirstOrDefault(c => c.CategoryId == categoryId);

    //     if(foundCategory == null) {
    //         return false;
    //     }

    //     _categories.Remove(foundCategory);
        
    //     return true;
    // }

    public async Task<bool> DeleteCategoryById(Guid categoryId) {
        var foundCategory = await _appDbContext.Categories.FirstOrDefaultAsync(c => c.CategoryId == categoryId);

        if(foundCategory == null) {
            return false;
        }

        _appDbContext.Categories.Remove(foundCategory);
        await _appDbContext.SaveChangesAsync();
        
        return true;
    }
}