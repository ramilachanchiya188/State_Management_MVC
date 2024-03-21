using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using state_managementdemo1.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<state_managementdemo1Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("state_managementdemo1Context") ?? throw new InvalidOperationException("Connection string 'state_managementdemo1Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

// options is a SessionObject not a complesory but type relavent name
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(30);
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

app.UseRouting();
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

/*app.MapControllerRoute(
    name: "CR",
    pattern: "/CRAMT",
    defaults: new { Controller = "Account", action = "TransferAmount" });*/

app.Run();
