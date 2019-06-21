using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.DealWithDI.TypeFilterAttribute
{
    public class CustomTypeFilterAttribute : Microsoft.AspNetCore.Mvc.TypeFilterAttribute
    {
        public CustomTypeFilterAttribute(params string[] messages) 
            : base(typeof(DIAuthorizationWithTypeFilter))
        {
            this.Arguments = new[] { messages };
            this.Order = Int32.MinValue;
        }
    }
}
