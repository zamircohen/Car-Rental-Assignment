using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Car_Rental_G;
using Car_Rental.Data.Interfaces;
using Car_Rental.Data.Classes;
using Car_Rental.Business;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IData, CollectionData>();
builder.Services.AddScoped<BookingProcessor>();

await builder.Build().RunAsync();
