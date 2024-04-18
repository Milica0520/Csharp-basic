using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class07.Models
{
    internal class Student
    {

        public Student() { }
        public string Name { get; set; }
        public string Academy { get; set;}

        public string Group { get; set; }

        public Student (string Name, string Academy, string Group)
        {
            this.Name = Name;
            this.Academy = Academy;
            this.Group = Group;

        }
        


    }
}
