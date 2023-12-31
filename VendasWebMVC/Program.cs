﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using VendasWebMVC.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<VendasWebMVCContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("VendasWebMVCContext") ?? throw new InvalidOperationException("Connection string 'VendasWebMVCContext' not found.")));

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

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "home.index",
    pattern: "",
    defaults: new { controller = "Home", Action = "Index" });

app.MapControllerRoute(
    name: "home.Privacidade",
    pattern: "Privacidade",
    defaults: new { controller = "Home", Action = "Privacidade" });

app.MapControllerRoute(
    name: "departamentos.index",
    pattern: "departamentos",
    defaults: new { controller = "Departamentos", Action = "Index" });

app.Run();
