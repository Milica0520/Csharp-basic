

using CommonModels.Enums;
using CommonModels.Models;

namespace class08Inheretance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inheretance-cakll base inheretance

            //prototypes based
            //class based


            Student student = new Student();

            student.Id =1 ;
            student.FirstName ="Tamara";
            student.LastName = "Zdravkovic";
            student.HomeTown = "Leskovac";
            student.BirthDay = new DateTime (2000, 1, 1);

            student.UniqueStudentID = "IB15115";
            student.AverigeGrade = 9.5;
            student.AttendingCourses = new string[]{ "Math", "Programming 1"};
            student.Gender = Gender.Male;

            //base class
           
            //derived class - izvedena klasa
            Proffesor proffesor = new Proffesor();


            proffesor.LecturingCourses = new string[] { "Math", "Programing" };
            proffesor.Biographu = "Lorem ipsum...";
          
            proffesor.Materials = new string[]
            {
                "Math Book1", "Math Book2"
            };



            proffesor.Status = ProffesorStatus.Active;

            proffesor.Status = ProffesorStatus.RegularStaf;


            student.PrintInfo();
            proffesor.PrintInfo();
           

            //enumerations

            if(student.Gender == Gender.Male)
            {
                Console.WriteLine("Student gender is male");
            } else if (student.Gender == Gender.Fimale)
            {
                Console.WriteLine("Student gender is fimale");
            }else
            {
                Console.WriteLine("Gender is unnknown");
            }

        }
    }
}
