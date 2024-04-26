namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //language integrated query

            List<string> students = new List<string>()
            {
                "Tamara", "Sava", "Goran" ,"Milica", "Zarko", "Almir"
            };

            //where(); u sql se cesto koristi

         

                foreach (string studentName in students)
                {
                    if (studentName.Length == 4)
                        Console.WriteLine($"Ovaj student ima 4 slova u svom imenu {studentName}");
                }

                // Manual approach
                List<string> studentsWith5Letters = new List<string>();

                foreach (string studentName in students)
                {
                    if (studentName.Length == 5)
                        studentsWith5Letters.Add(studentName);
                }

                // LINQ approach
                List<string> studentsWithFiveLetters = students
                    .Where(item => item.Length == 5)
                    .ToList();

                Console.WriteLine("Pet slova u svom imenu");
                foreach (string studentName in studentsWithFiveLetters)
                    Console.WriteLine(studentName);

                //select();




        }
    }
}
