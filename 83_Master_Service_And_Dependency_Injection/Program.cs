using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Controllers;
using Services;
using Repositories;
using Data;

var builder = WebApplication.CreateBuilder();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(cfg => {}, typeof(Program));
builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// builder.Services.AddSingleton<CategoryService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddControllers();
builder.Services.Configure<ApiBehaviorOptions>(options => {
    options.InvalidModelStateResponseFactory = context => {
        var errors = context.ModelState
        .Where(e => e.Value != null && e.Value.Errors.Count > 0)
        .SelectMany(e => e.Value!.Errors.Select(x => x.ErrorMessage));
        
        return new BadRequestObjectResult(ApiResponse<object>.ErrorResponse(errors.ToList(), 400, "Validation failed"));
    };
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

// Program -> Controllers -> Repositories -> Services -> Helpers, Profiles, Enums -> DTOs -> Models -> Data
// dotnet ef migrations add InitialCreate
// dotnet ef database update
// CREATE EXTENSION IF NOT EXISTS "uuid-ossp"