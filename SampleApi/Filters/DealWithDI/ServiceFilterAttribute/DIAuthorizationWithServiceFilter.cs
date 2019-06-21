using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.DealWithDI.ServiceFilterAttribute
{
    public class DIAuthorizationWithServiceFilter : IAuthorizationFilter
    {
        private readonly ILogger logger;

        public DIAuthorizationWithServiceFilter(ILoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateLogger<DIAuthorizationWithServiceFilter>();
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            this.logger.LogInformation("Dependency Injection? DEAL!!");
        }
    }
}
