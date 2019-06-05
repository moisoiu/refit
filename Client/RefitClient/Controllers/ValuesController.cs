using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RefitClient.Models;

namespace RefitClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Services.IService service;
        public ValuesController(Services.IService service)
        {
            this.service = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            var request = new TestRequestDTO()
            {
                EnumOne = new List<long>
                {
                    1,2,3,4
                },
                EnumTwo = new List<long>
                {
                    5,6,7,8
                },
                MethodString = "test"


            };
            var response = this.service.TestMethod(request).Result;


            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
