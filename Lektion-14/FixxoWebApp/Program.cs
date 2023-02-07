using FixxoWebApp.Contexts;
using FixxoWebApp.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddDbContext<ProductsDataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ProductCatalog")));


builder.Services.AddIdentity<ApplicationUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
}).AddEntityFrameworkStores<DataContext>();

builder.Services.ConfigureApplicationCookie(x =>
{
    x.LoginPath = "/login";
    x.LogoutPath = "/logout";
    x.AccessDeniedPath = "/restricted";
});


var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
