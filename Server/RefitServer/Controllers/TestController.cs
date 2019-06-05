using Microsoft.AspNetCore.Mvc;
using RefitServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET api/values
        [HttpGet("TestMethod")]
        public async Task<IActionResult> TestMethod([FromQuery]TestRequestDTO requestDTO)
        {
            return Ok();
        }
    }
}
