var builder = WebApplication.CreateBuilder(args);

// MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Error handling + HSTS (production only)
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// Serve files from wwwroot (images, css, js, favicon)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();