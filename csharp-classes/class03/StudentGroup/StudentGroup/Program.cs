namespace StudentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //enter names for first group
            string[] studentsG1 = new string[5];
            Console.WriteLine("Enter names for sudent group 1 :");

            for (int i = 0; i < studentsG1.Length; i++)
            {
                string inputName = Console.ReadLine();
                studentsG1[i] = inputName;
            }
            //enter names for second group
            string[] studentsG2 = new string[5];
            Console.WriteLine("Enter names for sudent group 2 :");

            for (int i = 0; i < studentsG2.Length; i++)
            {
                string inputName = Console.ReadLine();
                studentsG2[i] = inputName;
            }

            //write names of the selected group
            Console.WriteLine("Enter student group(group 1 or 2): ");
            int group = int.Parse(Console.ReadLine());

            if(group == 1)
            {
                for (int i = 0; i < studentsG1.Length; i++)
                {
                    Console.WriteLine(studentsG1[i]);
                }
            }else if( group == 2 )
            {
                for (int i = 0; i < studentsG2.Length; i++)
                {
                    Console.WriteLine(studentsG2[i]);
                }
            }
            else
            {
                Console.WriteLine("You entered wrong group number. Try 1 or 2!");
            }

        }
    }
}
