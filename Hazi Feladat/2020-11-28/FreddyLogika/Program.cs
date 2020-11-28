using System;
using System.Threading;

namespace FreddyLogika
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //
                Thread.Sleep(1000);
                Console.WriteLine("Freddy gondolkodik...");
            }
        }
    }
}
