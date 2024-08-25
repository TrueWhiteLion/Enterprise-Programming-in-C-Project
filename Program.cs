using Enterprise_Programming_in_C_Project.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ProductService>(); // Registers the ProductService
builder.Services.AddSingleton<CartService>(); // Registers the CartService

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

/*Did some more reading to figure out what the above does and added some comments to them*/