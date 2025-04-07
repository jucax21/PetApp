using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetApp.Data;
using PetApp.Models;
using PetApp.Services;


var builder = WebApplication.CreateBuilder(args);



builder.Services.AddHttpContextAccessor();


// Agregar EF Core con SQLite
builder.Services.AddDbContext<PetServicesContext>(options =>
    options.UseSqlite("Data Source=PetServices.db"));




builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


// Autenticación personalizada
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthProvider>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddAuthorizationCore();
var app = builder.Build();


// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
