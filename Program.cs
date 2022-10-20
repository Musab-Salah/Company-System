using CompanySystem.BusinessLogic.Department;
using CompanySystem.BusinessLogic.Employee;
using CompanySystem.BusinessLogic.EmployeeDetails;
using CompanySystem.BusinessLogic.PageSection;
using CompanySystem.DAL;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPageSectionManager, PageSectionManager>(); 
builder.Services.AddScoped<IDepartmentManager, DepartmentManager>(); 
builder.Services.AddScoped<IEmployeeManager, EmployeeManager>();
builder.Services.AddScoped<IEmployeeDetailsManager, EmployeeDetailsManager>();
builder.Services.AddScoped<CompanyContext , CompanyContext>();    
builder.Services.AddDbContext<CompanyContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("Connectionstring")));
//solve SerializerCycleDetected(int maxDepth)
builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
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
