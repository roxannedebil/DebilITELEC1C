using DebilITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DebilITELEC1C.Controllers
{
    public class StudentController : Controller
    {
        List<Student> StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Roxanne Alyssandra",LastName = "Debil", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.00, Email = "roxannedebil14@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Patricia Yvonne",LastName = "Girao", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1.5, Email = "yvonnegirao@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Charlene",LastName = "Arlante", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.75, Email = "charlenearlante@gmail.com"
                },
                new Student()
                {
                    Id= 4,FirstName = "Gabrielle Joanna",LastName = "Belgar", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "gabebelgar@gmail.com"
                }
            };
        public IActionResult Index()
        {

            return View(StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Student addStudent)
        {
            StudentList.Add(addStudent);
            return View("Index", StudentList);
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            Student? student = StudentList.FirstOrDefault(st =>st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = StudentList.FirstOrDefault(st => st.Id == studentChanges.Id);

            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName; 
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.GPA = studentChanges.GPA;
                student.AdmissionDate = studentChanges.AdmissionDate;

            }               
            return View("Index", StudentList);
        }

    }
}