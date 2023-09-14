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

    }
}