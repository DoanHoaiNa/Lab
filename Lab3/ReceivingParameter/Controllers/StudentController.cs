using Microsoft.AspNetCore.Mvc;
using ReceivingParameter.Models;

namespace ReceivingParameter.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()

        {
            new Student(){Id = 1, Name = "Hoang Long", Address = "Thai binh"}
        };
        public IActionResult Index()
        {
            return View(students);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
