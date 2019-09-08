using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResultsController : ControllerBase
    {
        private readonly DemoService devService;

        public ResultsController(DemoService devServ)
        {
            devService = devServ;
        }

        // GET api/values
        [HttpGet("")]
        public ActionResult GetResults()
        {
            return Ok(devService.GenerateResult());
        }
    }
}
