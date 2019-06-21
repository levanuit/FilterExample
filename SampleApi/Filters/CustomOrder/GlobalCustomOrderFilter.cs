using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.CustomOrder
{
    public class GlobalCustomOrderFilter : IAuthorizationFilter, IOrderedFilter
    {
        public GlobalCustomOrderFilter()
        {

        }

        public int Order => GetOrder();

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            context.HttpContext.Items.Add("RunLast", "Oh! We run last");
        }

        private int GetOrder()
        {
            return 2;
        }
    }
}
