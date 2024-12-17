using CookBookWebSQL;
using CookBookWebSQL.Components;
using CookBookWebSQL.Models;
using CookBookWebSQL.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

string apiKey = Environment.GetEnvironmentVariable("googleMapApi");

// Register the DbContext with the dependency injection container
builder.Services.AddDbContext<CookBookDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register application services
builder.Services.AddScoped<CuisineService>();
builder.Services.AddScoped<RecipeService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<IngredientService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<FeedbackService>();
builder.Services.AddScoped<CookBookWebSQL.Service.RestaurantService>();
builder.Services.AddScoped<RestaurantManagementWebSQL.Service.RestaurantService>();

// Add Razor Pages and Server-Side Blazor
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//Register the AdminDashboardService
builder.Services.AddScoped<AdminDashboardService>();

var app = builder.Build();

// Run migrations or initialization logic when the app starts
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var db = services.GetRequiredService<CookBookDBContext>();
    // Uncomment the following line if migrations are required at startup
    // db.Database.Migrate();
}

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Antiforgery protection
app.UseAntiforgery();

// Map Razor components and enable server-side rendering
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// app.MapRazorPages();
// app.MapBlazorHub();

app.Run();
