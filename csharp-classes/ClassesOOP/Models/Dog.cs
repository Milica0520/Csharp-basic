using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOOP.Models
{
    internal class Dog
    {
        public string Name { get; set;  }
        public string race { get; set; }
        public string color { get; set; }

        public string Eat()
        {
            return $"The {Name} is now eating";
        }

        public string Play()
        {
            return $"The  {Name} is now playing";
        }
        public string ChaseTail()
        {
            return $"The  {Name} is now chasing its tail.";
        }
    }
}
