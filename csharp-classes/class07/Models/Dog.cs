using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class07.Models
{
    internal class Dog
    {

        public Dog(string Name, string race, string color)
        {
            this.Name = Name;
            this.Race = race;
            this.Color = color;

        }
        public string Name { get; set; }
        public string Race { get; set; }

        public string Color { get; set; }

        public string Eat()
        {
            return $"The dog name {this.Name} is now eating";
        }

        public string Play()
        {
            return $"The dog name {this.Name} is now eating";
        }

        public string ChaseTail()
        {
            return $"The dog name {this.Name} is now eating";
        }
    }
}
