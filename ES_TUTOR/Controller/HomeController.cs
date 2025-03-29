using Microsoft.AspNetCore.Mvc;

namespace ES_TUTOR.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
