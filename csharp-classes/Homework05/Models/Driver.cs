using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05.Models
{
    public class Driver
    {
        public Driver()
        {

        }
        public Driver(string Name, int Skill)
        {
            this.Name = Name;
            this.Skill = Skill;
        }


        public string Name { get; set; }
        public int Skill { get; set; }


        
    }
}
