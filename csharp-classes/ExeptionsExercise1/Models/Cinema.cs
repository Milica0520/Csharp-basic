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
        public Cinema(string Name, string Halls, List<Movie> ListOfMovies)
        {
            this.Name = Name;
            this.Halls = Halls;
            this.ListOfMovies = ListOfMovies;
        }
        public string Name { get; set;  }

        public string Halls { get; set; }

        public List<Movie> ListOfMovies { get; set; }

        public void MoviePlaying (Movie movie)
        {
             Console.WriteLine($"The {movie.Title} is playing");

        }

      
    }
}
