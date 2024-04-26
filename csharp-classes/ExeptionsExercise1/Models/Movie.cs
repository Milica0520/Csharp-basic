using ExeptionsExercise1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionsExercise1.Models
{
    public class Movie
    {
        public Movie()
        {

        }
        public Movie(string Title, Genre Genre, double TicketPrice, int Rating)
        {
            this.Title = Title;
            this.Genre = Genre;
            this.TicketPrice = 5 * Rating;

            if (Rating > 5 || Rating < 1)
            {
                throw new Exception("There is only rating from 1 to 5. Please enter number in that range.");
            }

        }
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public double TicketPrice { get; set; }

        public int Rating { get; set; }



    }
}
