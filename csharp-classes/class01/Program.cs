﻿namespace class01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input first, last name and age,
            // and after that print it to console with some message around
            string firstName;
            string lastName;
            int age;

            Console.WriteLine("Vase ime je?");
            firstName = Console.ReadLine();

            Console.WriteLine("Prezime?");
            lastName = Console.ReadLine();


            Console.WriteLine("...imate godina?");
            string ageInput = Console.ReadLine();

            // Convert user input from string to int
            age = int.Parse(ageInput);

            // Write all the content to Console
            Console.WriteLine($"Vas unos je bio {firstName} {lastName} - {age}");




        }
    }
}
