using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using T3._1_BLAZOR_APP;
using T3._1_BLAZOR_APP.Data;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using static T3._1_BLAZOR_APP.Pages.BitcoinAnalyzer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddScoped<BearishTrendService>();
builder.Services.AddScoped<VolumeService>();
builder.Services.AddScoped<BuySellService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();



