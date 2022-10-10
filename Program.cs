using CompanySystem.BusinessLogic.PageSection;
using CompanySystem.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPageSectionManager, PageSectionManager>(); /// THIS
builder.Services.AddScoped<CompanyContext , CompanyContext>();    //// THIS

builder.Services.AddDbContext<CompanyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Connectionstring")));

builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("defult", (options) =>
    {

        options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
//app.UseCors(MyAllowSpecificOrigins);

app.UseCors("defult");
app.MapControllerRoute(
    name: "default",

    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html"); 

app.Run();
