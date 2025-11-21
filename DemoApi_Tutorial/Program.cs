using DemoApi_Tutorial.Models;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore;
using Swashbuckle.AspNetCore.SwaggerUI;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SchoolContext>(options =>
    options.UseSqlServer(@"Server=localhost;Database=ColegioDB;User Id=SA;Password=123456Abc;TrustServerCertificate=True;") );

// Add services to the container.
// Registrar controllers
builder.Services.AddControllers();
// Registrar y configurar Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapear controllers
app.MapControllers();

app.Run();