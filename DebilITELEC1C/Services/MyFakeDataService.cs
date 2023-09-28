using DebilITELEC1C.Models;
using DebilITELEC1C.Services;

namespace DebilITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List <Student> StudentList {get;}
        public List <Instructor> InstructorList { get;}
        public MyFakeDataService() //constructor
        {
            StudentList = new List<Student>
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


            InstructorList = new List<Instructor>
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

        }
                
    }
}
