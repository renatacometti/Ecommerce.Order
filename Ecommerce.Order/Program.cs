
using Microsoft.EntityFrameworkCore;
using Data.Context;
using Services.Interfaces;
using Services.Services;
using Domain.IRepository;
using Data.Repository;
using System.Configuration;
using Infraestrutura;
using Services.Mapping;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//builder.Services.AddDbContext<AppDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"));
//}, ServiceLifetime.Scoped);

IConfigurationRoot Configuration = new ConfigurationBuilder()
            .SetBasePath(Environment.CurrentDirectory)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile("appsettings.Development.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .Build();

builder.Services.AddSession();
builder.Services.AddSingleton(Configuration);
AppConfiguration.ConfigureApp(builder.Services, Configuration); // Mapeamento de interface de servico e Repositorio
builder.Services.AddAutoMapper(typeof(AutoMapperConfig)); // incluir p/ auto Mapper de DTO para View Model

builder.Services.AddDistributedMemoryCache(); // incluir por um erro


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
