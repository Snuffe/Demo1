using System;

namespace AS1
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku;
            Console.Write("Anna luku > ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 1)
            {
                Console.WriteLine("yksi");
                System.Threading.Thread.Sleep(1000);

            }

            else if (luku == 2)
            {
                Console.WriteLine("kaksi");
                System.Threading.Thread.Sleep(1000);

            }

            else if (luku == 3)
            {
                Console.WriteLine("kolme");
                System.Threading.Thread.Sleep(1000);

            }

            else
            {
                Console.WriteLine("joku muu luku");
                System.Threading.Thread.Sleep(1000);

            }

        }
    }
}









