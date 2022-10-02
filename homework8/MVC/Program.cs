using WebApplication1.DB.Connections;
using WebApplication1.HelperServices;
using WebApplication1.Services.Implimentations;
using WebApplication1.Services.Models;

var builder = WebApplication.CreateBuilder(args);

#region Add custom services

builder.Services.AddSingleton<IProductService, ProductService>();
builder.Services.AddSingleton<IGhostUser, GhostUser>();  //i think i tried all methods with autofac and this's best solution

builder.Services.AddSingleton<DBConnection>();

#endregion

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();


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