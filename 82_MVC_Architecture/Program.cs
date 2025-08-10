// Model -> only for database, DTO -> data input, output

using Microsoft.AspNetCore.Mvc;
using Controllers;

var builder = WebApplication.CreateBuilder();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// builder.Services.AddControllers().ConfigureApiBehaviorOptions(
//     options => { options.SuppressModelStateInvalidFilter = true; }
// );

builder.Services.AddControllers();

builder.Services.Configure<ApiBehaviorOptions>(options => {
    options.InvalidModelStateResponseFactory = context => {
        // var errors = context.ModelState
        // .Where(e => e.Value != null && e.Value.Errors.Count > 0)
        // .Select(e => new {
        //     Field = e.Key,
        //     Message = e.Value!.Errors.Select(x => x.ErrorMessage)
        // });

        // var errorString = string.Join(
        //     "; ",
        //     errors.Select(e => $"{e.Field}: {string.Join(
        //         ", ",
        //         e.Message
        //     )}")
        // );

        // return new BadRequestObjectResult(new {
        //     Message = "Validation Failed",
        //     Errors = errorString
        // });

        var errors = context.ModelState
        .Where(e => e.Value != null && e.Value.Errors.Count > 0)
        .SelectMany(e => e.Value!.Errors.Select(x => x.ErrorMessage));

        // return new BadRequestObjectResult(ApiResponse<List<string>>.ErrorResponse(errors.ToList(), 400, "Validation failed"));
        
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