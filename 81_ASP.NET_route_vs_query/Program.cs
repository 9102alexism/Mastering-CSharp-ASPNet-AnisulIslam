var builder = WebApplication.CreateBuilder();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// endpoint starts here
List<Category> categories = new List<Category>();

// model binding = route, query string, request body
app.MapGet("/api/categories", (string? searchValue) => {
    if(searchValue != null) {
        var searchCategories = categories.Where(c => !string.IsNullOrWhiteSpace(c.Name) && c.Name.ToLower().Contains(searchValue.ToLower()));
        return Results.Ok(searchCategories);
    }
    return Results.Ok(categories);
});

app.MapPost("/api/categories", (Category categoryData) => {
    if(string.IsNullOrWhiteSpace(categoryData.Name)) {
        return Results.BadRequest("Category name is required.");
    }
    var category = new Category() {
        CategoryId = Guid.NewGuid(),
        Name = categoryData.Name,
        Description = categoryData.Description,
        CreatedAt = DateTime.UtcNow
    };
    categories.Add(category);
    return Results.Created($"/api/categories/{category.CategoryId}", category);
});

app.MapPut("/api/categories/{categoryId}", (Guid categoryId, Category? categoryData) => {
    if(categoryData == null) {
        return Results.BadRequest("Category data is missing.");
    }
    var foundCategory = categories.FirstOrDefault(category => category.CategoryId == categoryId);
    if(foundCategory == null) {
        return Results.NotFound("Category with this id doesn't exist.");
    }
    foundCategory.Name = string.IsNullOrWhiteSpace(categoryData.Name) ? foundCategory.Name : categoryData.Name;
    foundCategory.Description = categoryData.Description ?? foundCategory.Description;
    return Results.NoContent();
});

// route constraint = {categoryId:guid}
app.MapDelete("/api/categories/{categoryId:guid}", (Guid categoryId) => {
    var foundCategory = categories.FirstOrDefault(category => category.CategoryId == categoryId);
    if(foundCategory == null) {
        return Results.NotFound("Category with this id doesn't exist.");
    }
    categories.Remove(foundCategory);
    return Results.NoContent();
});

app.Run();

public record Category {
    public Guid CategoryId { get; set; }
    public string? Name { get; set; }
    public string Description { get; set; } = "";
    public DateTime CreatedAt { get; set; }
}