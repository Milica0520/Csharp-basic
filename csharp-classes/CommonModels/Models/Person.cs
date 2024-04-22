
using CommonModels.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonModels.Models
{
    public class Person
    {

       

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDay  { get; set; }

        public string HomeTown { get; set; }



        public Gender Gender { get; set; }
        public virtual void PrintInfo()


           

        {
            Console.WriteLine($"{Id} - {FirstName} {LastName} - {BirthDay.ToShortDateString()} - {HomeTown}");
        }

    }
}
