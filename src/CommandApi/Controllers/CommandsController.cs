using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
namespace CommandAPI.Controllers
{
[Route("api/[controller]")]
// [ApiController]
public class CommandsController : ControllerBase
{
[HttpPost]
public ActionResult<IEnumerable<string>> Get()
{
    return new string[] {"this", "is", "hard", "coded"};
}
}
}