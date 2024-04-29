using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExeptionsExercise1.Models
{
    public class Cinema
    {
        public Cinema()
        {

        }
        public Cinema(string name, string halls, List<Movie> listOfMovies)
        {
            Name = name;
            Halls = halls;
            ListOfMovies = listOfMovies;
        }
        public string Name { get; set; }

        public string Halls { get; set; }

        public List<Movie> ListOfMovies { get; set; }

        public void MoviePlaying(Movie Movie)
        {
            Console.WriteLine($"The {Movie.Title} is playing");

        }


    }
}
