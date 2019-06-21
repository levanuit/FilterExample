using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.Scopes
{
    public class MethodResourceFilterAttribute : Attribute, IResourceFilter
    {
        public MethodResourceFilterAttribute()
        {

        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            context.HttpContext.Items.Add("PassedMethodResourceFilter", "Passed Method Resource Filter");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!context.HttpContext.Items["EnterControllerResourceFilter"].Equals("Enter Controller Resource Filter"))
            {
                context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }

            context.HttpContext.Items.Add("EnterMethodResourceFilter", "Enter Method Resource Filter");
        }
    }
}
