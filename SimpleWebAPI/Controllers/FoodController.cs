using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly DemoService devService;

        public FoodController(DemoService devServ)
        {
            devService = devServ;
        }

        // GET api/values
        [HttpGet("")]
        public IActionResult GetFoodList()
        {
            return Ok(devService.Foods);
        }

        [HttpPut("{id}")]
        public IActionResult ReplaceFood(int id, Food food)
        {
            devService.Foods[id] = food;
            return Ok();
        }
    }
}
