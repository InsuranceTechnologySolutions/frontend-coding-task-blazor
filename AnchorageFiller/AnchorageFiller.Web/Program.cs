using AnchorageFiller.Clients;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services
    .AddHttpClient<IFleetsClient, FleetsClient>(client =>
    {
        client.BaseAddress = new(builder.HostEnvironment.BaseAddress, UriKind.Absolute);
    });

await builder.Build().RunAsync();
