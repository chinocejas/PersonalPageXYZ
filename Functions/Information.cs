using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using PersonalPage.Entities;

namespace PersonalPage.Functions
{
    public class Information
    {
        private const string FunctionRoute = "info";

        [FunctionName("Information")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = FunctionRoute)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var personalInformation = new PersonalInfoDTO("Nico", "chinocejas");

            return new OkObjectResult(personalInformation);
        }
    }

}
