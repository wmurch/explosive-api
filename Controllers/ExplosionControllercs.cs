using System;
using Microsoft.AspNetCore.Mvc;

namespace explosive_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{input}")]
        public ActionResult<string> GetExplode(string input)
        {
            var newString = "";
            foreach (var c in input)
            {
                newString += new String(c, int.Parse(c.ToString()));
            }

            return newString;
        }

    }
}