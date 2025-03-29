using Microsoft.AspNetCore.Mvc;

namespace ES_TUTOR.Controller
{
    public class RegisterationController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
    }
}
