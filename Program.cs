using CookBookWebSQL;
using CookBookWebSQL.Components;
using CookBookWebSQL.Models;
using CookBookWebSQL.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Register the DbContext with the dependency injection container
builder.Services.AddDbContext<CookBookDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Register the CuisineService
builder.Services.AddScoped<CuisineService>();
//Register the RecipeService
builder.Services.AddScoped<RecipeService>();
//Register the CategoryService
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<IngredientService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<FeedbackService>();
builder.Services.AddRazorPages(); builder.Services.AddServerSideBlazor(); builder.Services.AddScoped<RestaurantManagementWebSQL.Service.RestaurantService>();

var app = builder.Build();

// run every web app starts
using (var scope = app.Services.CreateScope()){
    var services = scope.ServiceProvider;
    var db = services.GetRequiredService<CookBookDBContext>();
    //db.Database.Migrate();
}

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
