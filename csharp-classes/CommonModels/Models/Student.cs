using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels.Models
{
    public class Student : Person
    {

        public Student()
        {

        }

        public string UniqueStudentID { get; set; }

        public string[] AttendingCourses { get; set; }

        public double AverigeGrade { get; set; }


        public override void PrintInfo()
        {


            Console.WriteLine("Student info:");

            base.PrintInfo();

;           Console.WriteLine($"{UniqueStudentID} {AverigeGrade} ");


            Console.WriteLine("Studeny, attendin courses: ");

            foreach (string course in AttendingCourses)
            {
                Console.WriteLine(course);
            }

        }

    }
}
