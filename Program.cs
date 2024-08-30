using Enterprise_Programming_in_C_Project;
using Enterprise_Programming_in_C_Project.Data;
using Enterprise_Programming_in_C_Project.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ProductService>(); // Registers the ProductService
builder.Services.AddSingleton<CartService>(); // Registers the CartService

string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Register the DbContext with the connection string
builder.Services.AddDbContext<ProductContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDbContext<OrderContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Use HSTS to enhance security
    app.UseHsts();
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseStaticFiles(); // Serve static files (e.g., CSS, JS)

app.UseRouting(); // Enable routing

app.UseAuthorization(); // Enable authorization (if needed)

app.MapRazorPages(); // Map Razor Pages to endpoints

app.Run(); // Run the application


/* Did some more reading to figure out what the above does and added some comments to them */