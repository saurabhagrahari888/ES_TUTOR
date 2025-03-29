using ES_TUTOR.Models;
using ES_TUTOR.ViewModel.Student;
using ES_TUTOR.ViewModel.Teacher;
using ES_TUTOR.ViewModel.Tutor;
using Microsoft.AspNetCore.Mvc;

namespace ES_TUTOR.Controller
{
    public class RegisterationController : Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGet("StudentRegister")]
        public IActionResult StudentRegistration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StudentRegistration(StudentRequest obj)
        {
            return View();
        }

       [Route("TeacherRegister")]
        [HttpGet]
        public IActionResult TeacherRegistration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TeacherRegistration(TeacherRequest obj)
        {
            return View();
        }

        [HttpGet]
        public IActionResult TutorRegistration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TutorRegistration(TutorRequest obj)
        {
            return View();
        }



    }
}
