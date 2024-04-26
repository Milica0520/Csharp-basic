using ExeptionsExercise1.Enums;
using ExeptionsExercise1.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text;

namespace ExeptionsExercise1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>
            {
             new Movie("Wonka", Enums.Genre.Comedy,20.5, 5),
             new Movie("Chucky",Enums. Genre.Horror,15.4, 4),
             new Movie("Fallout", Enums.Genre.Action,10, 3),
             new Movie("The Sympathizer",Enums. Genre.Drama,15, 2),
             new Movie("Transformers One",Enums.Genre.SciFi,8, 1),
             new Movie("Deadpool & Wolverine",Enums. Genre.Comedy,9, 5),
             new Movie("Alien: Romulus",Enums. Genre.Horror,10, 4),
             new Movie("Civil War",Enums.Genre.Action,16, 3),
             new Movie("Oppenheimer", Enums.Genre.Drama,10, 2),
             new Movie("Interstellar",Enums. Genre.SciFi,10, 1)
             };

            Cinema cinema1 = new Cinema("Cinestar", "StarHall", movies);


            Console.WriteLine("Choose cinema: ");
            string cinemaInp = Console.ReadLine();//pretpostavimo da je uneseno cinema1
            Console.WriteLine("Would you like to see all movies or by genre? ");
            string userInp = Console.ReadLine();


            if (userInp == "all movies")
            {
                foreach (Movie movie in cinema1.ListOfMovies)
                {
                    Console.WriteLine($"{movie.Title}");
                }

                Console.WriteLine($"Choose the movie:");
                string moveTiteInp = Console.ReadLine();

                foreach (Movie movie in cinema1.ListOfMovies)
                {
                    if (moveTiteInp == movie.Title)
                    {
                        cinema1.MoviePlaying(movie);
                        Console.WriteLine($"The {movie} is playing");

                    }
                }

            }
            else if (userInp == "genre")
            {
                Console.WriteLine("Witch genre you would like to watch: \n1.Comedy\n2.Horror\n3.Action\n4.Drama\n5.SciFi");
                Console.WriteLine("Enter your favorite genre: ");
                int ganreInp = int.Parse(Console.ReadLine());

                Genre userSelectedGenre = Genre.Drama;

                switch (ganreInp)
                {
                    case 1:
                        userSelectedGenre = Genre.Comedy;
                        break;
                    case 2:
                        userSelectedGenre = Genre.Horror;
                        break;
                    case 3:
                        userSelectedGenre = Genre.Action;
                        break;
                    case 4:
                        userSelectedGenre = Genre.Drama;
                        break;
                    case 5:
                        userSelectedGenre = Genre.SciFi;
                        break;
                    default:
                        Console.WriteLine("Enter number for genre from 1 to 5.");
                        break;
                }


                List<Movie> moviesByGenre = cinema1.ListOfMovies.Where(movie => movie.Genre == userSelectedGenre).ToList();

                foreach (Movie movie in moviesByGenre)
                {
                    Console.WriteLine($"{movie.Title}");
                }

                Console.WriteLine("Enter the title of the move you want to watch: ");
                string moveByGenreInp = Console.ReadLine();

                foreach (Movie movie in moviesByGenre)
                {
                    if (moveByGenreInp == movie.Title)
                        cinema1.MoviePlaying(movie);
                }

            }



        }
    }
}

