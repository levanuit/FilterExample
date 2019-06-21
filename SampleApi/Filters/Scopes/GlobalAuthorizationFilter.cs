using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.Scopes
{
    public class GlobalAuthorizationFilter : IAuthorizationFilter
    {
        public GlobalAuthorizationFilter()
        {

        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("GlobalAuthorizationFilter", "Passed Global Authorization Filter");
        }
    }
}
