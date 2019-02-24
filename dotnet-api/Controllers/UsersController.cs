using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace dotnet_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public ActionResult<IEnumerable<object>> Get()
        {
            return new object[]
            {
                new
                {
                    Name="Kasasa Timothy",
                    Age=98,
                    Company="Laboremus"
                },
                new
                {
                    Name="Ayiko Benedict",
                    Age=90,
                    Company="Andela"
                },
                new
                {
                    Name="Mujungu Eva",
                    Age=50,
                    Company="EvaShots"
                }
            };
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
