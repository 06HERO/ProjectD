using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using play2.EFModels;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

//加入cookie驗證
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {     
        options.LoginPath = new PathString("/BackendLogin/Login");
        options.LogoutPath = new PathString("/BackendLogin/Logout");
        options.AccessDeniedPath = new PathString("/Backend/Insufficient");
        options.Cookie.HttpOnly = true; 
        options.Cookie.IsEssential = true;
        options.SlidingExpiration = true;
        options.ExpireTimeSpan = TimeSpan.FromMinutes(40);
    });
builder.Services.AddAuthorization();

builder.Services.AddSingleton<HtmlEncoder>(
    HtmlEncoder.Create(allowedRanges: new[] {
        UnicodeRanges.BasicLatin, UnicodeRanges.CjkUnifiedIdeographs }));

//Build資料庫Context
builder.Services.AddDbContext<Play2Context>(
 options => options.UseSqlServer(
 builder.Configuration.GetConnectionString(@"Default")
));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();

//使用session
builder.Services.AddSession(op =>
{
    op.IdleTimeout = TimeSpan.FromMinutes(40);
    op.Cookie.HttpOnly = true;
    op.Cookie.IsEssential = true;
});

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
app.UseSession();
app.UseRouting();
app.UseCookiePolicy();
app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default1",
    pattern: "{controller=Home}/{action=Index}/{id?}/{commodity?}");

app.MapControllerRoute(
    name: "default2",
    pattern: "{controller=Home}/{action=Index}/{date1?}/{date2?}");




app.Run();
