using System;

namespace AS3
{

    class Program
    {
        static void Main()
        {

            int luku1, luku2, luku3;

            Console.Write("Anna luku1 > ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku2 > ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna luku2 > ");
            luku3 = int.Parse(Console.ReadLine());

            int lukusum = luku1 + luku2 + luku3;
            int lukuka = (luku1 + luku2 + luku3) / 3;
            Console.Write("Lukujen summa:" + lukusum + "\n");
            Console.Write("Lukujen keskiarvo:" + lukuka + "\n");

        }
    }

}
