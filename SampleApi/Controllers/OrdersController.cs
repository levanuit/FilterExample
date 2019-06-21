using Microsoft.AspNetCore.Mvc;
using SampleApi.Filters.CustomOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ControllerCustomOrderFilter]
    public class OrdersController : ControllerBase
    {
        [MethodCustomOrderFilter]
        [HttpGet]
        public string[] Orders()
        {
            return new string[] { "Orders", "Wuttt!!" };
        }
    }
}
