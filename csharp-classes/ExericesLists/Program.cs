namespace ExericesLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

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




        }
    }
}
