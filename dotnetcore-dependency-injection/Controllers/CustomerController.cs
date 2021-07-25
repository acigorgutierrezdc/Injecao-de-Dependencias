using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnetcore_dependency_injection.Repository;
using dotnetcore_dependency_injection.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dotnetcore_dependency_injection.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost("vip")]
        public IActionResult InsertVipCustomer([FromServices] CustomerServiceA customerService, [FromBody] string name)
        {
            customerService.AddCustomer(name);

            return Ok();
        }

        [HttpPost("normal")]
        public IActionResult InsertNormalCustomer([FromServices] CustomerServiceB customerService, [FromBody] string name)
        {
            customerService.AddCustomer(name);

            return Ok();
        }

        [HttpPost("both")]
        public IActionResult InsertBothCustomer([FromServices] CustomerServiceA customerServiceA,
            [FromServices] CustomerServiceB customerServiceB, [FromBody] string name)
        {
            customerServiceA.AddCustomer(name);
            customerServiceB.AddCustomer(name);

            return Ok();
        }
    }
}

