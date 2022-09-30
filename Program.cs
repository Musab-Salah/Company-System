using CompanySystem.BusinessLogic.PageSection;
using CompanySystem.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPageSectionManager, PageSectionManager>(); /// THIS
builder.Services.AddScoped<CompanyContext , CompanyContext>();    //// THIS

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}

app.UseStaticFiles();
app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=PageSection}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); ;

app.Run();
