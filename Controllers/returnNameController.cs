using Microsoft.AspNetCore.Mvc;

namespace Github_Practice.Controllers
{
    public class returnNameController : Controller
    {

        public IActionResult GetName()
        {
            var name = new { Name = "Ian Wolfram" };
            return new JsonResult(name);
        }
    }
}
