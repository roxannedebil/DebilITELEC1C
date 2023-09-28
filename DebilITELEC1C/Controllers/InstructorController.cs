using DebilITELEC1C.Models;
using DebilITELEC1C.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DebilITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public InstructorController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }
        public IActionResult Index()
        {

            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddInstructor(Instructor AddInstructor)
        {
            _dummyData.InstructorList.Add(AddInstructor);
            return RedirectToAction("Index" );
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;              
                instructor.HiringDate = instructorChanges.HiringDate;

            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }


        [HttpPost]
        public IActionResult DeleteInstructor(Student newInstructor)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(st => st.Id == newInstructor.Id);

            if (instructor != null)
                _dummyData.InstructorList.Remove(instructor);

            return RedirectToAction("Index");
        }
    }
}