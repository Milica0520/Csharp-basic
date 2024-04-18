using HomeworkClass05.Models;
using System;
using System.Runtime.ConstrainedExecution;

namespace HomeworkClass05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Driver driverOne = new Driver("Bob", 6);
            Driver driverTwo = new Driver("Greg", 3);
            Driver driverThree = new Driver("Jill", 7);
            Driver driverFour = new Driver("Anne", 2);
         
            Driver[] drivers = new Driver[4];
            drivers[0] = driverOne;
            drivers[1] = driverTwo;
            drivers[2] = driverThree;
            drivers[3] = driverFour;
          

            Car carX = new Car("Hyundai", 200);
            Car carY = new Car("Mazda", 190);
            Car carZ = new Car("Ferrari", 250);
            Car carQ = new Car("Porsche", 230);

            Car[] cars = new Car[4];
            cars[0] = carX;
            cars[1] = carY;
            cars[2] = carZ;
            cars[3] = carQ;  

            int[] resultsOfspeed = new int[2];
            int resultIdex = 0;
            int counter = 0;

         while (counter <= 1) { 
                Console.WriteLine("Choose a car :\n Hyundai \n Mazda\n Ferrari\n Porsche");
                string carInput = Console.ReadLine();

                Console.WriteLine("Choose Driver :\n Bob \n Greg\n Jill\n Anne");
                string driverInp = Console.ReadLine();

                foreach (Car car in cars)
                {
                  
                  if(car.Model == carInput)
                    {  
                        foreach (Driver driver in drivers)
                        {
                            if (driver.Name == driverInp)
                            {        
                                car.driverObj = driver;
                                // Console.WriteLine(car.driverObj.Name);
                                int speedResult = car.CalculateSpeed(driver);
                                resultsOfspeed[resultIdex] = speedResult;
                                resultIdex++;
                            }
                            else
                            {
                                Console.WriteLine("Error.Driver not found");
                            }
                        }
                    }
                }
                counter++;
            }
            RaceCars(resultsOfspeed[0], resultsOfspeed[1]);
        }

      
      static void RaceCars(int speed1, int speed2)
        {
            if (speed1 > speed2)
            {
                Console.WriteLine($"The first car won!");
            }
            else if ( speed1 < speed2) 
            {
                Console.WriteLine($"The second car won!");
            }
            else
            {
                Console.WriteLine($"It is a tie.");
            }
        }
    }
}
