using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Entities.Functions;
using Entities.Interfaces.Services;

namespace PersonalPage.Functions
{
    public class Information
    {
        private const string FunctionRoute = "info";
        private readonly IPersonalInformationServices _personalInformationServices;

        public Information(IPersonalInformationServices personalInformationServices)
        {
            _personalInformationServices = personalInformationServices;
        }

        [FunctionName("Information")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = FunctionRoute)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            var personalInformation = _personalInformationServices.GetPersonalInformationbyUserName("chino");

            return new OkObjectResult(personalInformation);
        }
    }

}
