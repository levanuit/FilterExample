using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.Scopes
{
    public class ControllerAuthorizationFilterAttribute : Attribute, IAuthorizationFilter
    {
        public ControllerAuthorizationFilterAttribute()
        {

        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("ControllerAuthorizationFilter", "Passed Controller Authorization Filter");
        }
    }
}
