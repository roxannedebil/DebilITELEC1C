using DebilITELEC1C.Models;
using DebilITELEC1C.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DebilITELEC1C.Controllers
{
   
    public class StudentController : Controller
    {
        private readonly IMyFakeDataService _dummyData; 

        public StudentController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {

            return View(_dummyData.StudentList);
        }

        public IActionResult ShowDetail(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

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
            _dummyData.StudentList.Add(addStudent);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st =>st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateStudent(Student studentChanges)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == studentChanges.Id);

            if (student != null)
            {
                student.FirstName = studentChanges.FirstName;
                student.LastName = studentChanges.LastName; 
                student.Email = studentChanges.Email;
                student.Course = studentChanges.Course;
                student.GPA = studentChanges.GPA;
                student.AdmissionDate = studentChanges.AdmissionDate;

            }
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult DeleteStudent(int id)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == id);

            if (student != null)
                return View(student);

            return NotFound();
        }


        [HttpPost]
        public IActionResult DeleteStudent(Student newStudent)
        {
            Student? student = _dummyData.StudentList.FirstOrDefault(st => st.Id == newStudent.Id);

            if (student != null)
                _dummyData.StudentList.Remove(student);

            return RedirectToAction("Index");
        }
    }
}