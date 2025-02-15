using Microsoft.EntityFrameworkCore;
using Mission6.Models; // Ensure correct namespace

var builder = WebApplication.CreateBuilder(args);

// Ensure the configuration file is being used correctly
var connectionString = builder.Configuration.GetConnectionString("MovieConnection");
builder.Services.AddDbContext<MovieDbContext>(options =>
    options.UseSqlite(connectionString)); // Ensure this matches appsettings.json

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
