using ExericesLists.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericesLists.Models
{
    public class Person
    {
        

     
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }

        public Person( string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSongs)
        {
          
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoriteMusicType;
            FavoriteSongs = new List<Song>();

        }
        public void GetFavoriteSong()
        {
           if(FavoriteSongs.Count > 0)
           {
                foreach (Song song in FavoriteSongs)
                    Console.WriteLine(song);  
           }else
           {
                Console.WriteLine("There is no favorite music now");
           }

          
        }
      

    }
}
