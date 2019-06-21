using Microsoft.AspNetCore.Mvc;
using SampleApi.Filters.DealWithDI.ServiceFilterAttribute;
using SampleApi.Filters.DealWithDI.TypeFilterAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiDealersController : ControllerBase
    {
        [ServiceFilter(typeof(DIAuthorizationWithServiceFilter))]
        [HttpGet]
        public string[] ServiceFilterAttributeDealer()
        {
            return new string[] { "DI?", "EZPZ!!" };
        }

        [CustomTypeFilter("ohyea")]
        [HttpGet("typefilter")]
        public string[] TypeFilterAttributeDealer()
        {
            return new string[] { "DI??", "=))" };
        }
    }
}
