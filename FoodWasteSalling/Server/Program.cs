using FoodWasteSalling.Server.Services;
using FoodWasteSalling.Shared.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddHttpClient<IOfferService, OfferService>();

var baseUrl = Environment.GetEnvironmentVariable("BASE_URL");
if (string.IsNullOrEmpty(baseUrl))
{
	throw new ArgumentNullException("SallingGroupApi:BaseUrl, Base URL for Salling Group API is not configured.");
}

builder.Services.AddHttpClient<IOfferService, OfferService>(client =>
{
	client.BaseAddress = new Uri(baseUrl);
	client.DefaultRequestHeaders.Add("Authorization", $"{Environment.GetEnvironmentVariable("API_KEY")}");
});



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

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
