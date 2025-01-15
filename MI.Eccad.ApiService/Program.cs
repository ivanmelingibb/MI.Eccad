using MI.Eccad.Core.Data;
using MI.Eccad.Core.Interfaces.Repositories;
using MI.Eccad.Core.Interfaces.Services;
using MI.Eccad.Core.Repositories;
using MI.Eccad.Core.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

builder.Services
    .AddTransient<IProductsRepository, ProductsRepository>()
    .AddTransient<IProductsService, ProductsService>()
    .AddTransient<IDominicalSchoolRepository, DominicalSchoolRepository>()
    .AddTransient<IDominicalSchoolService, DominicalSchoolService>();

builder.Services
    .AddControllers();

builder.Services
    .AddEndpointsApiExplorer()
    .AddSwaggerGen();

builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseQueryStrings = true;
    options.LowercaseUrls = true;
});

builder.Services.AddDbContextFactory<DataContext>(options =>
{
    options.UseMySQL(builder.Configuration.GetConnectionString("Eccad"));
});

// Add services to the container.
builder.Services.AddProblemDetails();

var app = builder.Build();


// Configure the HTTP request pipeline.
app.UseExceptionHandler();

app.MapDefaultEndpoints();
app.MapControllers();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.Run();
