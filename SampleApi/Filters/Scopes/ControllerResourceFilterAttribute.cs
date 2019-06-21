using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.Scopes
{
    public class ControllerResourceFilterAttribute : Attribute, IResourceFilter
    {
        public ControllerResourceFilterAttribute()
        {

        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            if (!context.HttpContext.Items["PassedMethodResourceFilter"].Equals("Passed Method Resource Filter"))
            {
                context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }

            context.HttpContext.Items.Add("PassedControllerResourceFilter", "Passed Controller Resource Filter");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (!context.HttpContext.Items["EnterGlobalResourceFilter"].Equals("Enter Global Resource Filter"))
            {
                context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            }

            context.HttpContext.Items.Add("EnterControllerResourceFilter", "Enter Controller Resource Filter");
        }
    }
}
