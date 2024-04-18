using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClass05.Models
{
    internal class Car
    {
        public string Model { get; set; }

        public int Speed { get; set; }

        public Driver driverObj { get; set; }

        public Car(string model, int speed )
        {
            Model = model;
            Speed = speed;
        }
        public int CalculateSpeed(Driver driverObj)
        {
           return driverObj.Skill * Speed;
        }


         
    }
}
