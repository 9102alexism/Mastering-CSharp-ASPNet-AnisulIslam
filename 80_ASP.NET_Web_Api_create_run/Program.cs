var builder = WebApplication.CreateBuilder();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// REST API => GET, POST, PUT, DELETE

app.MapGet("/", () => "Api is working fine.");

app.MapGet("/hello", () => {
    var response = new {
        message = "this is a json object",
        success = true
    };
    return Results.Ok(response); // 200
});

app.MapGet("/html", () => {
    return Results.Content("<h1> Hello world </h1>", "text/html"); // 200
});

app.MapGet("/products", () => {
    var products = new List<Product>() {
        new Product("Samsung s20", 1250),
        new Product("Apple iPhone 16", 1367)
    };
    return Results.Ok(products);
});

app.MapPost("/hello", () => {
    return Results.Created(); // 201
});

app.MapPut("/hello", () => {
    return Results.NoContent(); // 204
});

app.MapDelete("/hello", () => {
    return Results.NoContent(); // 204
});

List<Category> categories = new List<Category>();

app.MapGet("/api/categories", () => {
    return Results.Ok(categories);
});

app.MapPost("/api/categories", () => {
    var newCategory = new Category() {
        // CategoryId = Guid.NewGuid(),
        CategoryId = Guid.Parse("c825666b-2021-43eb-9717-c62fb6c31c8e"),
        Name = "Electronics",
        Description = "Devices and gadgets including phones, laptops, and other electronic equipment.",
        CreatedAt = DateTime.UtcNow
    };
    categories.Add(newCategory);
    return Results.Created($"/api/categories/{newCategory.CategoryId}", newCategory);
});

app.MapDelete("/api/categories", () => {
    var foundCategory = categories.FirstOrDefault(category => category.CategoryId == Guid.Parse("c825666b-2021-43eb-9717-c62fb6c31c8e"));
    if(foundCategory == null) {
        return Results.NotFound("Category with this id doesn't exist.");
    }
    categories.Remove(foundCategory);
    return Results.NoContent();
});

app.MapPut("/api/categories", () => {
    var foundCategory = categories.FirstOrDefault(category => category.CategoryId == Guid.Parse("c825666b-2021-43eb-9717-c62fb6c31c8e"));
    if(foundCategory == null) {
        return Results.NotFound("Category with this id doesn't exist.");
    }
    foundCategory.Name = "Kitchen";
    foundCategory.Description = "Stoves, Pan and many more.";
    return Results.NoContent();
});

app.Run();

public record Product(string Name, decimal Price);

public record Category {
    public Guid CategoryId { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }
}