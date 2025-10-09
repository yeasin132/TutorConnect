using Microsoft.AspNetCore.Mvc;
using TutorConnect.Core.Entities;
using TutorConnect.Services;

namespace TutorConnect.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _service;

        public StudentController(StudentService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _service.GetAllAsync();
            return View(students);
        }

        [HttpPost]
        public async Task<IActionResult> Register(Student student)
        {
            await _service.RegisterAsync(student);
            return RedirectToAction("Index");
        }
    }
}