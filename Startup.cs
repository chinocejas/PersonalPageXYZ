using Entities.Interfaces.Repositories;
using Entities.Interfaces.Services;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Repositories.Functions;
using Services.Functions;
using System;
using System.Collections.Generic;
using System.Text;

[assembly: FunctionsStartup(typeof(PersonalPage.Startup))]
namespace PersonalPage
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            //REPO
            builder.Services.AddSingleton<IPersonalInformationRepo, PersonalInformationRepo>();

            //SERVICES
            builder.Services.AddSingleton<IPersonalInformationServices, PersonalInformationServices>();
        }
    }
}
