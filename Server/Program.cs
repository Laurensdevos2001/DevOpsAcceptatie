using FluentValidation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Oogarts.Persistence;
using Oogarts.Services;
using Microsoft.AspNetCore.Components.QuickGrid.EntityFrameworkAdapter;
using Blazored.LocalStorage;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOogartsServices();

builder.Services.AddDbContext<OogartsDbContext>();

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddBlazoredLocalStorage();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//app.UseBlazorFrameworkFiles();

app.MapWhen(ctx => ctx.Request.Host.Port == 5001 ||
    ctx.Request.Host.Equals("oogcentrum-vision.be"), first =>
    {
        first.Use((ctx, nxt) =>
        {
            ctx.Request.Path = "/Client" + ctx.Request.Path;
            return nxt();
        });

        first.UseBlazorFrameworkFiles("/Client");
        first.UseStaticFiles();
        first.UseStaticFiles("/Client");
        first.UseRouting();

        first.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapFallbackToFile("/Client/{*path:nonfile}",
                "Client/index.html");
        });
    });

app.MapWhen(ctx => ctx.Request.Host.Port == 5002 ||
    ctx.Request.Host.Equals("admin.oogcentrum-vision.be"), second =>
    {
        second.Use((ctx, nxt) =>
        {
            ctx.Request.Path = "/Admin" + ctx.Request.Path;
            return nxt();
        });

        second.UseBlazorFrameworkFiles("/Admin");
        second.UseStaticFiles();
        second.UseStaticFiles("/Admin");
        second.UseRouting();

        second.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapFallbackToFile("/Admin/{*path:nonfile}",
                "Admin/index.html");
        });
    });

app.UseStaticFiles();

//app.UseRouting();


//app.MapRazorPages();
//app.MapControllers();
//app.MapFallbackToFile("index.html");

app.Run();
