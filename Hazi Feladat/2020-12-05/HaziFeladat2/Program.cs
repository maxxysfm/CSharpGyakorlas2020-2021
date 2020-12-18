using System;

namespace HaziFeladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            string bekert1 = Console.ReadLine();
            string bekert2 = Console.ReadLine();
            string bekert3 = Console.ReadLine();
            string bekert4 = Console.ReadLine();
            string bekert5 = Console.ReadLine();
            int tombbekert1 = Convert.ToInt32(bekert1);
            int tombbekert2 = Convert.ToInt32(bekert2);
            int tombbekert3 = Convert.ToInt32(bekert3);
            int tombbekert4 = Convert.ToInt32(bekert4);
            int tombbekert5 = Convert.ToInt32(bekert5);
            int[] tomb1 = new int[5];
            tomb1[0] = tombbekert1;
            tomb1[1] = tombbekert2;
            tomb1[2] = tombbekert3;
            tomb1[3] = tombbekert4;
            tomb1[4] = tombbekert5;
            
            Console.WriteLine(tomb1[0] + tomb1[1] + tomb1[2] + tomb1[3] + tomb1[4]);
            Console.WriteLine("{0}a legnagyobb szám", tomb1);
            //int min = tomb1(0);
            

            int[] tomb2 = new int[10] { 5, 25, 12, 0, -5, 124, 12, 5, 12, 2 };
            Array.Reverse(tomb2);

            int[] tomb3 = new int[10] { 10, 10, 10, 5, 5, 12, 12, 12, 12, 99 };
        }
    }
}
