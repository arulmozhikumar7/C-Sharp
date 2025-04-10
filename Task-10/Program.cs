using Task_10.Data;
using Task_10.Services;
using Microsoft.EntityFrameworkCore;
using Task_10.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add EF Core with InMemory DB
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseInMemoryDatabase("ProductDb"));

// Add service
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseMiddleware<RequestResponseLoggingMiddleware>();
app.UseAuthorization();
app.MapControllers();
app.Run();
