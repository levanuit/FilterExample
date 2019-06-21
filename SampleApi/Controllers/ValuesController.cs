using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SampleApi.Filters.ActionFilters;
using SampleApi.Filters.AuthorizationFilters;
using SampleApi.Filters.ExceptionFilters;
using SampleApi.Filters.ResourceFilters;
using SampleApi.Filters.ResultFilters;
using SampleApi.Filters.Scopes;

namespace SampleApi.Controllers
{
    // [ControllerAuthorizationFilter]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        // [CustomAsyncAuthorization]
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [CustomAsyncAuthorization]
        // [Authorize(Policy = "AtLeast18")]
        [CustomAsyncResource]
        [CustomExceptionFilter]
        [CustomActionFilter]
        [CustomResultFilter]
        [HttpGet("bobo")]
        public string[] BoBo()
        {
            //string a = null;

            //if (a.Equals("ali"))
            //{
            //    return new string[] { "ali", "ali" };
            //}

            return new string[] { "bobo", "ali" };
        }
    }
}
