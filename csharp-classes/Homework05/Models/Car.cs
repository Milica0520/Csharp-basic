using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework05.Models
{
    public class Car
    {
        public Car()
        {

        }
      
        public Car(string Model, int Speed, Driver objDriver)
        {
            
             this.Model = Model;
            this.Speed = Speed;
            this.objDriver = objDriver;

        }

  
        public string Model { get; set; }
        public int Speed { get; set; }

        Driver objDriver { get; set; }

     


        public int CalculateSpeed(Driver objDriver)
        {
            int result = objDriver.Skill * Speed;
            return result;
        }



    }
}
