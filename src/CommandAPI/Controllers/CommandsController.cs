using System.Collections.Generic;   // Поддержка IEnumerable
using Microsoft.AspNetCore.Mvc;     // Поддержка почти всего остального

namespace CommandAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "this", "is", "hard", "coded" };
        }
    }
}