using Microsoft.AspNetCore.Localization;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MitrosremERP.Aplication.AutoMapper;
using MitrosremERP.Aplication.Data;
using MitrosremERP.Infrastructure.Repositories;
using System.Globalization;
using Microsoft.AspNetCore.Identity;
using Serilog;
using MitrosremERP.Aplication.IRepositories;
using MitrosremERP.Infrastructure.EmailSevices;
using System.Configuration;
using System.Net.Mail;
using MitrosremERP.Domain.Models.Email;
using Microsoft.AspNetCore.Builder;
using MitrosremERP.Domain.Models.IdentityModel;
using MitrosremERP.Infrastructure.DbInitilizer;
using Microsoft.AspNetCore.Identity.UI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Session
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(10);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
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
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("CanDeleteRoles", policy =>
    {
        policy.RequireRole(Roles.Role_SuperAdmin); 
    });
}); 


/*builder.Services.AddIdentity<ApplicationUser, IdentityRole>().AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationDbContext>();*/

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = $"/Identity/Account/Login";
    options.LogoutPath = $"/Identity/Account/Logout";
    options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
});

builder.Services.AddRazorPages();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IDbinitilizer, DbInitilizer>();
builder.Services.AddTransient<IEmailSender, EmailSender>();
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));



Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(builder.Configuration).CreateLogger();

builder.Host.UseSerilog();
//builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));



var app = builder.Build();


app.UseRequestLocalization();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error/");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();   
}
app.UseSerilogRequestLogging();

app.UseDeveloperExceptionPage();
app.UseStatusCodePagesWithReExecute("/Error/{0}");


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
SeedDatabase();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapRazorPages();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
 );

app.Run();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitilizer = scope.ServiceProvider.GetRequiredService<IDbinitilizer>();
        dbInitilizer.Initilizer();
    }
}