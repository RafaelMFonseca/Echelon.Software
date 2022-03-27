using Microsoft.EntityFrameworkCore;
using Echelon.Infrastructure.EntityFramework.Context;
using Echelon.Api.Abstractions.Repositories;
using Echelon.Api.Abstractions.Services;
using Echelon.Api.Repositories;
using Echelon.Api.Services;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

/* DI */
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserService, UserService>();

/* Third party libraries */
const string coreApplicationAssemblyName = "Echelon.Core";
var coreAssembly = AppDomain.CurrentDomain.Load(coreApplicationAssemblyName);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
AssemblyScanner.FindValidatorsInAssembly(coreAssembly)
               .ForEach(result => builder.Services.AddScoped(result.InterfaceType, result.ValidatorType));

builder.Services.AddControllers();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(name: "default", pattern: "api/{controller}/{action=Index}/{id?}");

app.Run();