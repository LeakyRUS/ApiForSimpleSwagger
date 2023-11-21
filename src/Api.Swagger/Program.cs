using Api.Swagger.Services;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Api.Swagger",
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "Api.Swagger.xml");
    c.IncludeXmlComments(filePath);
});

builder.Services.AddSingleton<ICountService, CountIncrementService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapDefaultControllerRoute();

app.Run();
