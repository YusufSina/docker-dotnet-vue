using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]    
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(){
            return Ok(new { message = "You got a message"});
        }
    }
}