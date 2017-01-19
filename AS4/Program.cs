using System;
namespace AS3
{

    class Program
    {
        static void Main()
        {

            int age;

            Console.Write("Input your age > ");
            age = int.Parse(Console.ReadLine());

            if (age > 18 && age < 66)
            {
                Console.Write("Adult \n");
            }
            else if (age < 18)
            {
                Console.Write("Underage \n");
            }
            else
            {
                Console.Write("Senior \n");
            }

        }
    }

}
