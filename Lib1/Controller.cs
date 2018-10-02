using Microsoft.AspNetCore.Mvc;

namespace MultipleRazorLib.Lib1
{
    [Route("/lib1")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("/Index.cshtml");
        }
    }
}
