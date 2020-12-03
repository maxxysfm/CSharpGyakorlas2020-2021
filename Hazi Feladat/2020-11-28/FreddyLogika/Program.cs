using System;
using System.Threading;

namespace FreddyLogika
{
    class Program
    {
        static void Main(string[] args)
        {

            /// Legyünk pontosak! Mondjuk meg, mekkora szám legyen a legnagyobb.
            //Console.WriteLine("írd be a nehézségi szintet");

            /// Lehet így is bekérni értéket, ezt viszont később átkell alakítani.
            //string bekertErtek = Console.ReadLine();

            /// Átalakítás, jó volt majdnem! De tárolni kell egy "integer" változóban a számunkat.
            /// PL.: Így: 
            /// int valami = Convert.ToInt32(bekertErtek);
            //Convert.ToInt32(bekertErtek);

            // Üres változó-t előbb létrehozunk, még nem döntöttük el a nehézséget.
            int nehezseg = -1;

            /// Addig kérünk be új számot, amíg nem 0-20 ig írunk be egy értéket!
            /// -1 < 0  -> TRUE
            /// -1 > 20 -> FALSE
            /// TRUE VAGY FALSE == TRUE -> Ciklus ismétlődik.

            /// 5 < 0  -> FALSE
            /// 5 > 20 -> FALSE
            /// FALSE VAGY FALSE == FALSE -> Ciklus kilép, ha helyes számot írunk be!
            while (nehezseg < 0 || nehezseg > 20)
            {
                Console.WriteLine("Írd be a nehézségi szintet 1-20-ig.");
                
                /// Ha nem számot írunk be, akkor a program lefagy.
                nehezseg = Convert.ToInt32(Console.ReadLine());
            }

            bool jatekhossz = true;

            /// Nagyon jó! Bármikor tudjuk használni az r változót a program futása alatt ha kell random szám.
            Random r = new Random();

            /// Biztos itt akartad tárolni, hogy Freddy nehézségi szintje mekkora
            //int freddyszam = r.Next(1, 6);
            
            
            Console.WriteLine("Freddy másszkálós kedvében van:(");

            /// Szép! :D De a név nem lehet "helységszám", ékezeteket kerüljük el.
            int helysegSzam = 0;
            
            while (jatekhossz==true)
            {
                /// Itt lett volna fontos az, hogy Freddy mozgását a nehézség valahogy befolyásolja,
                /// Itt ez nem történik meg.
                //int mozgasg = r.Next(1, 4);

                /// Ezt a logikát írtam helyette.
                /// Freddy mindegyik másodpercben kap esély-t hogy mozogjon.
                /// A nehézség ha 0, akkor nagyon kicsi az esély rá hogy mozogjon.
                /// Ha viszont 20, akkor sokkal gyakrabban mozog, gyakrabban lesz az "IF" függvény igaz.
                
                // 1000 = 1 másodperc, 1000 milisec
                Thread.Sleep(1000);

                /// 0-100ig generálunk számot
                /// (nehezseg) + 10; Alap nehézség, 10% esély amit alapból kap Freddy a mozgásra.
                if (r.Next(0,100) < (nehezseg)+10)
                {
                    // Freddy cselekszik.
                    /// Ez jó volt, így növeljük az integertet!
                    /// Elég ilyenkor növelni az értéket, mivel Freddy ilyenkor mozog!
                    
                    // Így is lehet
                    /// helysegSzam++;
                    /// helysegSzam += 1;
                    helysegSzam = helysegSzam + 1;

                    /// Ha Freddy sikeresen mozog, akkor következő 2-4 másodpercben nem cselekszik.
                    /// 1000 * ( 2 vagy 4 ) = 2-4 másodperc
                    Thread.Sleep(1000*r.Next(2,4+1));
                    
                    if (helysegSzam == 1)
                    {
                        //Console.WriteLine("Freddy a szinpadon van MÉG");
                        
                        /// Freddy első mozdulata után aktiválva lesz.
                        Console.WriteLine("Freddy a szinpadon van MÉG, most már aktív lesz!");
                    }

                    /// Itt ellenőrizted, hogy Freddy mozog-e, viszont a nehézséget nem számította bele.
                    /// 1-4ig lehetett a "mozgasd" értéke, szóval 25% (1/4) esélye volt mozgásra.
                    //else if (helysegSzam == 2 && mozgasg == 2)
                    
                    else if (helysegSzam == 2)
                    {
                        /// 5000/Freddy nehézség, ez csak le redukálja, hogy Freddy mikor mozog legközelebb.
                        //Thread.Sleep(5000 / freddyszam);
                        
                        Console.WriteLine("Freddy az étkezdében van");
                    }
                    else if (helysegSzam == 3)
                    {
                        //Thread.Sleep(5000 / freddyszam);
                        Console.WriteLine("Freddynek vécéznie kell (Wcben van)");
                    }
                    else if (helysegSzam == 4)
                    {
                        //Thread.Sleep(5000 / freddyszam);
                        Console.WriteLine("Freddy megéhezett MOST csak szendvicsre (konyhában van)");
                    }
                    else if (helysegSzam == 5)
                    {
                        //Thread.Sleep(5000 / freddyszam);
                        Console.WriteLine("Freddy a folyosón van!!!!!!!!!:(");
                    }
                    else if (helysegSzam == 6)
                    {
                        //Thread.Sleep(5000 / freddyszam);
                        Console.WriteLine("Melleted");

                        /// Nagyon jó!
                        jatekhossz = false;
                    }
                    
                    /// Mivel helységszámot növelted, azért csökkenteni is kellett, 
                    /// de nem muszály növelni az értéket, csak akkor nyúlunk hozzá,
                    /// ha Freddy mozog.
                    //else
                    //{
                    //    helysegSzam = helysegSzam - 1;
                    //}
                }
            }
            Console.WriteLine("Játéknak vége");
        }
    }
}
