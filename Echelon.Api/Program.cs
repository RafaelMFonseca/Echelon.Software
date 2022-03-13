using Microsoft.EntityFrameworkCore;
using Echelon.Infrastructure.EntityFramework.Context;
using Echelon.Api.Abstractions.Repositories;
using Echelon.Api.Repositories;
using Echelon.Api.Services;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
// builder.Services.AddValidatorsFromAssembly(AppDomain.CurrentDomain.GetAssemblies());
// builder.Services.AddScoped<IRepository, UserRepository>();
// builder.Services.AddScoped<IUserRepository, HouseService>();
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