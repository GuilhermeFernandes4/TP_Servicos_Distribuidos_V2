using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using House_API;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProductDBContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
MigrationService.InitializeMigration(app);

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapProductEndpoints();

app.Run();
