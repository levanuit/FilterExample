using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.AuthorizationFilters
{
    public class CustomAsyncAuthorizationAttribute : Attribute, IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("AuthorizationFilter", "Passed Authorization Filter");
            context.HttpContext.Items.Add("Age", "20");
        }
    }
}
