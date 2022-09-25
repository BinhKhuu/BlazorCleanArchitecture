using BlazorProducts.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("ProductsDB")));
var app = builder.Build();

app.Run();
