using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly DemoService devService;

        public LocationController(DemoService devServ)
        {
            devService = devServ;
        }

        // GET api/values
        [HttpGet("")]
        public IActionResult GetLocationList()
        {
            return Ok(devService.Locations);
        }
    }
}
