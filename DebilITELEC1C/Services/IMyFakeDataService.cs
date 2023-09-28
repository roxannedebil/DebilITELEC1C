using DebilITELEC1C.Models;

namespace DebilITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        List<Student> StudentList { get; }

        List <Instructor> InstructorList { get; }
    }
}
