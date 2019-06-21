using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.CustomOrder
{
    public class ControllerCustomOrderFilterAttribute : Attribute, IAuthorizationFilter, IOrderedFilter
    {
        public ControllerCustomOrderFilterAttribute()
        {

        }

        public int Order => -1;

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("Woop", "We run second!");
        }
    }
}
