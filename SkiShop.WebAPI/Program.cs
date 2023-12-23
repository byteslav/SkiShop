using Microsoft.EntityFrameworkCore;
using SkiShop.Application;
using SkiShop.Application.Commands;
using SkiShop.Domain;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(CreateProductCommandHandler).Assembly));
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var connectionString = "Server=localhost; Port=5432;User Id=admin; Password=root; Database=db_ski_shop;"; // TODO: move to appsettings
builder.Services.AddDbContext<ShopContext>(options =>
                options.UseNpgsql(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
