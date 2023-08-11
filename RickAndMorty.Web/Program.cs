using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RickAndMorty.Web;
using RickAndMorty.Web.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(
    sp => new HttpClient 
    { 
        BaseAddress = new Uri("https://rickandmortyapi.com/api") ,
        
    });

builder.Services.AddScoped<IConsumeAPI, ConsumeAPI>();

await builder.Build().RunAsync();
