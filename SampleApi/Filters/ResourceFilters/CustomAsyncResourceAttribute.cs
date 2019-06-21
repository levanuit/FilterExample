using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.ResourceFilters
{
    public class CustomAsyncResourceAttribute : Attribute, IAsyncResourceFilter
    {
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            if(!context.HttpContext.Items["AuthorizationFilter"].Equals("Passed Authorization Filter"))
            {
                context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }

            var contextResult = await next();

            context.HttpContext.Items.Add("ResourceFilter", "Passed Resource Filter");
        }
    }
}
