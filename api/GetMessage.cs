using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace StaticWebAppsEndToEndTesting.GetMessage
{
    public static class GetMessage
    {
        [FunctionName("GetMessage")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ExecutionContext context,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request! :) ");
            StringBuilder sb = new StringBuilder();
            foreach (DictionaryEntry e in System.Environment.GetEnvironmentVariables())
            {
                sb.AppendLine(e.Key + ":" + e.Value);
            }

            return new OkObjectResult(sb.ToString());
        }
    }
}
