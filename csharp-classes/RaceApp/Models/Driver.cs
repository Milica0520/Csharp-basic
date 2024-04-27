using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp.Models
{
    public class Driver
    {
        public Driver()
        {

        }
        public Driver(int id,string name, int skill)
        {
            Id = id;
            Name = name;
            Skill = skill;
        }

        public int Id { get; set;  }
        public string Name { get; set; }
        public int Skill { get; set; }
    }
}
