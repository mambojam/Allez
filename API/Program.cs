using Application.Services;
using Domain;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configure the database context to use SQL Server
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<Seed>();
builder.Services.AddScoped<IBaseService<Block>, BlockService>();
builder.Services.AddScoped<IBaseService<Domain.Route>, RouteService>();
builder.Services.AddScoped<IBaseService<Location>, LocationService>();
builder.Services.AddScoped<IBaseRepository<Block>, BlockRepository>();
builder.Services.AddScoped<IBaseRepository<Domain.Route>, RouteRepository>();
builder.Services.AddScoped<IBaseRepository<Location>, LocationRepository>();



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.MapControllers();

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

// Updates the database whenever we run the program
try
{
    var context = services.GetRequiredService<DataContext>();
    var seed = services.GetRequiredService<Seed>();
    


    await context.Database.MigrateAsync(); // Begins a migration
    await seed.SeedData(context); // Checks to see if the database contains data and seeds data if not
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occured during migration");
}

app.Run();
