using System;
using System.Threading;

namespace FreddyLogika
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("írd be a nehézségi szintet");
            //string nehezseg = Console.ReadLine();
            //Convert.ToInt32(nehezseg);
            bool jatekhossz = true;
            


            Random r = new Random();
            

            int freddyszam = r.Next(1, 6);
            Console.WriteLine("Freddy másszkálós kedvében van:(");
            int helységszám = 0;
            while (jatekhossz==true)
            {
                int mozgasg = r.Next(1, 4);

                helységszám = helységszám + 1;

                if (helységszám == 1)
                {
                    Thread.Sleep(1 / freddyszam);
                    Console.WriteLine("Freddy a szinpadon van MÉG");
                }
                else if (helységszám == 2 && mozgasg ==2)
                {
                    Thread.Sleep(5000 / freddyszam);
                    Console.WriteLine("Freddy az étkezdében van");
                }
                else if (helységszám == 3 && mozgasg == 2)
                {
                    Thread.Sleep(5000 / freddyszam);
                    Console.WriteLine("Freddynek vécéznie kell (Wcben van)");
                }
                else if (helységszám == 4 && mozgasg == 2)
                {
                    Thread.Sleep(5000 / freddyszam);
                    Console.WriteLine("Freddy megéhezett MOST csak szendvicsre (konyhában van)");
                }
                else if (helységszám == 5 && mozgasg == 2)
                {
                    Thread.Sleep(5000 / freddyszam);
                    Console.WriteLine("Freddy a folyosón van!!!!!!!!!:(");
                }
                else if (helységszám == 6 && mozgasg == 2)
                {
                    Thread.Sleep(5000 / freddyszam);
                    Console.WriteLine("Melleted");
                    jatekhossz = false;
                }
                else
                {
                    helységszám = helységszám - 1;
                }
            }
            Console.WriteLine("Játéknak vége");
        }
    }
}
