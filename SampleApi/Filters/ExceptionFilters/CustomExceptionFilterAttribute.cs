using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Filters.ExceptionFilters
{
    public class CustomExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        public CustomExceptionFilterAttribute()
        {

        }

        public void OnException(ExceptionContext context)
        {
            // Handle action exceptions here
            // string exception = context.Exception.Message;
            // context.ExceptionHandled = true;
            return;
        }
    }
}
