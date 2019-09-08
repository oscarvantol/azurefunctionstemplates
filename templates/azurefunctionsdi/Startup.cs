using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(DependencyInjectionExample.Startup))]

namespace DependencyInjectionExample
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {            
            //builder.Services.AddScoped<>();
            //builder.Services.AddTransient<>();
            //builder.Services.AddSingleton<>();

            //check 'https://serverlesslibrary.net/sample/4a469420-defe-4626-8ab5-83136a19ac51' for configuration examples and IHttpClientFactory
        }
    }
}
