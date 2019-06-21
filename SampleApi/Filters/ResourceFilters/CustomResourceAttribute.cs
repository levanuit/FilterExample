using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;

namespace SampleApi.Filters.ResourceFilters
{
    public class CustomResourceAttribute : Attribute, IResourceFilter
    {
        private readonly ILogger logger;

        public CustomResourceAttribute(ILogger logger)
        {
            this.logger = logger;
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            context.HttpContext.Items.Add("ResourceFilter", "Passed Resource Filter");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if(!context.HttpContext.Items["AuthorizationFilter"].Equals("Passed Authorization Filter"))
            {
                context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }
        }
    }
}
