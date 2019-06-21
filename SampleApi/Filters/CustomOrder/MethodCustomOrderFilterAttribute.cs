using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.CustomOrder
{
    public class MethodCustomOrderFilterAttribute : Attribute, IAuthorizationFilter, IOrderedFilter
    {
        public MethodCustomOrderFilterAttribute()
        {

        }

        public int Order => 0;

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("OhShit!", "We run first!!");
        }
    }
}
