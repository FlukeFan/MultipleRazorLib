using Microsoft.AspNetCore.Mvc;

namespace MultipleRazorLib.Web
{
    [Route("/")]
    public class Controller : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content(@"
                <a href='/lib1'>lib1</a>
                <br/>
                <a href='/lib2'>lib2</a>
            ", "text/html");
        }
    }
}
