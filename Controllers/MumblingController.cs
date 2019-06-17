using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace explosive_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MumblingController : ControllerBase
    {
        // GET api/values/5
        [HttpGet("{input}")]
        public ActionResult<string> GetMumble(string input) => string.Join("-", input.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));


    }
}