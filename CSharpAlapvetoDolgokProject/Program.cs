using System;
using System.Collections.Generic;
using System.Dynamic;

namespace CSharpValtozokIsmetles
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////// ////////// //////////////////
            /////////////// Alap fogalmak //////////////////
            /////////////// ////////// //////////////////

            // Változók, típusok

            // bool - A változó típusa
            // "valami" - A változó neve, amit mi látunk
            // = false - megadott alapvető érték

            bool valami = false;
            bool valamiUres = new bool();
            valamiUres = false;
            Console.WriteLine(valami);
            Console.WriteLine(valamiUres);

            // "NEM" logika, logikus tagadó, HAMIS-ból IGAZ-t csinál, IGAZ-ból HAMIS-t
            Console.WriteLine(!valami);

            Console.WriteLine(valami == false);
            Console.WriteLine(valami == true);

            // ÉS függvények //
            Console.WriteLine(true && true);
            Console.WriteLine(false && true);
            Console.WriteLine(true && false);
            Console.WriteLine(false && false);

            // VAGY függvények //
            Console.WriteLine(true || true);
            Console.WriteLine(false || true);
            Console.WriteLine(true || false);
            Console.WriteLine(false || false);

            /////////////////////////////////////
            //////////  INT operátorok //////////
            /////////////////////////////////////

            // Nem inicializált int szám
            int egyUresSzam = new int();

            // inicializáljuk a számot egy értékkel.
            egyUresSzam = 5;
            Console.WriteLine(egyUresSzam);

            // Egy konkrét szám, ami még változhat.
            int egySzam = 1;

            // Értékek megváltoztatása
            Console.WriteLine(egySzam += 5);
            Console.WriteLine(egySzam -= 10);
            Console.WriteLine(egySzam *= 10);
            Console.WriteLine(egySzam /= 10);

            Console.WriteLine(egySzam = egySzam + 5);

            int masikSzam = 5;
            Console.WriteLine(egySzam = egySzam + masikSzam);

            // Stringek
            string nev = "attila szabo";
            Console.WriteLine(nev);

            // String kiegészítése
            nev += "attila";

            // String felülírása
            nev = "attila";

            // Más értékek beleírása, pl.: számokat string-be.
            nev += Convert.ToString(9) + " szabó";

            Console.WriteLine(nev);
            Console.WriteLine(nev.Contains("attila"));
            Console.WriteLine(nev.Contains(" "));
            Console.WriteLine(nev.Contains("balint"));
            Console.WriteLine(nev.Substring(2, 3));
            Console.WriteLine(nev.Length);

            // Kiírás objektumok szerint.
            string nevem = "Szabó Attila";
            string megye = "Fejér";
            int szulEv = 1996;

            Console.WriteLine("Név:{0} Megye:{1} Születési év:{2}", nevem, megye, szulEv);
            // Vagy + jelek és "" elválasztással.
            Console.WriteLine("Név:" + nevem + " Megye:" + megye + " Születési év:" + szulEv);
            // Vagy: $ használatával lehet írni így is.
            Console.WriteLine($"Név:{nevem} Megye:{megye} Születési év:{szulEv}");

            /////////////// ////////// //////////////////
            /////////////// Elágazások //////////////////
            /////////////// ////////// //////////////////

            if (true)
            {
                //valamit csinál
            }

            bool elagazas = true;
            if (elagazas)
            {
                //valami
            }
            else
            {
                //ha "if" nem igaz
            }

            bool feltetel1 = false;
            bool feltetel2 = false;
            bool feltetel3 = false;

            if (feltetel1)
            {
                //Ezeket az utasításokat akkor hajtjuk végre, ha a feltétel1 igaz
            }
            else if (feltetel2)
            {
                //Ezeket az utasításokat akkor hajtjuk végre, ha a feltétel2 igaz
            }
            else if (feltetel3)
            {
                //Ezeket az utasításokat akkor hajtjuk végre, ha a feltétel3 igaz
            }
            else
            {
                //Ezeket az utasításokat akkor hajtjuk végre, 
                // ha az összes feltétel hamis értéket ad vissza.
            }

            // Switch elágazás
            // Csak egy értéket vizsgál, míg else if elágazások több feltételt is vizsgálnak

            Random r = new Random();
            int szamunk = r.Next(0, 100 + 1);
            switch (szamunk)
            {
                case 0:
                    Console.WriteLine("Ön nyert egy luxur autót!");
                    break;
                case 1:
                    Console.WriteLine("Ön nyert egy házat!");
                    break;
                case 2:
                    Console.WriteLine("Ön nyert egy koncert jegyet!");
                    break;
                default:
                    Console.WriteLine("Nem nyert!");
                    break;
            }

            /////////////// ////////// //////////////////
            ///////////////  Ciklusok   /////////////////
            /////////////// ////////// //////////////////

            int meddigTart = 0;

            // Csak akkor fut le a while ciklus, ha a feltétel igaz
            while (meddigTart <= 5)
            {
                Console.WriteLine("Tart a ciklus");
                meddigTart++;

                // Ciklus addig tart, amíg nem hamis a feltétel
            }

            // do-while egyszer lefut mindenképp, utána csak akkor ismétlődik
            // ha a feltétel igaz.

            meddigTart = 0;
            do
            {
                Console.WriteLine("Tart a ciklus");
                meddigTart++;
            } while (meddigTart <= 5);

            // For ciklus, addig tart, amíg a középső "feltétel" igaz

            // első érték, ciklus ideje alatt létrejövő számláló
            // középsé érték: feltétel
            // utolsó érték, a ciklus ismétlése során lefutó függvény
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(i);
            }

            // Tömbök, "Array"
            int[] sokSzam = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(sokSzam[0]);
            Console.WriteLine(sokSzam[1]);

            // Sorrendbe rendezés
            Array.Sort(sokSzam);
            // Megfordítás
            Array.Reverse(sokSzam);

            foreach (int item in sokSzam)
            {
                Console.WriteLine(item);
            }

            // 2 dimenziós tömb
            int[,] sokSzam2D = new int[2, 5] { { 1, 2, 3, 4, 5 }, { 1, 2, 3, 4, 5 } };
            Console.WriteLine(sokSzam2D[0,0]);
            Console.WriteLine(sokSzam2D[1,4]);

            // Legkisebb érték megkeresése
            int[] szamokKeresesre = new int[6] { 50, 2, 502, 12, 8, 1 };
            int min = szamokKeresesre[0];

            // szamokKeresesre.Length = visszaadja, mennyi számból áll a tömb
            for (int i = 0; i < szamokKeresesre.Length; i++)
            {
                if (min> szamokKeresesre[i])
                {
                    min = szamokKeresesre[i];
                }
            }

            // Lista
            List<int> szamLista = new List<int>();
            szamLista.Add(671);
            szamLista.Add(15);

            // Sorrendbe állítás
            szamLista.Sort();
            // lista megfordítása
            szamLista.Reverse();

            for (int i = 0; i < szamLista.Count; i++)
            {
                Console.WriteLine(szamLista[i]);
            }
            // vagy
            foreach (int item in szamLista)
            {
                Console.WriteLine(item);
            }

            // Tuple
            (int, string) tuple = (5, "Valami");
            (int, string, bool) tuple2 = (5, "Valami",false);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(tuple2.Item3);

            List<(int, string)> tupleList = new List<(int, string)>();
            tupleList.Add((5,"valami"));
            tupleList.Add((2,"valami2"));
        }
    }
}
