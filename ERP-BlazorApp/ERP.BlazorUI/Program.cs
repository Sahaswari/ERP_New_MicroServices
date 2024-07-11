using Blazored.LocalStorage;
using ERP.BlazorUI.Components;
using ERP.BlazorUI.Components.Pages.Department.Training;
using ERP_LabEquipmentManagement.DTOs.Response;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor.Services;





var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();





builder.Services.AddMudServices();
builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();
builder.Services.AddScoped<CustomAuthenticationStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddHttpClient();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddAuthenticationCore();
builder.Services.AddAuthorizationCore(options =>
{
    options.AddPolicy("Coordinator", policy => policy.RequireRole("Coordinator"));
    options.AddPolicy("Student", policy => policy.RequireRole("Student"));
});



// Add HttpClient for making API requests



var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
