using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace DependencyInjectionExample
{
    public class ExampleFunction
    {
        public ExampleFunction(/* add dependencies here */)
        {

        }

        [FunctionName(nameof(SimpleRequest))]
        public async Task<IActionResult> SimpleRequest([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("The logger is injected at method level");

            return new OkResult();
        }
    }
}
