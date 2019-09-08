using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DemoService devService;

        public UserController(DemoService devServ)
        {
            devService = devServ;
        }

        // GET api/values
        [HttpGet("Name")]
        public IActionResult GetName()
        {
            return Ok(devService.UserName);
        }
    }
}
