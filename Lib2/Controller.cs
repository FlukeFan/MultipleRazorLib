using Microsoft.AspNetCore.Mvc;

namespace MultipleRazorLib.Lib2
{
    [Route("/lib2")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("/Index.cshtml");
        }
    }
}