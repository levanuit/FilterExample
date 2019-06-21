using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.Scopes
{
    public class MethodAuthorizationFilterAttribute : Attribute, IAuthorizationFilter
    {
        public MethodAuthorizationFilterAttribute()
        {

        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("MethodAuthorizationFilter", "Passed Method Authorization Filter");
        }
    }
}
