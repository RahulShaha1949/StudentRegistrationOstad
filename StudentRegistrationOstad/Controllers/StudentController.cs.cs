using Microsoft.AspNetCore.Mvc;
using StudentRegistrationOstad.Models;


namespace StudentRegistrationOstad.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
       
        private static List<Student> _students = new();

       
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        
        [HttpPost("register")]
        public IActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Id = _students.Count + 1;
                _students.Add(student);

                TempData["Success"] = "Student registered successfully! 🎉";
                return RedirectToAction("List");
            }

            TempData["Error"] = "Please fix the errors and try again.";
            return View(student);
        }

       
        [HttpGet("list")]
        public IActionResult List()
        {
            return View(_students);
        }

        
        [HttpGet("json")]
        public IActionResult JsonData()
        {
            return Json(_students);
        }
    }
}
