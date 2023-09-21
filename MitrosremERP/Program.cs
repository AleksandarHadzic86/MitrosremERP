using Microsoft.AspNetCore.Localization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MitrosremERP.Aplication.AutoMapper;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Aplication.Interfaces;
using MitrosremERP.Infrastructure.Repositories;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add services localization settings.
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
            new CultureInfo("sr-Latn-RS"), // Serbian in Latin script
            // Add more supported cultures if needed
        };

    options.DefaultRequestCulture = new RequestCulture("sr-Latn-RS");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});



builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddAutoMapper(typeof(AutoMapperConfig));

var app = builder.Build();
app.UseRequestLocalization();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
