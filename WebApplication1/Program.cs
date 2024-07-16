using System.Linq;
using WebApplication1.MiddleWares;

var builder = WebApplication.CreateBuilder(args);

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


//run kullaným
//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("Before 1. middleware");

//    await next();

//    await context.Response.WriteAsync("After 1. middleware");
//});


//app.Run(async context =>
//{
//    await context.Response.WriteAsync("Terminal 3. middleware");
//});

// Map kullanma
//app.Map("/ornek", app =>
//{
//    app.Run(async context =>
//    {
//       await context.Response.WriteAsync("Örnek Url için middleware");
//    });
//});


//Koþullu yapma
//app.MapWhen(context => context.Request.Query.ContainsKey("name"), app =>
//{
//    app.Use(async (context, next) =>
//    {
//        await next();
//    });
//});


app.UseMiddleware<WhiteIpAddressControlMiddleware>();









app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
