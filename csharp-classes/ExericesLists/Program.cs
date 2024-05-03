using ExericesLists.Enums;
using ExericesLists.Models;

namespace ExericesLists
{
    public class Program
    {
        static void Main(string[] args)
        {
            //fans
   
            Person Jerry = new Person("Jerry", "Tompson", 78, Genre.Classical,null);
            Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Classical,null);
            Person Maria = new Person("Maria", "Campbel", 43, Genre.Hip_Hop,null);
            Person Jane = new Person("Jane", "Doe", 28, Genre.Techno,null);

            List<Person> FansArray = new List<Person>();

            //songs
            Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
            Song song2 = new Song("Stairway To Heaven", 480, Genre.Rock);
            Song song3 = new Song("Riders On The Storm", 430, Genre.Rock);
            Song song4 = new Song("Not Fade Away", 108, Genre.Rock);
            Song song5 = new Song("Breaking Glass", 111, Genre.Rock);
            Song song6 = new Song("Welcome To The Jungle", 275, Genre.Rock);
            Song song7 = new Song("Walk Of Life", 266, Genre.Rock);
            Song song8 = new Song("Smoke on the Water", 340, Genre.Rock);
            Song song9 = new Song("93 'til Infinity", 209, Genre.Techno);
            Song song10 = new Song("Fight the Power", 321, Genre.Techno);
            Song song11 = new Song("The Message", 363, Genre.Techno);
            Song song12 = new Song("Butterfly Effect", 213, Genre.Techno);
            Song song13 = new Song("No Fear", 182, Genre.Techno);
            Song song14 = new Song("Hereditary", 340, Genre.Techno);
            Song song15 = new Song("Bounce Back", 226, Genre.Techno);
            Song song16 = new Song("The Four Seasons", 2520, Genre.Classical);
            Song song17 = new Song("Canon in D major", 376, Genre.Classical);
            Song song18 = new Song("Swan Lake", 461, Genre.Classical);
            Song song19 = new Song("Symphony No. 5", 425, Genre.Classical);
            Song song20 = new Song("Ride of the Valkyries", 608, Genre.Classical);
            Song song21 = new Song("The Magic Flute", 458, Genre.Classical);
            Song song22 = new Song("Carmen Suite No.1", 721, Genre.Classical);
            Song song23 = new Song("Planet E", 420, Genre.Techno);
            Song song24 = new Song("Phasor", 368, Genre.Techno);
            Song song25 = new Song("Counting Comets", 242, Genre.Techno);
            Song song26 = new Song("Cold Summer", 358, Genre.Techno);
            Song song27 = new Song("Destroyer", 359, Genre.Techno);
            Song song28 = new Song("Phalanx", 307, Genre.Techno);
            Song song29 = new Song("Vision", 693, Genre.Techno);
            Song song30 = new Song("Chain Reaction", 181, Genre.Techno);

            List<Song> Songs = new List<Song>() { song1, song2, song3, song4, song5, song6, song7,
            song8, song9, song10, song11, song12, song13, song14, song15,
            song16, song17, song18, song19, song20, song21, song22, song23,
            song24, song25, song26, song27, song28, song29, song30 };

            FansArray.Add(Jerry);
            FansArray.Add(Stefan);
            FansArray.Add(Maria);
            FansArray.Add(Jane);
            /*
            Dictionary<string, string > PhoneBook = new Dictionary<string, string>()
            {
                {"Tamara" , "165-789-425"},
                {"Djordje" , "066-894-785"},
                {"Almir" , "777-789-425"},
                {"Sava" , "444-789-425"},
                {"Goran" , "888-789-425"},
            };
            Console.WriteLine("Enter name : ");
            string nameInp = Console.ReadLine();

            bool contactFound = false;
            foreach (KeyValuePair<string, string> contact in PhoneBook)
            {
                if (PhoneBook.ContainsKey(nameInp))
                {
                    contactFound = true;
                    Console.WriteLine($"The {contact.Key} phone number is {contact.Value} ");
                }
              
            }
             if(contactFound == false)
            {
                Console.WriteLine("No contact with that name.");
            }
            */
            //Select the person Jerry and add all the songs which start with  the letter B
            List<Person> JerryPerson = FansArray.Where(fun => fun.FirstName == "Jerry").ToList();
            List<Song> firstLetterBsongs = Songs.Where(song => song.Title.StartsWith("B")).ToList();


            var jerry = JerryPerson[0];
            jerry.FavoriteSongs = firstLetterBsongs;

 
            //Select the person Maria and add all the songs with length longer than 6 min.
            List<Person> MariaPerson = FansArray.Where(fun => fun.FirstName == "Maria").ToList();
            List<Song> sixMinsSongs  = Songs.Where(song => song.Length > 360).ToList();
            MariaPerson[0].FavoriteSongs = sixMinsSongs;


            //Select the person Jane and add all the songs that are of genre Rock
            List<Person> JanePerson = FansArray.Where(fun => fun.FirstName == "Jane").ToList();
            List<Song> rockSongs = Songs.Where(song => song.Genre == Genre.Rock).ToList();
            JanePerson[0].FavoriteSongs = rockSongs;

            //Select the person Stefan and add all songs shorter than 3 min and of genre Hip - Hop
            List<Person> StefanPerson = FansArray.Where(fun => fun.FirstName == "Stefan").ToList();
            List<Song> hiphopSongs = Songs.Where(song => song.Genre == Genre.Hip_Hop).ToList();
            StefanPerson[0].FavoriteSongs = hiphopSongs;

            //Select all persons from the persons array that have 4 or more songs
            List<Person> PersonsWith4Songs = FansArray.Where(fun => fun.FavoriteSongs.Count > 4).ToList();

            Console.WriteLine(PersonsWith4Songs.Count);



        }
    }
}
