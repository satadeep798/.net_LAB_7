var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

// default route: /Reviews/Create
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Reviews}/{action=Index}/{id?}");

app.Run();
