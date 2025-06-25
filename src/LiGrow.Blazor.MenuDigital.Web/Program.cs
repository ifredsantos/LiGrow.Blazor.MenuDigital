using DotNetEnv;
using LiGrow.Blazor.MenuDigital.Web.Components;
using LiGrow.Blazor.MenuDigital.Web.Services;
using LiGrow.Blazor.MenuDigital.Web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<AppState>();

Env.Load();

var apiURL = Environment.GetEnvironmentVariable("API_URL");
var apiKey = Environment.GetEnvironmentVariable("API_SECRET_KEY");

builder.Services.AddHttpClient<ICategoryService, CategoryService>(client =>
{
   client.BaseAddress = new Uri(apiURL);
   client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
});
builder.Services.AddHttpClient<IProductService, ProductService>(client =>
{
   client.BaseAddress = new Uri(apiURL);
   client.DefaultRequestHeaders.Add("X-API-KEY", apiKey);
});

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
