using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.DealWithDI.TypeFilterAttribute
{
    public class DIAuthorizationWithTypeFilter : IAuthorizationFilter
    {
        private readonly ILogger logger;
        private readonly string[] messages;

        public DIAuthorizationWithTypeFilter(string[] messages, ILoggerFactory loggerFactory)
        {
            this.messages = messages;
            this.logger = loggerFactory.CreateLogger<DIAuthorizationWithTypeFilter>();
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            foreach(string message in messages)
            {
                this.logger.LogInformation(message);
            }
        }
    }
}
