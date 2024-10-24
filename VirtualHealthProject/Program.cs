using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using VirtualHealthProject.Controllers;
using VirtualHealthProject.Data;
using VirtualHealthProject.Models;
using VirtualHealthProject.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Use the desired connection string for the environment
builder.Services.AddDbContext<VirtualHealthDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"))); // Change to Default if needed

builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredLength = 8;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;
    options.SignIn.RequireConfirmedPhoneNumber = false;
})
.AddEntityFrameworkStores<VirtualHealthDbContext>()
.AddDefaultTokenProviders();

builder.Services.AddScoped<IUserRepositories, UserRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

// Uncomment if you want to use the Employees dashboard route
// app.MapControllerRoute(
//     name: "Employees_Dasboard",
//     pattern: "{controller=Employees}/{action=Dashboard}/{id?}");

app.Run();
