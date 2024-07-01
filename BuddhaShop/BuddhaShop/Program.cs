using BuddhaShop.AutoMapping;
using BuddhaShop.IRepositories;
using BuddhaShop.IServices;
using BuddhaShop.Models;
using BuddhaShop.Repositories;
using BuddhaShop.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5115);
    options.ListenAnyIP(5116, listenOptions =>
    {
        listenOptions.UseHttps();
    });
});


builder.Services.AddControllers();

builder.Services.AddCors();

builder.Services.AddDbContext<BuddhaShopContext>(
    opt => opt.UseSqlServer(
        builder.Configuration.GetConnectionString("buddhashop"))
    );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();

builder.Services.AddAutoMapper(typeof(AutoMap));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(o =>
o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapControllers();

app.Run();
