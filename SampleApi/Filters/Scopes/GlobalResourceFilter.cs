using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.Scopes
{
    public class GlobalResourceFilter : IResourceFilter
    {
        public GlobalResourceFilter()
        {

        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //if (!context.HttpContext.Items["PassedControllerResourceFilter"].Equals("Passed Controller Resource Filter"))
            //{
            //    context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            //}

            context.HttpContext.Items.Add("PassedGlobalResourceFilter", "Passed Global Resource Filter");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            //if(!context.HttpContext.Items["MethodAuthorizationFilter"].Equals("Passed Method Authorization Filter"))
            //{
            //    context.Result = new StatusCodeResult(StatusCodes.Status401Unauthorized);
            //}

            context.HttpContext.Items.Add("EnterGlobalResourceFilter", "Enter Global Resource Filter");
        }
    }
}
