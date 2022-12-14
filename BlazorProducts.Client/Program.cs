using BlazorProducts.Application.Core.Repositories;
using BlazorProducts.Client;
using BlazorProducts.Client.Repository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7025/api/") });
builder.Services.AddScoped<IProductHttpRepository, ProductHttpRepository>();

await builder.Build().RunAsync();
