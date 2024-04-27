using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceApp.Models
{
    public class Car
    {
        public Car()
        {

        }
       
        public Car(int id,string model, int speed, Driver objDriver)
        {
            Id = id;
            Model = model;
            Speed = speed;
            ObjDriver = null;

        }
        public int Id { get; set; }
        public string Model { get; set; }

        public int Speed { get; set; }

        public Driver ObjDriver { get; set; }

        public void SetDriver(Driver driver)
        {
            ObjDriver = driver;
        }
        public int CalculateSpeed()
        {
                return ObjDriver.Skill * Speed;
       
        }
    }
}
