using System.ComponentModel.DataAnnotations;
namespace DTOs;

public class CategoryUpdateDto {
    [StringLength(100, MinimumLength = 2, ErrorMessage = "Category name must be between 2 and 100 characters")]
    public string? Name { get; set; }

    [StringLength(500, MinimumLength = 2, ErrorMessage = "Category description must be between 2 and 100 characters")]
    public string Description { get; set; } = "";
}