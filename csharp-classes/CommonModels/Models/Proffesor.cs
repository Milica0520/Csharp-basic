
using CommonModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels.Models
{
    public class Proffesor : Person
    {



        public string[] LecturingCourses { get; set; }

        public string[] Materials { get; set; }

        public string Biographu { get; set; }

       


        public ProffesorStatus Status { get; set; }




        public override void PrintInfo()
        {
            Console.WriteLine("Proffesor info :");
            base.PrintInfo();

            switch (Status)
            {
                case ProffesorStatus.None:
                    Console.WriteLine("Proff is none.");
                    break;
                case ProffesorStatus.Active:
                    Console.WriteLine("Proff is active.");
                    break;
                case ProffesorStatus.Inactive:
                    Console.WriteLine("Proff is inactive.");
                    break;
                case ProffesorStatus.Waiting:
                    Console.WriteLine("Proff is witing.");
                    break;
            }


            Console.WriteLine("LecturingCourses courses :");
            foreach (string course in LecturingCourses)
            {
                Console.WriteLine(course);
            }

            Console.WriteLine("Books :");
            foreach (string material in Materials)
            {
                Console.WriteLine(material);
            }


          
        }


    }
}
