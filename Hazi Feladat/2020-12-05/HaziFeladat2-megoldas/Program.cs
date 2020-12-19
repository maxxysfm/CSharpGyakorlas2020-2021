using System;

namespace HaziFeladat2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Megoldás 1. Feladat
            int[] tomb1 = new int[5];

            int osszeg = 0;
            int max = 0;
            for (int i = 0; i < tomb1.Length; i++)
            {
                tomb1[i] = Convert.ToInt32(Console.ReadLine());
                
                if (i == 0)
                {
                    max = tomb1[i];
                }
                else if (tomb1[i] > max)
                {
                    max = tomb1[i];
                }
                
                osszeg += tomb1[i];
            }
            Console.WriteLine($"Összeadás értéke {osszeg}");

            // Megoldás 2. Feladat
            int[] tomb2 = new int[10] { 5, 25, 12, 0, -5, 124, 12, 5, 12, 2 };

            Array.Sort(tomb2);
            Console.WriteLine("Növekvő sorrend:");
            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.WriteLine(tomb2[i]);
            }
            //Array.Reverse(tomb2);

            // Megoldás 3. Feladat
            int[] tomb3 = new int[10] { 11, 12, 12, 4, 5, 12, 2, 5, 5, 99 };

            int hanyszorFordulElo = 1;
            int legtobbszorElofordulo = tomb3[0];

            int rekord = 0;

            for (int i = 1; i < tomb3.Length; i++)
            {
                if (tomb3[i] == tomb3[i-1])
                {
                    rekord++;
                }
                else
                {
                    rekord = 1;
                }
                if (rekord > hanyszorFordulElo)
                {
                    legtobbszorElofordulo = tomb3[i];
                    hanyszorFordulElo = rekord;
                }
            }
            Console.WriteLine($"{legtobbszorElofordulo} az {hanyszorFordulElo}-szer fordult elő egymás után!");
        }
    }
}
