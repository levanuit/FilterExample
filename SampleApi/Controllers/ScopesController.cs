using Microsoft.AspNetCore.Mvc;
using SampleApi.Filters.Scopes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerAuthorizationFilter]
    //[ControllerResourceFilter]
    public class ScopesController : ControllerBase
    {
        [MethodAuthorizationFilter]
        //[MethodResourceFilter]
        [HttpGet]
        public string[] Scopes()
        {
            return new string[] { "Scopes", "Order" };
        }
    }
}
