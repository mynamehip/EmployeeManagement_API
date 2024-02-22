using Microsoft.Extensions.DependencyInjection;
using MISA.WebFresher052023.Demo.Application;
using MISA.WebFresher052023.Demo.Application.Interface;
using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Interface;
using MISA.WebFresher052023.Demo.Infrastructure;
using MISA.WebFresher052023.Demo.Infrastructure.Repository;
using MISA.WebFresher052023.Demo.Infrastructure.UnitOfWork;
using MISA.WebFresher052023.Demo.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddJsonOptions(options => {
        options.JsonSerializerOptions.PropertyNamingPolicy = null;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var connectionString = builder.Configuration["ConnectionStrings"];

builder.Services.AddScoped<IUnitOfWork>(
    provider => new UnitOfWork(connectionString));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IEmployeeManager, EmployeeManager>();

builder.Services.AddScoped<IDepartmentService, DepartmentService>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

builder.Services.AddScoped<IPositionService, PositionService>();
builder.Services.AddScoped<IPositionRepository, PositionRepository>();

builder.Services.AddCors(p => p.AddPolicy("MyCors", build => 
{
    build.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ExceptionMiddleware>();

app.Run();
