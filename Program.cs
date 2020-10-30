namespace ePizza
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using ePizza.WebApp.Model;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
    using Microsoft.Extensions.DependencyInjection;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(Url.baseUrl) });

            await builder.Build().RunAsync();
        }
    }
}
