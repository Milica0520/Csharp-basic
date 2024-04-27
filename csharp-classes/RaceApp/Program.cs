using RaceApp.Models;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace RaceApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            RaceCarGame();
            Console.WriteLine("Do you want to race again(Y/N)");
            string answerInp = Console.ReadLine();
            switch (answerInp.ToUpper())
            {
                case "Y":
                    RaceCarGame();
                    break;
                case "N":
                    Console.WriteLine("Game over.");
                    return;
                default:
                    Console.WriteLine("Invalid answer input. Try again with Y/N");
                    break;

            }



        }
        public static void RaceCarGame()
        {
            List<Car> cars = new List<Car>()
                {
                   new Car(1,"Hyundai", 120, null),
                   new Car(2,"Mazda", 120, null),
                   new Car(3,"Ferrari", 120, null),
                   new Car(4,"Porsche", 120, null),
                };

            List<Driver> drivers = new List<Driver>()
                {
                   new Driver(1,"Bob", 6),
                   new Driver(2,"Greg", 4),
                   new Driver(3,"Jill", 2),
                   new Driver(4,"Anne", 8),
                };

            Console.WriteLine("Select a two cars and two drivers for the car race.");


            List<Car> carsForRace = new List<Car>() { };
            List<Driver> driversForRace = new List<Driver>() { };
            int counter = 1;
            do
            {

                Console.WriteLine($"Choose a car no.{counter} :\n1.Hyundai\n2.Mazda\n3.Ferrari\n4.Porsche");
                int carInp = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose a driver:\nBob\nGreg\nJill\nAnne");
                int driverInp = int.Parse(Console.ReadLine());

              


                Car currentCar = null;
                foreach (Car car in cars)
                {
                    if (car.Id == carInp)
                    {
                        currentCar = car;
                        break;
                    }
                    else if (carInp != car.Id)
                    {
                        Console.WriteLine($"Car no. {carInp} not available.");
                        return;
                    }

                }
          
                Driver currentDriver = null;

                foreach (Driver driver in drivers)
                {
                    if (driver.Id == driverInp)
                    {
                        currentDriver = driver;
                        currentCar.SetDriver(currentDriver);
                        break;
                    }

                }

                carsForRace.Add(currentCar);
                driversForRace.Add(currentDriver);

                cars.Remove(currentCar);
                drivers.Remove(currentDriver);
            
                counter++;

            } while (counter <= 2);

            Console.WriteLine(cars.Count());

            Car car1 = carsForRace[0];
            Car car2 = carsForRace[1];
            RaceCars(car1, car2);

        }
        public static void RaceCars(Car car1, Car car2)
        {
            if (car1.CalculateSpeed() > car2.CalculateSpeed())
            {
                Console.WriteLine($"{car1.Model} with speed of {car1.CalculateSpeed()} driven by {car1.ObjDriver.Name} won!");
            }
            else if (car2.CalculateSpeed() > car1.CalculateSpeed())
            {
                Console.WriteLine($"{car2.Model} with speed of {car2.CalculateSpeed()} driven by {car2.ObjDriver.Name} won!");
            }
            else
            {
                Console.WriteLine($"No winer. ");
            }
        }
    }
}
