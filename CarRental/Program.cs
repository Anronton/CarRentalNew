using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CarRental;
using CarRental.Business.Classes;
using CarRental.Common.Interfaces;
using CarRental.Data.Classes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IData, CollectionData>();
builder.Services.AddSingleton<BookingProcessor>();

await builder.Build().RunAsync();
