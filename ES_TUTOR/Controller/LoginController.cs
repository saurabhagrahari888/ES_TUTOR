using ES_TUTOR.Models;
using ES_TUTOR.Repository;
using ES_TUTOR.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ES_TUTOR.Controller
{
    public class LoginController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly RepositoryContext _context;

        public LoginController(RepositoryContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginRequestModel login)
        {
            Login objlogin = new Login();
            objlogin.UserName = login.UserName;
            objlogin.Password = login.Password;
            _context.UserLogins.Add(objlogin);
            _context.SaveChanges();
                

            return View();
        }
    }
}
