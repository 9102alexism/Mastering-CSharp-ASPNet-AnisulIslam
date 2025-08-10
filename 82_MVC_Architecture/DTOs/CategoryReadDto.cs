namespace DTOs;

public class CategoryReadDto {
    public Guid CategoryId { get; set; }
    public string? Name { get; set; }
    public string Description { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}