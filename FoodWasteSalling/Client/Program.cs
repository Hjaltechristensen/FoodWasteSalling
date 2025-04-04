using FoodWasteSalling.Client;
using FoodWasteSalling.Shared.Interfaces;
using FoodWasteSalling.Server.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Components;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IOfferService, OfferService>();
builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<NavigationManager>();


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
