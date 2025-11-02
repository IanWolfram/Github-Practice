using Microsoft.AspNetCore.Mvc;

namespace Github_Practice.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class returnNameController : Controller
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var name = new { Name = "Ian Wolfram" };
            return new JsonResult(name);
        }
    }
}
