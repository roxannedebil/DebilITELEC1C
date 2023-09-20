using DebilITELEC1C.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DebilITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>
            {
                new Instructor()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", IsTenured = IsTenured.Permanent, Rank = Rank.Professor, HiringDate = DateTime.Parse("2022-08-26")
                },
                new Instructor()
                {
                    Id= 2,FirstName = "Beatriz",LastName = "Lacsamana", IsTenured = IsTenured.Probationary, Rank = Rank.AssistantProfessor, HiringDate = DateTime.Parse("2022-08-07")
                },
                new Instructor()
                {
                    Id= 3,FirstName = "Leonid",LastName = "Lintag", IsTenured = IsTenured.Permanent, Rank = Rank.AssociateProfessor, HiringDate = DateTime.Parse("2020-01-25")
                }
            };
        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

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
            InstructorList.Add(AddInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(st => st.Id == instructorChanges.Id);

            if (instructor != null)
            {
                instructor.FirstName = instructorChanges.FirstName;
                instructor.LastName = instructorChanges.LastName;
                instructor.IsTenured = instructorChanges.IsTenured;
                instructor.Rank = instructorChanges.Rank;              
                instructor.HiringDate = instructorChanges.HiringDate;

            }
            return View("Index", InstructorList);
        }
    }
}